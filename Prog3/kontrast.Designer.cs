﻿namespace Prog3
{
    partial class kontrast
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
            this.randObenPanel = new System.Windows.Forms.Panel();
            this.randLinksPanel = new System.Windows.Forms.Panel();
            this.randRechtsPanel = new System.Windows.Forms.Panel();
            this.randUntenPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.kontrastPicturebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kontrastLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.anwendenTrackBarButton = new System.Windows.Forms.Button();
            this.anwendenTextBox = new System.Windows.Forms.TextBox();
            this.kontrastTrackBar = new System.Windows.Forms.TrackBar();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.kontrastBerechnungBW = new System.ComponentModel.BackgroundWorker();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrastPicturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(10, 0);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(724, 10);
            this.randObenPanel.TabIndex = 13;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(10, 422);
            this.randLinksPanel.TabIndex = 12;
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(734, 0);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(10, 422);
            this.randRechtsPanel.TabIndex = 11;
            // 
            // randUntenPanel
            // 
            this.randUntenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randUntenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randUntenPanel.Location = new System.Drawing.Point(0, 422);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(744, 10);
            this.randUntenPanel.TabIndex = 10;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(724, 412);
            this.centerPanel.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.kontrastPicturebox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(724, 412);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.TabIndex = 0;
            // 
            // kontrastPicturebox
            // 
            this.kontrastPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kontrastPicturebox.Location = new System.Drawing.Point(0, 0);
            this.kontrastPicturebox.Name = "kontrastPicturebox";
            this.kontrastPicturebox.Size = new System.Drawing.Size(526, 410);
            this.kontrastPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kontrastPicturebox.TabIndex = 0;
            this.kontrastPicturebox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kontrastLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.abbrechenButton);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 410);
            this.panel1.TabIndex = 0;
            // 
            // kontrastLabel
            // 
            this.kontrastLabel.AutoSize = true;
            this.kontrastLabel.Location = new System.Drawing.Point(22, 10);
            this.kontrastLabel.Name = "kontrastLabel";
            this.kontrastLabel.Size = new System.Drawing.Size(46, 13);
            this.kontrastLabel.TabIndex = 13;
            this.kontrastLabel.Text = "Kontrast";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.anwendenTrackBarButton);
            this.panel2.Controls.Add(this.anwendenTextBox);
            this.panel2.Controls.Add(this.kontrastTrackBar);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 67);
            this.panel2.TabIndex = 14;
            // 
            // anwendenTrackBarButton
            // 
            this.anwendenTrackBarButton.Location = new System.Drawing.Point(95, 37);
            this.anwendenTrackBarButton.Name = "anwendenTrackBarButton";
            this.anwendenTrackBarButton.Size = new System.Drawing.Size(75, 23);
            this.anwendenTrackBarButton.TabIndex = 8;
            this.anwendenTrackBarButton.Text = "Anwenden";
            this.anwendenTrackBarButton.UseVisualStyleBackColor = true;
            this.anwendenTrackBarButton.Click += new System.EventHandler(this.anwendenTrackBarButton_Click);
            // 
            // anwendenTextBox
            // 
            this.anwendenTextBox.Location = new System.Drawing.Point(14, 39);
            this.anwendenTextBox.Name = "anwendenTextBox";
            this.anwendenTextBox.Size = new System.Drawing.Size(75, 20);
            this.anwendenTextBox.TabIndex = 11;
            this.anwendenTextBox.Text = "0";
            // 
            // kontrastTrackBar
            // 
            this.kontrastTrackBar.AutoSize = false;
            this.kontrastTrackBar.Location = new System.Drawing.Point(3, 13);
            this.kontrastTrackBar.Maximum = 100;
            this.kontrastTrackBar.Minimum = -100;
            this.kontrastTrackBar.Name = "kontrastTrackBar";
            this.kontrastTrackBar.Size = new System.Drawing.Size(167, 37);
            this.kontrastTrackBar.TabIndex = 7;
            this.kontrastTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kontrastTrackBar.ValueChanged += new System.EventHandler(this.kontrastTrackBar_ValueChanged);
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.Location = new System.Drawing.Point(6, 375);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.abbrechenButton.TabIndex = 9;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            this.abbrechenButton.Click += new System.EventHandler(this.abbrechenButton_Click);
            // 
            // speichernButton
            // 
            this.speichernButton.Location = new System.Drawing.Point(108, 375);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(75, 23);
            this.speichernButton.TabIndex = 8;
            this.speichernButton.Text = "Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // kontrastBerechnungBW
            // 
            this.kontrastBerechnungBW.WorkerSupportsCancellation = true;
            this.kontrastBerechnungBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.kontrastBerechnungBW_DoWork);
            this.kontrastBerechnungBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.kontrastBerechnungBW_RunWorkerCompleted);
            // 
            // kontrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 432);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.randObenPanel);
            this.Controls.Add(this.randLinksPanel);
            this.Controls.Add(this.randRechtsPanel);
            this.Controls.Add(this.randUntenPanel);
            this.MinimumSize = new System.Drawing.Size(760, 471);
            this.Name = "kontrast";
            this.Text = "Kontrast";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kontrast_FormClosing);
            this.centerPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kontrastPicturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrastTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel randObenPanel;
        private System.Windows.Forms.Panel randLinksPanel;
        private System.Windows.Forms.Panel randRechtsPanel;
        private System.Windows.Forms.Panel randUntenPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox kontrastPicturebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kontrastLabel;
        private System.Windows.Forms.TextBox anwendenTextBox;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.TrackBar kontrastTrackBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button anwendenTrackBarButton;
        private System.ComponentModel.BackgroundWorker kontrastBerechnungBW;
    }
}