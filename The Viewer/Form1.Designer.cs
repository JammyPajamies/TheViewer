﻿namespace The_Viewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainViewerPanel = new System.Windows.Forms.Panel();
            this.pictureBoxTwo = new System.Windows.Forms.PictureBox();
            this.pictureBoxOne = new System.Windows.Forms.PictureBox();
            this.garbageTimer = new System.Timers.Timer();
            this.autoplayTimer = new System.Timers.Timer();
            this.repeatInputTimer = new System.Timers.Timer();
            this.selectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.browseForWorkingDirButton = new System.Windows.Forms.Button();
            this.timerSelectionBox = new System.Windows.Forms.ComboBox();
            this.timerToggleButton = new System.Windows.Forms.Button();
            this.workingPathDisplay = new System.Windows.Forms.Label();
            this.nextPictureButton = new System.Windows.Forms.Button();
            this.previousPictureButton = new System.Windows.Forms.Button();
            this.viewerControlsPanel = new System.Windows.Forms.Panel();
            this.randomOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.mainViewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garbageTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoplayTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatInputTimer)).BeginInit();
            this.viewerControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainViewerPanel
            // 
            this.mainViewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainViewerPanel.AutoScroll = true;
            this.mainViewerPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainViewerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainViewerPanel.Controls.Add(this.pictureBoxTwo);
            this.mainViewerPanel.Controls.Add(this.pictureBoxOne);
            this.mainViewerPanel.Location = new System.Drawing.Point(0, 0);
            this.mainViewerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainViewerPanel.Name = "mainViewerPanel";
            this.mainViewerPanel.Size = new System.Drawing.Size(1920, 1056);
            this.mainViewerPanel.TabIndex = 0;
            // 
            // pictureBoxTwo
            // 
            this.pictureBoxTwo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTwo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTwo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTwo.Name = "pictureBoxTwo";
            this.pictureBoxTwo.Size = new System.Drawing.Size(1920, 1056);
            this.pictureBoxTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTwo.TabIndex = 1;
            this.pictureBoxTwo.TabStop = false;
            this.pictureBoxTwo.Visible = false;
            this.pictureBoxTwo.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBoxTwo_LoadCompleted);
            this.pictureBoxTwo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainViewerBox_MouseClick);
            // 
            // pictureBoxOne
            // 
            this.pictureBoxOne.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOne.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOne.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxOne.Name = "pictureBoxOne";
            this.pictureBoxOne.Size = new System.Drawing.Size(1920, 1056);
            this.pictureBoxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOne.TabIndex = 0;
            this.pictureBoxOne.TabStop = false;
            this.pictureBoxOne.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBoxOne_LoadCompleted);
            this.pictureBoxOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainViewerBox_MouseClick);
            // 
            // garbageTimer
            // 
            this.garbageTimer.Enabled = true;
            this.garbageTimer.Interval = 10000D;
            this.garbageTimer.SynchronizingObject = this;
            this.garbageTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.garbageTimer_Elapsed);
            // 
            // autoplayTimer
            // 
            this.autoplayTimer.Interval = 3000D;
            this.autoplayTimer.SynchronizingObject = this;
            this.autoplayTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.autoplayTimer_Elapsed);
            // 
            // repeatInputTimer
            // 
            this.repeatInputTimer.Enabled = true;
            this.repeatInputTimer.Interval = 250D;
            this.repeatInputTimer.SynchronizingObject = this;
            this.repeatInputTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.repeatInputTimer_Elapsed);
            // 
            // selectFolderDialog
            // 
            this.selectFolderDialog.Description = "Select New Directory";
            this.selectFolderDialog.SelectedPath = "P:\\df";
            // 
            // browseForWorkingDirButton
            // 
            this.browseForWorkingDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.browseForWorkingDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseForWorkingDirButton.ForeColor = System.Drawing.Color.White;
            this.browseForWorkingDirButton.Location = new System.Drawing.Point(702, 1);
            this.browseForWorkingDirButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.browseForWorkingDirButton.Name = "browseForWorkingDirButton";
            this.browseForWorkingDirButton.Size = new System.Drawing.Size(75, 23);
            this.browseForWorkingDirButton.TabIndex = 4;
            this.browseForWorkingDirButton.TabStop = false;
            this.browseForWorkingDirButton.Text = "Browse...";
            this.browseForWorkingDirButton.UseVisualStyleBackColor = true;
            this.browseForWorkingDirButton.Click += new System.EventHandler(this.browseForWorkingDirButton_Click);
            // 
            // timerSelectionBox
            // 
            this.timerSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timerSelectionBox.BackColor = System.Drawing.Color.Black;
            this.timerSelectionBox.DropDownWidth = 150;
            this.timerSelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.timerSelectionBox.ForeColor = System.Drawing.Color.White;
            this.timerSelectionBox.FormattingEnabled = true;
            this.timerSelectionBox.Items.AddRange(new object[] {
            "1 Seconds",
            "2 Seconds",
            "3 Seconds  (Default) ",
            "5 Seconds",
            "10 Seconds",
            "15 Seconds",
            "20 Seconds",
            "25 Seconds",
            "30 Seconds",
            "40 Seconds",
            "50 Seconds",
            "60 Seconds"});
            this.timerSelectionBox.Location = new System.Drawing.Point(462, 2);
            this.timerSelectionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.timerSelectionBox.Name = "timerSelectionBox";
            this.timerSelectionBox.Size = new System.Drawing.Size(150, 21);
            this.timerSelectionBox.TabIndex = 2;
            this.timerSelectionBox.TabStop = false;
            this.timerSelectionBox.SelectionChangeCommitted += new System.EventHandler(this.timerSelectionBox_SelectionChangeCommitted);
            // 
            // timerToggleButton
            // 
            this.timerToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timerToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerToggleButton.ForeColor = System.Drawing.Color.White;
            this.timerToggleButton.Location = new System.Drawing.Point(308, 1);
            this.timerToggleButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerToggleButton.Name = "timerToggleButton";
            this.timerToggleButton.Size = new System.Drawing.Size(150, 23);
            this.timerToggleButton.TabIndex = 1;
            this.timerToggleButton.TabStop = false;
            this.timerToggleButton.Text = "Timer: Off";
            this.timerToggleButton.UseVisualStyleBackColor = true;
            this.timerToggleButton.Click += new System.EventHandler(this.timerToggleButton_Click);
            // 
            // workingPathDisplay
            // 
            this.workingPathDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.workingPathDisplay.AutoEllipsis = true;
            this.workingPathDisplay.AutoSize = true;
            this.workingPathDisplay.ForeColor = System.Drawing.Color.White;
            this.workingPathDisplay.Location = new System.Drawing.Point(782, 6);
            this.workingPathDisplay.MaximumSize = new System.Drawing.Size(1205, 13);
            this.workingPathDisplay.MinimumSize = new System.Drawing.Size(250, 13);
            this.workingPathDisplay.Name = "workingPathDisplay";
            this.workingPathDisplay.Size = new System.Drawing.Size(250, 13);
            this.workingPathDisplay.TabIndex = 6;
            this.workingPathDisplay.Text = "\r\ncurrent Image Path";
            this.workingPathDisplay.UseMnemonic = false;
            // 
            // nextPictureButton
            // 
            this.nextPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPictureButton.ForeColor = System.Drawing.Color.White;
            this.nextPictureButton.Location = new System.Drawing.Point(154, 1);
            this.nextPictureButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nextPictureButton.Name = "nextPictureButton";
            this.nextPictureButton.Size = new System.Drawing.Size(150, 23);
            this.nextPictureButton.TabIndex = 0;
            this.nextPictureButton.TabStop = false;
            this.nextPictureButton.Text = "Next";
            this.nextPictureButton.UseVisualStyleBackColor = true;
            this.nextPictureButton.Click += new System.EventHandler(this.nextPictureButton_Click);
            // 
            // previousPictureButton
            // 
            this.previousPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPictureButton.ForeColor = System.Drawing.Color.White;
            this.previousPictureButton.Location = new System.Drawing.Point(0, 1);
            this.previousPictureButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previousPictureButton.Name = "previousPictureButton";
            this.previousPictureButton.Size = new System.Drawing.Size(150, 23);
            this.previousPictureButton.TabIndex = 5;
            this.previousPictureButton.TabStop = false;
            this.previousPictureButton.Text = "Previous";
            this.previousPictureButton.UseVisualStyleBackColor = true;
            this.previousPictureButton.Click += new System.EventHandler(this.previousPictureButton_Click);
            // 
            // viewerControlsPanel
            // 
            this.viewerControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerControlsPanel.BackColor = System.Drawing.Color.Black;
            this.viewerControlsPanel.Controls.Add(this.randomOrderCheckBox);
            this.viewerControlsPanel.Controls.Add(this.previousPictureButton);
            this.viewerControlsPanel.Controls.Add(this.nextPictureButton);
            this.viewerControlsPanel.Controls.Add(this.workingPathDisplay);
            this.viewerControlsPanel.Controls.Add(this.timerToggleButton);
            this.viewerControlsPanel.Controls.Add(this.timerSelectionBox);
            this.viewerControlsPanel.Controls.Add(this.browseForWorkingDirButton);
            this.viewerControlsPanel.Location = new System.Drawing.Point(0, 1056);
            this.viewerControlsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewerControlsPanel.Name = "viewerControlsPanel";
            this.viewerControlsPanel.Size = new System.Drawing.Size(1920, 24);
            this.viewerControlsPanel.TabIndex = 7;
            // 
            // randomOrderCheckBox
            // 
            this.randomOrderCheckBox.AutoSize = true;
            this.randomOrderCheckBox.ForeColor = System.Drawing.Color.White;
            this.randomOrderCheckBox.Location = new System.Drawing.Point(618, 4);
            this.randomOrderCheckBox.Name = "randomOrderCheckBox";
            this.randomOrderCheckBox.Size = new System.Drawing.Size(79, 17);
            this.randomOrderCheckBox.TabIndex = 7;
            this.randomOrderCheckBox.TabStop = false;
            this.randomOrderCheckBox.Text = "Randomize";
            this.randomOrderCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.randomOrderCheckBox.UseVisualStyleBackColor = true;
            this.randomOrderCheckBox.CheckedChanged += new System.EventHandler(this.randomOrderCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.viewerControlsPanel);
            this.Controls.Add(this.mainViewerPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "The View";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);
            this.mainViewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garbageTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoplayTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatInputTimer)).EndInit();
            this.viewerControlsPanel.ResumeLayout(false);
            this.viewerControlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainViewerPanel;
        private System.Windows.Forms.PictureBox pictureBoxOne;
        private System.Windows.Forms.PictureBox pictureBoxTwo;
        private System.Timers.Timer garbageTimer;
        private System.Timers.Timer autoplayTimer;
        private System.Timers.Timer repeatInputTimer;
        private System.Windows.Forms.FolderBrowserDialog selectFolderDialog;
        private System.Windows.Forms.Button previousPictureButton;
        private System.Windows.Forms.Button nextPictureButton;
        private System.Windows.Forms.Label workingPathDisplay;
        private System.Windows.Forms.Button timerToggleButton;
        private System.Windows.Forms.ComboBox timerSelectionBox;
        private System.Windows.Forms.Button browseForWorkingDirButton;
        private System.Windows.Forms.Panel viewerControlsPanel;
        private System.Windows.Forms.CheckBox randomOrderCheckBox;
    }
}

