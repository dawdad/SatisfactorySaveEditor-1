﻿namespace SatisfactorySaveEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redrawMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreRocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restorePlantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreBerriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreSlugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAnimalPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spawnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lizardDoggosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropPodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restorePickupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeDoggosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkTogetherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteElementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeDeleterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStringListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.resetRendererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quickActionsToolStripMenuItem,
            this.inventoriesToolStripMenuItem,
            this.generalActionsToolStripMenuItem,
            this.moreToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.updateAvailableToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(592, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.redrawMapToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.toolStripSeparator2,
            this.openLocationToolStripMenuItem,
            this.saveFileManagerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.ToolTipText = "Basic Save file operations";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.ToolTipText = "Opens a save file for editing";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Owerwrites the currently open file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.ToolTipText = "Saves the file under a new name";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // redrawMapToolStripMenuItem
            // 
            this.redrawMapToolStripMenuItem.Name = "redrawMapToolStripMenuItem";
            this.redrawMapToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.redrawMapToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.redrawMapToolStripMenuItem.Text = "&Redraw Map";
            this.redrawMapToolStripMenuItem.Click += new System.EventHandler(this.redrawMapToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits the application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // openLocationToolStripMenuItem
            // 
            this.openLocationToolStripMenuItem.Name = "openLocationToolStripMenuItem";
            this.openLocationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.openLocationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openLocationToolStripMenuItem.Text = "Open &Location";
            this.openLocationToolStripMenuItem.ToolTipText = "Opens the save file directory";
            this.openLocationToolStripMenuItem.Click += new System.EventHandler(this.openLocationToolStripMenuItem_Click);
            // 
            // saveFileManagerToolStripMenuItem
            // 
            this.saveFileManagerToolStripMenuItem.Name = "saveFileManagerToolStripMenuItem";
            this.saveFileManagerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.saveFileManagerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveFileManagerToolStripMenuItem.Text = "Save File &Manager";
            this.saveFileManagerToolStripMenuItem.ToolTipText = "Manage your save files";
            this.saveFileManagerToolStripMenuItem.Click += new System.EventHandler(this.saveFileManagerToolStripMenuItem_Click);
            // 
            // quickActionsToolStripMenuItem
            // 
            this.quickActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapFeaturesToolStripMenuItem,
            this.dropPodsToolStripMenuItem,
            this.funToolStripMenuItem});
            this.quickActionsToolStripMenuItem.Name = "quickActionsToolStripMenuItem";
            this.quickActionsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.quickActionsToolStripMenuItem.Text = "&Quick Actions";
            this.quickActionsToolStripMenuItem.ToolTipText = "Perform predefined bulk actions";
            // 
            // mapFeaturesToolStripMenuItem
            // 
            this.mapFeaturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rocksToolStripMenuItem,
            this.restorePlantsToolStripMenuItem,
            this.restoreBerriesToolStripMenuItem,
            this.restoreSlugsToolStripMenuItem,
            this.removeAnimalPartsToolStripMenuItem,
            this.removeAnimalsToolStripMenuItem});
            this.mapFeaturesToolStripMenuItem.Name = "mapFeaturesToolStripMenuItem";
            this.mapFeaturesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.mapFeaturesToolStripMenuItem.Text = "&Map Features";
            this.mapFeaturesToolStripMenuItem.ToolTipText = "Map/Environment specifics";
            // 
            // rocksToolStripMenuItem
            // 
            this.rocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreRocksToolStripMenuItem,
            this.removeRocksToolStripMenuItem});
            this.rocksToolStripMenuItem.Name = "rocksToolStripMenuItem";
            this.rocksToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rocksToolStripMenuItem.Text = "&Rocks";
            this.rocksToolStripMenuItem.ToolTipText = "Rocks that block items";
            // 
            // restoreRocksToolStripMenuItem
            // 
            this.restoreRocksToolStripMenuItem.Name = "restoreRocksToolStripMenuItem";
            this.restoreRocksToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreRocksToolStripMenuItem.Text = "R&estore";
            this.restoreRocksToolStripMenuItem.ToolTipText = "Restores all rocks";
            this.restoreRocksToolStripMenuItem.Click += new System.EventHandler(this.restoreRocksToolStripMenuItem_Click);
            // 
            // removeRocksToolStripMenuItem
            // 
            this.removeRocksToolStripMenuItem.Name = "removeRocksToolStripMenuItem";
            this.removeRocksToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.removeRocksToolStripMenuItem.Text = "&Remove";
            this.removeRocksToolStripMenuItem.ToolTipText = "Removes all rocks";
            this.removeRocksToolStripMenuItem.Visible = false;
            this.removeRocksToolStripMenuItem.Click += new System.EventHandler(this.removeRocksToolStripMenuItem_Click);
            // 
            // restorePlantsToolStripMenuItem
            // 
            this.restorePlantsToolStripMenuItem.Name = "restorePlantsToolStripMenuItem";
            this.restorePlantsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.restorePlantsToolStripMenuItem.Text = "Restore &Plants";
            this.restorePlantsToolStripMenuItem.ToolTipText = "Restores all plants that have been cut";
            this.restorePlantsToolStripMenuItem.Click += new System.EventHandler(this.restorePlantsToolStripMenuItem_Click);
            // 
            // restoreBerriesToolStripMenuItem
            // 
            this.restoreBerriesToolStripMenuItem.Name = "restoreBerriesToolStripMenuItem";
            this.restoreBerriesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.restoreBerriesToolStripMenuItem.Text = "Restore &Berries";
            this.restoreBerriesToolStripMenuItem.ToolTipText = "Restores berries, nuts and mushrooms";
            this.restoreBerriesToolStripMenuItem.Click += new System.EventHandler(this.restoreBerriesToolStripMenuItem_Click);
            // 
            // restoreSlugsToolStripMenuItem
            // 
            this.restoreSlugsToolStripMenuItem.Name = "restoreSlugsToolStripMenuItem";
            this.restoreSlugsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.restoreSlugsToolStripMenuItem.Text = "Restore &Slugs";
            this.restoreSlugsToolStripMenuItem.ToolTipText = "Restore all collected power slugs";
            this.restoreSlugsToolStripMenuItem.Click += new System.EventHandler(this.restoreSlugsToolStripMenuItem_Click);
            // 
            // removeAnimalPartsToolStripMenuItem
            // 
            this.removeAnimalPartsToolStripMenuItem.Name = "removeAnimalPartsToolStripMenuItem";
            this.removeAnimalPartsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.removeAnimalPartsToolStripMenuItem.Text = "Remove &Animal Parts";
            this.removeAnimalPartsToolStripMenuItem.ToolTipText = "Removes animal parts (like organs) that you might have left on the map";
            this.removeAnimalPartsToolStripMenuItem.Click += new System.EventHandler(this.removeAnimalPartsToolStripMenuItem_Click);
            // 
            // removeAnimalsToolStripMenuItem
            // 
            this.removeAnimalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spawnerToolStripMenuItem,
            this.niceToolStripMenuItem,
            this.evilToolStripMenuItem,
            this.lizardDoggosToolStripMenuItem});
            this.removeAnimalsToolStripMenuItem.Name = "removeAnimalsToolStripMenuItem";
            this.removeAnimalsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.removeAnimalsToolStripMenuItem.Text = "Remove A&nimals";
            this.removeAnimalsToolStripMenuItem.ToolTipText = "Removes animals from the save file";
            // 
            // spawnerToolStripMenuItem
            // 
            this.spawnerToolStripMenuItem.Name = "spawnerToolStripMenuItem";
            this.spawnerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.spawnerToolStripMenuItem.Text = "&Spawner";
            this.spawnerToolStripMenuItem.ToolTipText = "Removes animal spawners";
            this.spawnerToolStripMenuItem.Click += new System.EventHandler(this.spawnerToolStripMenuItem_Click);
            // 
            // niceToolStripMenuItem
            // 
            this.niceToolStripMenuItem.Name = "niceToolStripMenuItem";
            this.niceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.niceToolStripMenuItem.Text = "&Neutral";
            this.niceToolStripMenuItem.ToolTipText = "Removes neutral animals";
            this.niceToolStripMenuItem.Click += new System.EventHandler(this.niceToolStripMenuItem_Click);
            // 
            // evilToolStripMenuItem
            // 
            this.evilToolStripMenuItem.Name = "evilToolStripMenuItem";
            this.evilToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.evilToolStripMenuItem.Text = "&Hostile";
            this.evilToolStripMenuItem.ToolTipText = "Removes hostile animals";
            this.evilToolStripMenuItem.Click += new System.EventHandler(this.evilToolStripMenuItem_Click);
            // 
            // lizardDoggosToolStripMenuItem
            // 
            this.lizardDoggosToolStripMenuItem.Name = "lizardDoggosToolStripMenuItem";
            this.lizardDoggosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.lizardDoggosToolStripMenuItem.Text = "&Lizard Doggos";
            this.lizardDoggosToolStripMenuItem.ToolTipText = "Removes all lizard doggos (including tamed)";
            this.lizardDoggosToolStripMenuItem.Click += new System.EventHandler(this.removeLizardDoggosToolStripMenuItem_Click);
            // 
            // dropPodsToolStripMenuItem
            // 
            this.dropPodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.restorePickupsToolStripMenuItem});
            this.dropPodsToolStripMenuItem.Name = "dropPodsToolStripMenuItem";
            this.dropPodsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.dropPodsToolStripMenuItem.Text = "&Drop Pods";
            this.dropPodsToolStripMenuItem.ToolTipText = "Actions for Drop Pods";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.ToolTipText = "Resets all Drop Pods to the \"unopened\" State";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // restorePickupsToolStripMenuItem
            // 
            this.restorePickupsToolStripMenuItem.Name = "restorePickupsToolStripMenuItem";
            this.restorePickupsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.restorePickupsToolStripMenuItem.Text = "Restore &Pickups";
            this.restorePickupsToolStripMenuItem.ToolTipText = "Restores all items around drop pods";
            this.restorePickupsToolStripMenuItem.Click += new System.EventHandler(this.restorePickupsToolStripMenuItem_Click);
            // 
            // funToolStripMenuItem
            // 
            this.funToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeDoggosToolStripMenuItem});
            this.funToolStripMenuItem.Name = "funToolStripMenuItem";
            this.funToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.funToolStripMenuItem.Text = "&Fun";
            this.funToolStripMenuItem.ToolTipText = "Funny changes that don\'t have a benefit to them";
            // 
            // resizeDoggosToolStripMenuItem
            // 
            this.resizeDoggosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinyToolStripMenuItem,
            this.regularSizeToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.wTFToolStripMenuItem});
            this.resizeDoggosToolStripMenuItem.Name = "resizeDoggosToolStripMenuItem";
            this.resizeDoggosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.resizeDoggosToolStripMenuItem.Text = "&Resize Doggos";
            this.resizeDoggosToolStripMenuItem.ToolTipText = "Resizes lizard doggos";
            // 
            // tinyToolStripMenuItem
            // 
            this.tinyToolStripMenuItem.Name = "tinyToolStripMenuItem";
            this.tinyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tinyToolStripMenuItem.Text = "&Tiny";
            this.tinyToolStripMenuItem.ToolTipText = "Factor: 0.25";
            this.tinyToolStripMenuItem.Click += new System.EventHandler(this.tinyToolStripMenuItem_Click);
            // 
            // regularSizeToolStripMenuItem
            // 
            this.regularSizeToolStripMenuItem.Name = "regularSizeToolStripMenuItem";
            this.regularSizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.regularSizeToolStripMenuItem.Text = "&Regular Size";
            this.regularSizeToolStripMenuItem.ToolTipText = "Factor: 1.0";
            this.regularSizeToolStripMenuItem.Click += new System.EventHandler(this.regularSizeToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.largeToolStripMenuItem.Text = "&Large";
            this.largeToolStripMenuItem.ToolTipText = "Factor: 20";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // wTFToolStripMenuItem
            // 
            this.wTFToolStripMenuItem.Name = "wTFToolStripMenuItem";
            this.wTFToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.wTFToolStripMenuItem.Text = "&WTF";
            this.wTFToolStripMenuItem.ToolTipText = "Factor: 100";
            this.wTFToolStripMenuItem.Click += new System.EventHandler(this.wTFToolStripMenuItem_Click);
            // 
            // inventoriesToolStripMenuItem
            // 
            this.inventoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.linkTogetherToolStripMenuItem});
            this.inventoriesToolStripMenuItem.Name = "inventoriesToolStripMenuItem";
            this.inventoriesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.inventoriesToolStripMenuItem.Text = "&Inventories";
            this.inventoriesToolStripMenuItem.ToolTipText = "Manages inventories";
            this.inventoriesToolStripMenuItem.Visible = false;
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.modifyToolStripMenuItem.Text = "&Modify";
            this.modifyToolStripMenuItem.ToolTipText = "Modifies an inventory";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // linkTogetherToolStripMenuItem
            // 
            this.linkTogetherToolStripMenuItem.Name = "linkTogetherToolStripMenuItem";
            this.linkTogetherToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.linkTogetherToolStripMenuItem.Text = "&Link together";
            this.linkTogetherToolStripMenuItem.ToolTipText = "Links two inventories together";
            this.linkTogetherToolStripMenuItem.Click += new System.EventHandler(this.linkTogetherToolStripMenuItem_Click);
            // 
            // generalActionsToolStripMenuItem
            // 
            this.generalActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editHeaderToolStripMenuItem,
            this.itemCounterToolStripMenuItem,
            this.duplicatorToolStripMenuItem,
            this.deleteElementsToolStripMenuItem,
            this.exportImportToolStripMenuItem,
            this.clearStringListToolStripMenuItem});
            this.generalActionsToolStripMenuItem.Name = "generalActionsToolStripMenuItem";
            this.generalActionsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.generalActionsToolStripMenuItem.Text = "&General Actions";
            this.generalActionsToolStripMenuItem.ToolTipText = "General actions for the save file";
            // 
            // editHeaderToolStripMenuItem
            // 
            this.editHeaderToolStripMenuItem.Name = "editHeaderToolStripMenuItem";
            this.editHeaderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editHeaderToolStripMenuItem.Text = "&Edit Header";
            this.editHeaderToolStripMenuItem.ToolTipText = "Edits the save file header";
            this.editHeaderToolStripMenuItem.Click += new System.EventHandler(this.editHeaderToolStripMenuItem_Click);
            // 
            // itemCounterToolStripMenuItem
            // 
            this.itemCounterToolStripMenuItem.Name = "itemCounterToolStripMenuItem";
            this.itemCounterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemCounterToolStripMenuItem.Text = "&Item Counter";
            this.itemCounterToolStripMenuItem.ToolTipText = "Counts and renders entries";
            this.itemCounterToolStripMenuItem.Click += new System.EventHandler(this.itemCounterToolStripMenuItem_Click);
            // 
            // duplicatorToolStripMenuItem
            // 
            this.duplicatorToolStripMenuItem.Name = "duplicatorToolStripMenuItem";
            this.duplicatorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.duplicatorToolStripMenuItem.Text = "D&uplicator";
            this.duplicatorToolStripMenuItem.ToolTipText = "Duplicates game entries";
            this.duplicatorToolStripMenuItem.Click += new System.EventHandler(this.duplicatorToolStripMenuItem_Click);
            // 
            // deleteElementsToolStripMenuItem
            // 
            this.deleteElementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleterToolStripMenuItem,
            this.rangeDeleterToolStripMenuItem});
            this.deleteElementsToolStripMenuItem.Name = "deleteElementsToolStripMenuItem";
            this.deleteElementsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteElementsToolStripMenuItem.Text = "&Delete Elements";
            this.deleteElementsToolStripMenuItem.ToolTipText = "Deletes entries from the save file using various means";
            // 
            // deleterToolStripMenuItem
            // 
            this.deleterToolStripMenuItem.Name = "deleterToolStripMenuItem";
            this.deleterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleterToolStripMenuItem.Text = "&Delete by type";
            this.deleterToolStripMenuItem.ToolTipText = "Deleted individual entries or groups of them by selecting the entry type, offset " +
    "and count";
            this.deleterToolStripMenuItem.Click += new System.EventHandler(this.deleterToolStripMenuItem_Click);
            // 
            // rangeDeleterToolStripMenuItem
            // 
            this.rangeDeleterToolStripMenuItem.Name = "rangeDeleterToolStripMenuItem";
            this.rangeDeleterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.rangeDeleterToolStripMenuItem.Text = "Delete by &map location";
            this.rangeDeleterToolStripMenuItem.ToolTipText = "Deletes objects inside of a map area";
            this.rangeDeleterToolStripMenuItem.Click += new System.EventHandler(this.rangeDeleterToolStripMenuItem_Click);
            // 
            // exportImportToolStripMenuItem
            // 
            this.exportImportToolStripMenuItem.Name = "exportImportToolStripMenuItem";
            this.exportImportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportImportToolStripMenuItem.Text = "&Export/Import";
            this.exportImportToolStripMenuItem.ToolTipText = "Export and import save file contents";
            this.exportImportToolStripMenuItem.Click += new System.EventHandler(this.exportImportToolStripMenuItem_Click);
            // 
            // clearStringListToolStripMenuItem
            // 
            this.clearStringListToolStripMenuItem.Name = "clearStringListToolStripMenuItem";
            this.clearStringListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearStringListToolStripMenuItem.Text = "&Clear String List";
            this.clearStringListToolStripMenuItem.ToolTipText = "Removes all strings from the list of picked up items";
            this.clearStringListToolStripMenuItem.Click += new System.EventHandler(this.clearStringListToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractAudioToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.resetRendererToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.moreToolStripMenuItem.Text = "&More";
            this.moreToolStripMenuItem.ToolTipText = "More actions, not necessary related to save files";
            // 
            // extractAudioToolStripMenuItem
            // 
            this.extractAudioToolStripMenuItem.Enabled = false;
            this.extractAudioToolStripMenuItem.Name = "extractAudioToolStripMenuItem";
            this.extractAudioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.extractAudioToolStripMenuItem.Text = "&Extract Audio";
            this.extractAudioToolStripMenuItem.ToolTipText = "Extract all WAV audio containers from the game";
            this.extractAudioToolStripMenuItem.Click += new System.EventHandler(this.extractAudioToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.ToolTipText = "Change application settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHelpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.ToolTipText = "Provides help and info utilities";
            // 
            // openHelpToolStripMenuItem
            // 
            this.openHelpToolStripMenuItem.Name = "openHelpToolStripMenuItem";
            this.openHelpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openHelpToolStripMenuItem.Text = "&Help";
            this.openHelpToolStripMenuItem.ToolTipText = "Shows the Help window";
            this.openHelpToolStripMenuItem.Click += new System.EventHandler(this.openHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Shows basic application information";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.changelogToolStripMenuItem.Text = "&Changelog";
            this.changelogToolStripMenuItem.ToolTipText = "Shows the changes in each version";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.websiteToolStripMenuItem.Text = "&Website";
            this.websiteToolStripMenuItem.ToolTipText = "Opens the satisfactory editor Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for &Updates";
            this.checkForUpdatesToolStripMenuItem.ToolTipText = "Manually checks for updates in the background";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // updateAvailableToolStripMenuItem
            // 
            this.updateAvailableToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.updateAvailableToolStripMenuItem.Name = "updateAvailableToolStripMenuItem";
            this.updateAvailableToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.updateAvailableToolStripMenuItem.Text = "&Update Available";
            this.updateAvailableToolStripMenuItem.ToolTipText = "Install an available update right now";
            this.updateAvailableToolStripMenuItem.Visible = false;
            this.updateAvailableToolStripMenuItem.Click += new System.EventHandler(this.updateAvailableToolStripMenuItem_Click);
            // 
            // OFD
            // 
            this.OFD.DefaultExt = "sav";
            this.OFD.Filter = "Save Files|*.sav|All Files|*.*";
            this.OFD.Title = "Select Save File";
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "sav";
            this.SFD.Filter = "Save Files|*.sav";
            this.SFD.Title = "Save Changes";
            // 
            // resetRendererToolStripMenuItem
            // 
            this.resetRendererToolStripMenuItem.Name = "resetRendererToolStripMenuItem";
            this.resetRendererToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetRendererToolStripMenuItem.Text = "&Reset Renderer";
            this.resetRendererToolStripMenuItem.Visible = false;
            this.resetRendererToolStripMenuItem.Click += new System.EventHandler(this.resetRendererToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(592, 573);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Satisfactory Save Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmMain_HelpRequested);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickActionsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ToolStripMenuItem mapFeaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreRocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restorePlantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreBerriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAnimalPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropPodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restorePickupsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.ToolStripMenuItem inventoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkTogetherToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.ToolStripMenuItem generalActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spawnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lizardDoggosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreSlugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeDoggosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redrawMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStringListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteElementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangeDeleterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetRendererToolStripMenuItem;
    }
}