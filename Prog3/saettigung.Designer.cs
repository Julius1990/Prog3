﻿namespace Prog3
{
    partial class saettigung
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
            this.centerPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.saettigungPicturebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saettigungLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.anwendenTrackBarButton = new System.Windows.Forms.Button();
            this.anwendenTextBox = new System.Windows.Forms.TextBox();
            this.saettTrackBar = new System.Windows.Forms.TrackBar();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.randObenPanel = new System.Windows.Forms.Panel();
            this.randLinksPanel = new System.Windows.Forms.Panel();
            this.randRechtsPanel = new System.Windows.Forms.Panel();
            this.randUntenPanel = new System.Windows.Forms.Panel();
            this.kontrastBerechnungBW = new System.ComponentModel.BackgroundWorker();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saettigungPicturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saettTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(697, 435);
            this.centerPanel.TabIndex = 19;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.saettigungPicturebox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(697, 435);
            this.splitContainer1.SplitterDistance = 501;
            this.splitContainer1.TabIndex = 0;
            // 
            // saettigungPicturebox
            // 
            this.saettigungPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saettigungPicturebox.Location = new System.Drawing.Point(0, 0);
            this.saettigungPicturebox.Name = "saettigungPicturebox";
            this.saettigungPicturebox.Size = new System.Drawing.Size(499, 433);
            this.saettigungPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saettigungPicturebox.TabIndex = 0;
            this.saettigungPicturebox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saettigungLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.abbrechenButton);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(190, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 433);
            this.panel1.TabIndex = 0;
            // 
            // saettigungLabel
            // 
            this.saettigungLabel.AutoSize = true;
            this.saettigungLabel.Location = new System.Drawing.Point(22, 10);
            this.saettigungLabel.Name = "saettigungLabel";
            this.saettigungLabel.Size = new System.Drawing.Size(52, 13);
            this.saettigungLabel.TabIndex = 13;
            this.saettigungLabel.Text = "Sättigung";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.anwendenTrackBarButton);
            this.panel2.Controls.Add(this.anwendenTextBox);
            this.panel2.Controls.Add(this.saettTrackBar);
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
            this.anwendenTextBox.MaxLength = 10000;
            this.anwendenTextBox.Name = "anwendenTextBox";
            this.anwendenTextBox.Size = new System.Drawing.Size(75, 20);
            this.anwendenTextBox.TabIndex = 11;
            this.anwendenTextBox.Text = "0";
            // 
            // saettTrackBar
            // 
            this.saettTrackBar.AutoSize = false;
            this.saettTrackBar.Location = new System.Drawing.Point(3, 13);
            this.saettTrackBar.Maximum = 100;
            this.saettTrackBar.Minimum = -10;
            this.saettTrackBar.Name = "saettTrackBar";
            this.saettTrackBar.Size = new System.Drawing.Size(167, 37);
            this.saettTrackBar.TabIndex = 11;
            this.saettTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.saettTrackBar.ValueChanged += new System.EventHandler(this.saettTrackBar_ValueChanged_1);
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
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(10, 0);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(697, 10);
            this.randObenPanel.TabIndex = 18;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(10, 445);
            this.randLinksPanel.TabIndex = 17;
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(707, 0);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(10, 445);
            this.randRechtsPanel.TabIndex = 16;
            // 
            // randUntenPanel
            // 
            this.randUntenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randUntenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randUntenPanel.Location = new System.Drawing.Point(0, 445);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(717, 10);
            this.randUntenPanel.TabIndex = 15;
            // 
            // kontrastBerechnungBW
            // 
            this.kontrastBerechnungBW.WorkerSupportsCancellation = true;
            // 
            // saettigung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 455);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.randObenPanel);
            this.Controls.Add(this.randLinksPanel);
            this.Controls.Add(this.randRechtsPanel);
            this.Controls.Add(this.randUntenPanel);
            this.Name = "saettigung";
            this.Text = "Sättigung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saettigung_FormClosing);
            this.centerPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saettigungPicturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saettTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox saettigungPicturebox;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label saettigungLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button anwendenTrackBarButton;
        private System.Windows.Forms.TextBox anwendenTextBox;
        private System.Windows.Forms.TrackBar saettTrackBar;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Panel randObenPanel;
        private System.Windows.Forms.Panel randLinksPanel;
        private System.Windows.Forms.Panel randRechtsPanel;
        private System.Windows.Forms.Panel randUntenPanel;
        private System.ComponentModel.BackgroundWorker kontrastBerechnungBW;
    }
}