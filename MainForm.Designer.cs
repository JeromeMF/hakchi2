﻿namespace com.clusterrr.hakchi_gui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoreGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashOriginalKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashCustomKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nESMiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famicomMiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useExtendedFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epilepsyProtectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemArmetLevel0 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemArmetLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemArmetLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cloverconHackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUsingCombinationOfButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectButtonCombinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeThumbnailsAtTheBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betterPNGCompressionlowerQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubPageWithActualReleasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxGames = new System.Windows.Forms.CheckedListBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxReleaseDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGameGenie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonTwoSim = new System.Windows.Forms.RadioButton();
            this.buttonGoogle = new System.Windows.Forms.Button();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArguments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddGames = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialogNes = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxDefaultGames = new System.Windows.Forms.GroupBox();
            this.checkedListBoxDefaultGames = new System.Windows.Forms.CheckedListBox();
            this.timerCalculateGames = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBoxDefaultGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.kernelToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMoreGamesToolStripMenuItem,
            this.presetsToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // addMoreGamesToolStripMenuItem
            // 
            resources.ApplyResources(this.addMoreGamesToolStripMenuItem, "addMoreGamesToolStripMenuItem");
            this.addMoreGamesToolStripMenuItem.Name = "addMoreGamesToolStripMenuItem";
            this.addMoreGamesToolStripMenuItem.Click += new System.EventHandler(this.buttonAddGames_Click);
            // 
            // presetsToolStripMenuItem
            // 
            resources.ApplyResources(this.presetsToolStripMenuItem, "presetsToolStripMenuItem");
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.addPresetToolStripMenuItem,
            this.deletePresetToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // addPresetToolStripMenuItem
            // 
            resources.ApplyResources(this.addPresetToolStripMenuItem, "addPresetToolStripMenuItem");
            this.addPresetToolStripMenuItem.Name = "addPresetToolStripMenuItem";
            this.addPresetToolStripMenuItem.Click += new System.EventHandler(this.AddPreset);
            // 
            // deletePresetToolStripMenuItem
            // 
            resources.ApplyResources(this.deletePresetToolStripMenuItem, "deletePresetToolStripMenuItem");
            this.deletePresetToolStripMenuItem.Name = "deletePresetToolStripMenuItem";
            // 
            // searchToolStripMenuItem
            // 
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kernelToolStripMenuItem
            // 
            resources.ApplyResources(this.kernelToolStripMenuItem, "kernelToolStripMenuItem");
            this.kernelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpKernelToolStripMenuItem,
            this.flashOriginalKernelToolStripMenuItem,
            this.flashCustomKernelToolStripMenuItem,
            this.uninstallToolStripMenuItem});
            this.kernelToolStripMenuItem.Name = "kernelToolStripMenuItem";
            // 
            // dumpKernelToolStripMenuItem
            // 
            resources.ApplyResources(this.dumpKernelToolStripMenuItem, "dumpKernelToolStripMenuItem");
            this.dumpKernelToolStripMenuItem.Name = "dumpKernelToolStripMenuItem";
            this.dumpKernelToolStripMenuItem.Click += new System.EventHandler(this.dumpKernelToolStripMenuItem_Click);
            // 
            // flashOriginalKernelToolStripMenuItem
            // 
            resources.ApplyResources(this.flashOriginalKernelToolStripMenuItem, "flashOriginalKernelToolStripMenuItem");
            this.flashOriginalKernelToolStripMenuItem.Name = "flashOriginalKernelToolStripMenuItem";
            this.flashOriginalKernelToolStripMenuItem.Click += new System.EventHandler(this.flashOriginalKernelToolStripMenuItem_Click);
            // 
            // flashCustomKernelToolStripMenuItem
            // 
            resources.ApplyResources(this.flashCustomKernelToolStripMenuItem, "flashCustomKernelToolStripMenuItem");
            this.flashCustomKernelToolStripMenuItem.Name = "flashCustomKernelToolStripMenuItem";
            this.flashCustomKernelToolStripMenuItem.Click += new System.EventHandler(this.flashCustomKernelToolStripMenuItem_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            resources.ApplyResources(this.uninstallToolStripMenuItem, "uninstallToolStripMenuItem");
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleTypeToolStripMenuItem,
            this.useExtendedFontToolStripMenuItem,
            this.epilepsyProtectionToolStripMenuItem,
            this.cloverconHackToolStripMenuItem,
            this.removeThumbnailsAtTheBottomToolStripMenuItem,
            this.betterPNGCompressionlowerQualityToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // consoleTypeToolStripMenuItem
            // 
            resources.ApplyResources(this.consoleTypeToolStripMenuItem, "consoleTypeToolStripMenuItem");
            this.consoleTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nESMiniToolStripMenuItem,
            this.famicomMiniToolStripMenuItem});
            this.consoleTypeToolStripMenuItem.Name = "consoleTypeToolStripMenuItem";
            // 
            // nESMiniToolStripMenuItem
            // 
            resources.ApplyResources(this.nESMiniToolStripMenuItem, "nESMiniToolStripMenuItem");
            this.nESMiniToolStripMenuItem.Checked = true;
            this.nESMiniToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nESMiniToolStripMenuItem.Name = "nESMiniToolStripMenuItem";
            this.nESMiniToolStripMenuItem.Click += new System.EventHandler(this.nESMiniToolStripMenuItem_Click);
            // 
            // famicomMiniToolStripMenuItem
            // 
            resources.ApplyResources(this.famicomMiniToolStripMenuItem, "famicomMiniToolStripMenuItem");
            this.famicomMiniToolStripMenuItem.Name = "famicomMiniToolStripMenuItem";
            this.famicomMiniToolStripMenuItem.Click += new System.EventHandler(this.famicomMiniToolStripMenuItem_Click);
            // 
            // useExtendedFontToolStripMenuItem
            // 
            resources.ApplyResources(this.useExtendedFontToolStripMenuItem, "useExtendedFontToolStripMenuItem");
            this.useExtendedFontToolStripMenuItem.Checked = true;
            this.useExtendedFontToolStripMenuItem.CheckOnClick = true;
            this.useExtendedFontToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useExtendedFontToolStripMenuItem.Name = "useExtendedFontToolStripMenuItem";
            this.useExtendedFontToolStripMenuItem.Click += new System.EventHandler(this.useExtendedFontToolStripMenuItem_Click);
            // 
            // epilepsyProtectionToolStripMenuItem
            // 
            resources.ApplyResources(this.epilepsyProtectionToolStripMenuItem, "epilepsyProtectionToolStripMenuItem");
            this.epilepsyProtectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemArmetLevel0,
            this.ToolStripMenuItemArmetLevel1,
            this.ToolStripMenuItemArmetLevel2});
            this.epilepsyProtectionToolStripMenuItem.Name = "epilepsyProtectionToolStripMenuItem";
            // 
            // ToolStripMenuItemArmetLevel0
            // 
            resources.ApplyResources(this.ToolStripMenuItemArmetLevel0, "ToolStripMenuItemArmetLevel0");
            this.ToolStripMenuItemArmetLevel0.Checked = true;
            this.ToolStripMenuItemArmetLevel0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemArmetLevel0.Name = "ToolStripMenuItemArmetLevel0";
            this.ToolStripMenuItemArmetLevel0.Click += new System.EventHandler(this.ToolStripMenuItemArmet_Click);
            // 
            // ToolStripMenuItemArmetLevel1
            // 
            resources.ApplyResources(this.ToolStripMenuItemArmetLevel1, "ToolStripMenuItemArmetLevel1");
            this.ToolStripMenuItemArmetLevel1.Name = "ToolStripMenuItemArmetLevel1";
            this.ToolStripMenuItemArmetLevel1.Click += new System.EventHandler(this.ToolStripMenuItemArmet_Click);
            // 
            // ToolStripMenuItemArmetLevel2
            // 
            resources.ApplyResources(this.ToolStripMenuItemArmetLevel2, "ToolStripMenuItemArmetLevel2");
            this.ToolStripMenuItemArmetLevel2.Name = "ToolStripMenuItemArmetLevel2";
            this.ToolStripMenuItemArmetLevel2.Click += new System.EventHandler(this.ToolStripMenuItemArmet_Click);
            // 
            // cloverconHackToolStripMenuItem
            // 
            resources.ApplyResources(this.cloverconHackToolStripMenuItem, "cloverconHackToolStripMenuItem");
            this.cloverconHackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetUsingCombinationOfButtonsToolStripMenuItem,
            this.selectButtonCombinationToolStripMenuItem});
            this.cloverconHackToolStripMenuItem.Name = "cloverconHackToolStripMenuItem";
            // 
            // resetUsingCombinationOfButtonsToolStripMenuItem
            // 
            resources.ApplyResources(this.resetUsingCombinationOfButtonsToolStripMenuItem, "resetUsingCombinationOfButtonsToolStripMenuItem");
            this.resetUsingCombinationOfButtonsToolStripMenuItem.Checked = true;
            this.resetUsingCombinationOfButtonsToolStripMenuItem.CheckOnClick = true;
            this.resetUsingCombinationOfButtonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resetUsingCombinationOfButtonsToolStripMenuItem.Name = "resetUsingCombinationOfButtonsToolStripMenuItem";
            this.resetUsingCombinationOfButtonsToolStripMenuItem.Click += new System.EventHandler(this.cloverconHackToolStripMenuItem_Click);
            // 
            // selectButtonCombinationToolStripMenuItem
            // 
            resources.ApplyResources(this.selectButtonCombinationToolStripMenuItem, "selectButtonCombinationToolStripMenuItem");
            this.selectButtonCombinationToolStripMenuItem.Name = "selectButtonCombinationToolStripMenuItem";
            this.selectButtonCombinationToolStripMenuItem.Click += new System.EventHandler(this.selectButtonCombinationToolStripMenuItem_Click);
            // 
            // removeThumbnailsAtTheBottomToolStripMenuItem
            // 
            resources.ApplyResources(this.removeThumbnailsAtTheBottomToolStripMenuItem, "removeThumbnailsAtTheBottomToolStripMenuItem");
            this.removeThumbnailsAtTheBottomToolStripMenuItem.CheckOnClick = true;
            this.removeThumbnailsAtTheBottomToolStripMenuItem.Name = "removeThumbnailsAtTheBottomToolStripMenuItem";
            this.removeThumbnailsAtTheBottomToolStripMenuItem.Click += new System.EventHandler(this.removeThumbnailsAtTheBottomToolStripMenuItem_Click);
            // 
            // betterPNGCompressionlowerQualityToolStripMenuItem
            // 
            resources.ApplyResources(this.betterPNGCompressionlowerQualityToolStripMenuItem, "betterPNGCompressionlowerQualityToolStripMenuItem");
            this.betterPNGCompressionlowerQualityToolStripMenuItem.Checked = true;
            this.betterPNGCompressionlowerQualityToolStripMenuItem.CheckOnClick = true;
            this.betterPNGCompressionlowerQualityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.betterPNGCompressionlowerQualityToolStripMenuItem.Name = "betterPNGCompressionlowerQualityToolStripMenuItem";
            this.betterPNGCompressionlowerQualityToolStripMenuItem.Click += new System.EventHandler(this.betterPNGCompressionlowerQualityToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubPageWithActualReleasesToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // gitHubPageWithActualReleasesToolStripMenuItem
            // 
            resources.ApplyResources(this.gitHubPageWithActualReleasesToolStripMenuItem, "gitHubPageWithActualReleasesToolStripMenuItem");
            this.gitHubPageWithActualReleasesToolStripMenuItem.Name = "gitHubPageWithActualReleasesToolStripMenuItem";
            this.gitHubPageWithActualReleasesToolStripMenuItem.Click += new System.EventHandler(this.gitHubPageWithActualReleasesToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            resources.ApplyResources(this.fAQToolStripMenuItem, "fAQToolStripMenuItem");
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkedListBoxGames
            // 
            resources.ApplyResources(this.checkedListBoxGames, "checkedListBoxGames");
            this.checkedListBoxGames.AllowDrop = true;
            this.checkedListBoxGames.FormattingEnabled = true;
            this.checkedListBoxGames.Name = "checkedListBoxGames";
            this.checkedListBoxGames.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxGames_ItemCheck);
            this.checkedListBoxGames.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxGames_SelectedIndexChanged);
            this.checkedListBoxGames.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkedListBoxGames_DragDrop);
            this.checkedListBoxGames.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkedListBoxGames_DragEnter);
            this.checkedListBoxGames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkedListBoxGames_KeyDown);
            this.checkedListBoxGames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxGames_MouseDown);
            // 
            // groupBoxOptions
            // 
            resources.ApplyResources(this.groupBoxOptions, "groupBoxOptions");
            this.groupBoxOptions.Controls.Add(this.maskedTextBoxReleaseDate);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.textBoxGameGenie);
            this.groupBoxOptions.Controls.Add(this.label7);
            this.groupBoxOptions.Controls.Add(this.label6);
            this.groupBoxOptions.Controls.Add(this.radioButtonTwoSim);
            this.groupBoxOptions.Controls.Add(this.buttonGoogle);
            this.groupBoxOptions.Controls.Add(this.buttonBrowseImage);
            this.groupBoxOptions.Controls.Add(this.pictureBoxArt);
            this.groupBoxOptions.Controls.Add(this.label4);
            this.groupBoxOptions.Controls.Add(this.textBoxArguments);
            this.groupBoxOptions.Controls.Add(this.label3);
            this.groupBoxOptions.Controls.Add(this.textBoxPublisher);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.radioButtonTwo);
            this.groupBoxOptions.Controls.Add(this.radioButtonOne);
            this.groupBoxOptions.Controls.Add(this.textBoxName);
            this.groupBoxOptions.Controls.Add(this.labelName);
            this.groupBoxOptions.Controls.Add(this.labelID);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.TabStop = false;
            // 
            // maskedTextBoxReleaseDate
            // 
            resources.ApplyResources(this.maskedTextBoxReleaseDate, "maskedTextBoxReleaseDate");
            this.maskedTextBoxReleaseDate.Name = "maskedTextBoxReleaseDate";
            this.maskedTextBoxReleaseDate.TextChanged += new System.EventHandler(this.maskedTextBoxReleaseDate_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxGameGenie
            // 
            resources.ApplyResources(this.textBoxGameGenie, "textBoxGameGenie");
            this.textBoxGameGenie.Name = "textBoxGameGenie";
            this.textBoxGameGenie.TextChanged += new System.EventHandler(this.textBoxGameGenie_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // radioButtonTwoSim
            // 
            resources.ApplyResources(this.radioButtonTwoSim, "radioButtonTwoSim");
            this.radioButtonTwoSim.Name = "radioButtonTwoSim";
            this.radioButtonTwoSim.UseVisualStyleBackColor = true;
            this.radioButtonTwoSim.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // buttonGoogle
            // 
            resources.ApplyResources(this.buttonGoogle, "buttonGoogle");
            this.buttonGoogle.Name = "buttonGoogle";
            this.buttonGoogle.UseVisualStyleBackColor = true;
            this.buttonGoogle.Click += new System.EventHandler(this.buttonGoogle_Click);
            // 
            // buttonBrowseImage
            // 
            resources.ApplyResources(this.buttonBrowseImage, "buttonBrowseImage");
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // pictureBoxArt
            // 
            resources.ApplyResources(this.pictureBoxArt, "pictureBoxArt");
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxArguments
            // 
            resources.ApplyResources(this.textBoxArguments, "textBoxArguments");
            this.textBoxArguments.Name = "textBoxArguments";
            this.textBoxArguments.TextChanged += new System.EventHandler(this.textBoxArguments_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxPublisher
            // 
            resources.ApplyResources(this.textBoxPublisher, "textBoxPublisher");
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.TextChanged += new System.EventHandler(this.textBoxPublisher_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // radioButtonTwo
            // 
            resources.ApplyResources(this.radioButtonTwo, "radioButtonTwo");
            this.radioButtonTwo.Name = "radioButtonTwo";
            this.radioButtonTwo.UseVisualStyleBackColor = true;
            this.radioButtonTwo.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // radioButtonOne
            // 
            resources.ApplyResources(this.radioButtonOne, "radioButtonOne");
            this.radioButtonOne.Checked = true;
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.UseVisualStyleBackColor = true;
            this.radioButtonOne.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.Name = "labelID";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // buttonAddGames
            // 
            resources.ApplyResources(this.buttonAddGames, "buttonAddGames");
            this.buttonAddGames.Name = "buttonAddGames";
            this.buttonAddGames.UseVisualStyleBackColor = true;
            this.buttonAddGames.Click += new System.EventHandler(this.buttonAddGames_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSelected});
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // toolStripStatusLabelSelected
            // 
            resources.ApplyResources(this.toolStripStatusLabelSelected, "toolStripStatusLabelSelected");
            this.toolStripStatusLabelSelected.Name = "toolStripStatusLabelSelected";
            // 
            // openFileDialogNes
            // 
            this.openFileDialogNes.DefaultExt = "nes";
            resources.ApplyResources(this.openFileDialogNes, "openFileDialogNes");
            this.openFileDialogNes.Multiselect = true;
            // 
            // contextMenuStrip
            // 
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.unselectAllToolStripMenuItem,
            this.deleteGameToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            // 
            // selectAllToolStripMenuItem
            // 
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // unselectAllToolStripMenuItem
            // 
            resources.ApplyResources(this.unselectAllToolStripMenuItem, "unselectAllToolStripMenuItem");
            this.unselectAllToolStripMenuItem.Name = "unselectAllToolStripMenuItem";
            this.unselectAllToolStripMenuItem.Click += new System.EventHandler(this.unselectAllToolStripMenuItem_Click);
            // 
            // deleteGameToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteGameToolStripMenuItem, "deleteGameToolStripMenuItem");
            this.deleteGameToolStripMenuItem.Name = "deleteGameToolStripMenuItem";
            this.deleteGameToolStripMenuItem.Click += new System.EventHandler(this.deleteGameToolStripMenuItem_Click);
            // 
            // openFileDialogImage
            // 
            resources.ApplyResources(this.openFileDialogImage, "openFileDialogImage");
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxDefaultGames
            // 
            resources.ApplyResources(this.groupBoxDefaultGames, "groupBoxDefaultGames");
            this.groupBoxDefaultGames.Controls.Add(this.checkedListBoxDefaultGames);
            this.groupBoxDefaultGames.Name = "groupBoxDefaultGames";
            this.groupBoxDefaultGames.TabStop = false;
            // 
            // checkedListBoxDefaultGames
            // 
            resources.ApplyResources(this.checkedListBoxDefaultGames, "checkedListBoxDefaultGames");
            this.checkedListBoxDefaultGames.FormattingEnabled = true;
            this.checkedListBoxDefaultGames.Name = "checkedListBoxDefaultGames";
            this.checkedListBoxDefaultGames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxDefaultGames_MouseDown);
            // 
            // timerCalculateGames
            // 
            this.timerCalculateGames.Enabled = true;
            this.timerCalculateGames.Interval = 500;
            this.timerCalculateGames.Tick += new System.EventHandler(this.timerCalculateGames_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonAddGames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBoxGames);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxDefaultGames);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBoxDefaultGames.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoreGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioButtonTwo;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxReleaseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArguments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGoogle;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddGames;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelected;
        private System.Windows.Forms.OpenFileDialog openFileDialogNes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteGameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolStripMenuItem kernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpKernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashCustomKernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashOriginalKernelToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonTwoSim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useExtendedFontToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDefaultGames;
        private System.Windows.Forms.CheckedListBox checkedListBoxDefaultGames;
        private System.Windows.Forms.Timer timerCalculateGames;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubPageWithActualReleasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        protected internal System.Windows.Forms.CheckedListBox checkedListBoxGames;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxGameGenie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem epilepsyProtectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemArmetLevel0;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemArmetLevel1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemArmetLevel2;
        private System.Windows.Forms.ToolStripMenuItem cloverconHackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeThumbnailsAtTheBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betterPNGCompressionlowerQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUsingCombinationOfButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectButtonCombinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nESMiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famicomMiniToolStripMenuItem;
    }
}

