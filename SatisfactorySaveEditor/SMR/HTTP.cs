﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace SMRAPI
{
    /// <summary>
    /// Handler for when the key is received
    /// </summary>
    /// <param name="sender"><see cref="HTTP"/> instance</param>
    /// <param name="ApiKey">API key</param>
    public delegate void ApiKeyEventHandler(object sender, Guid ApiKey);

    /// <summary>
    /// Provides a key retrieval service demonstration using the windows HTTP API
    /// </summary>
    public class HTTP : IDisposable
    {
        /// <summary>
        /// HTML framework for all pages
        /// </summary>
        private const string HTML_FRAME = @"<!DOCTYPE html><html>
<head>
    <title>Satisfactory Save Editor</title>
    <style>
        body{
            font-family:sans-serif;
            max-width:500px;
            margin-left:auto;
            margin-right:auto;
        }
        a{
            color:#00F;
        }
        .success{
            color:#090;
        }
        .failure{
            color:#F00;
        }
    </style>
</head>
<body>
    {CONTENT}
    <hr/>
    <p>Generated by <code title={EXEPATH}>{EXENAME}</code></p>
</body></html>";

        /// <summary>
        /// Event for when a key is received
        /// </summary>
        public event ApiKeyEventHandler ApiKeyEvent = delegate { };

        /// <summary>
        /// Authentication URL
        /// </summary>
        public string AuthUrl { get; set; }
        public Dictionary<string, ResponseData> StaticResources { get; set; }

        private string ExeName;
        /// <summary>
        /// Provides internal synchronization
        /// </summary>
        private object Locker = new object();
        /// <summary>
        /// HTTP server
        /// </summary>
        private HttpListener L;

        /// <summary>
        /// Initializes a new HTTP server on the given port
        /// </summary>
        /// <param name="Port">Listening Port</param>
        public HTTP(int Port)
        {
            //Get Executable name
            using (var P = Process.GetCurrentProcess())
            {
                ExeName = P.MainModule.FileName;
            }
            L = new HttpListener();
            //Don't try to change. It must be "localhost" or you must be administrator
            L.Prefixes.Add($"http://localhost:{Port}/");
            //Default authentication URL from API
            AuthUrl = API.API_AUTH
                .Replace(API.API_AUTH_URL_PLACEHOLDER, Uri.EscapeDataString(L.Prefixes.First() + "?key={APIKEY}"))
                .Replace(API.API_AUTH_NAME_PLACEHOLDER, Uri.EscapeDataString("Satisfactory Save Editor"));
            StaticResources = new Dictionary<string, ResponseData>();
        }

        /// <summary>
        /// Waits for the web service to be stopped or disposed
        /// </summary>
        public void WaitForExit()
        {
            try
            {
                while (L != null && L.IsListening)
                {
                    Thread.Sleep(100);
                }
            }
            catch
            {
                //L probably got nulled between the null check and the listening check
            }
        }

        /// <summary>
        /// Opens <see cref="AuthUrl"/> in the default browser
        /// </summary>
        public void OpenBrowser()
        {
            Process.Start(AuthUrl);
        }

        /// <summary>
        /// Starts the HTTP server
        /// </summary>
        public void Start()
        {
            lock (Locker)
            {
                if (L == null)
                {
                    throw new ObjectDisposedException(nameof(HTTP));
                }
                if (!L.IsListening)
                {
                    L.Start();
                    L.BeginGetContext(conin, null);
                }
            }
        }

        /// <summary>
        /// Stops the HTTP server
        /// </summary>
        public void Stop()
        {
            lock (Locker)
            {
                if (L == null)
                {
                    throw new ObjectDisposedException(nameof(HTTP));
                }
                if (L.IsListening)
                {
                    L.Stop();
                }
            }
        }

        /// <summary>
        /// Disposes this instance
        /// </summary>
        public void Dispose()
        {
            lock (Locker)
            {
                if (L != null)
                {
                    Stop();
                    L.Abort();
                    L = null;
                }
            }
        }

        /// <summary>
        /// Build HTML frame
        /// </summary>
        /// <param name="Content">Body content</param>
        /// <returns>HTML frame</returns>
        private string MkHtml(string Content)
        {
            return HTML_FRAME
                .Replace("{EXENAME}", Path.GetFileName(ExeName))
                .Replace("{EXEPATH}", "\"" + ExeName + "\"")
                .Replace("{CONTENT}", Content)
                .Replace("{AUTHURL}", AuthUrl);
        }

        /// <summary>
        /// Handler for connections
        /// </summary>
        /// <param name="ar">Async Result</param>
        private void conin(IAsyncResult ar)
        {
            HttpListenerContext Req = null;
            //Listener has already been disposed
            if (L == null)
            {
                return;
            }
            if (L.IsListening)
            {
                try
                {
                    Req = L.EndGetContext(ar);
                    L.BeginGetContext(conin, null);
                }
                catch
                {
                    //Don't care anymore. Listener probably gone
                }
                if (Req != null)
                {
                    Handle(Req);
                }
            }
        }

        /// <summary>
        /// Handles a HTTP request
        /// </summary>
        /// <param name="Req">HTTP request</param>
        private void Handle(HttpListenerContext Req)
        {
            //Holds the response data
            byte[] data = new byte[0];
            //Handler for full URLs
            var FullUrl = new Uri(new Uri(L.Prefixes.First()), Req.Request.RawUrl);
            Guid ApiKey = Guid.Empty;
            bool TriggerEvent = false;

            //Check if request for server root
            if (FullUrl.AbsolutePath == "/")
            {
                using (var SW = new StreamWriter(new MemoryStream()))
                {
                    Req.Response.ContentType = "text/html";
                    //Check if an API key is present
                    if (Guid.TryParse(Req.Request.QueryString["key"], out ApiKey))
                    {
                        TriggerEvent = true;
                        if (ApiKey != Guid.Empty)
                        {
                            SW.WriteLine(MkHtml(@"
<h1>Satisfactory Save Editor</h1>
<p>
    <span class='success'>API authorized</span>.<br />
    The API is available in the save editor now.
    You can close this window.
</p>"));
                        }
                        else
                        {
                            SW.WriteLine(MkHtml(@"
<h1>Satisfactory Save Editor</h1>
<p>
    <span class='failure'>API authorization denied</span>.<br />
    If you accidentally misclicked, <a href='{AUTHURL}'>you can try again</a>,
    otherwise, please close the window.
</p>"));
                        }
                    }
                    else
                    {
                        //No key received. Offer the user to try again
                        var link = "<a href=\"{AUTHURL}\">Click here to try again</a>.";
                        SW.WriteLine(MkHtml($"<h1>Satisfactory Save Editor</h1><p>Error decoding the key.<br /><b>{link}</b></p>"));
                    }
                    SW.Flush();
                    data = ((MemoryStream)SW.BaseStream).ToArray();
                }
            }
            else
            {
                ResponseData D = null;
                if (StaticResources.TryGetValue(FullUrl.AbsolutePath, out D))
                {
                    data = null;
                    Req.Response.ContentType = D.ContentType;
                    if (D.Length >= 0)
                    {
                        Req.Response.ContentLength64 = D.Length;
                    }
                    D.CopyTo(Req.Response.OutputStream);
                }
                else
                {
                    //All requests that still have no response are answered with a 404
                    Req.Response.StatusCode = 404;
                    data = Encoding.UTF8.GetBytes(MkHtml(@"<h1>Satisfactory Save Editor - Not found</h1>
<p>
    <span class='failure'>The requested page could not be found</span>.<br />
    <a href='{AUTHURL}'>click here to try to authorize again</a>.
</p>"));
                }
            }
            if (data != null)
            {
                //Setting the content length is optional but avoids chunked encoding
                Req.Response.ContentLength64 = data.Length;
                //Send data
                Req.Response.Close(data, true);
            }
            else
            {
                Req.Response.Close();
            }
            //Make sure to only trigger the event after the response was closed.
            //If the event stops the HTTP listener you end up in a race condition otherwise
            //that might drop the answer.
            if (TriggerEvent)
            {
                //Don't block this thread with the event.
                var T = new Thread(delegate ()
                {
                    ApiKeyEvent(this, ApiKey);
                });
                T.IsBackground = true;
                T.Start();
            }
        }
    }

    public class ResponseData
    {
        public const string DEFAULT_TYPE = "application/octet-stream";

        private Stream Res;

        public string ContentType { get; private set; }

        public long Length
        {
            get
            {
                try
                {
                    return Res.Length;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public ResponseData(byte[] Content, string ContentType = DEFAULT_TYPE) : this(new MemoryStream(Content, false), ContentType)
        {
        }

        public ResponseData(Stream Content, string ContentType = DEFAULT_TYPE)
        {
            if (Content == null)
            {
                throw new ArgumentNullException(nameof(Content));
            }
            if (ContentType == null)
            {
                throw new ArgumentNullException(nameof(ContentType));
            }
            if (!Content.CanSeek)
            {
                throw new ArgumentException("Stream must be seekable", nameof(Content));
            }
            if (!Content.CanRead)
            {
                throw new ArgumentException("Stream must be readable", nameof(Content));
            }
            Res = Content;
            this.ContentType = ContentType;
        }

        public void CopyTo(Stream Output)
        {
            lock (Res)
            {
                Res.Position = 0;
                Res.CopyTo(Output);
            }
        }
    }
}
