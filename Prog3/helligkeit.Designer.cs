namespace Prog3
{
    partial class helligkeit
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
            this.helligkeitPicturebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helligkeitLabel = new System.Windows.Forms.Label();
            this.helligkeitPanel = new System.Windows.Forms.Panel();
            this.anwendenTrackBarButton = new System.Windows.Forms.Button();
            this.anwendenTextBox = new System.Windows.Forms.TextBox();
            this.helligkeitTrackBar = new System.Windows.Forms.TrackBar();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.randObenPanel = new System.Windows.Forms.Panel();
            this.randLinksPanel = new System.Windows.Forms.Panel();
            this.randRechtsPanel = new System.Windows.Forms.Panel();
            this.randUntenPanel = new System.Windows.Forms.Panel();
            this.helligkeitBerechnungBW = new System.ComponentModel.BackgroundWorker();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helligkeitPicturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.helligkeitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helligkeitTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(716, 408);
            this.centerPanel.TabIndex = 19;
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
            this.splitContainer1.Panel1.Controls.Add(this.helligkeitPicturebox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(716, 408);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 0;
            // 
            // helligkeitPicturebox
            // 
            this.helligkeitPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helligkeitPicturebox.Location = new System.Drawing.Point(0, 0);
            this.helligkeitPicturebox.Name = "helligkeitPicturebox";
            this.helligkeitPicturebox.Size = new System.Drawing.Size(520, 406);
            this.helligkeitPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helligkeitPicturebox.TabIndex = 0;
            this.helligkeitPicturebox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helligkeitLabel);
            this.panel1.Controls.Add(this.helligkeitPanel);
            this.panel1.Controls.Add(this.abbrechenButton);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 406);
            this.panel1.TabIndex = 0;
            // 
            // helligkeitLabel
            // 
            this.helligkeitLabel.AutoSize = true;
            this.helligkeitLabel.Location = new System.Drawing.Point(22, 10);
            this.helligkeitLabel.Name = "helligkeitLabel";
            this.helligkeitLabel.Size = new System.Drawing.Size(50, 13);
            this.helligkeitLabel.TabIndex = 13;
            this.helligkeitLabel.Text = "Helligkeit";
            // 
            // helligkeitPanel
            // 
            this.helligkeitPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helligkeitPanel.Controls.Add(this.anwendenTrackBarButton);
            this.helligkeitPanel.Controls.Add(this.anwendenTextBox);
            this.helligkeitPanel.Controls.Add(this.helligkeitTrackBar);
            this.helligkeitPanel.Location = new System.Drawing.Point(6, 20);
            this.helligkeitPanel.Name = "helligkeitPanel";
            this.helligkeitPanel.Size = new System.Drawing.Size(177, 67);
            this.helligkeitPanel.TabIndex = 14;
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
            // helligkeitTrackBar
            // 
            this.helligkeitTrackBar.AutoSize = false;
            this.helligkeitTrackBar.Location = new System.Drawing.Point(3, 13);
            this.helligkeitTrackBar.Maximum = 100;
            this.helligkeitTrackBar.Minimum = -100;
            this.helligkeitTrackBar.Name = "helligkeitTrackBar";
            this.helligkeitTrackBar.Size = new System.Drawing.Size(167, 37);
            this.helligkeitTrackBar.TabIndex = 7;
            this.helligkeitTrackBar.TickFrequency = 5;
            this.helligkeitTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.helligkeitTrackBar.ValueChanged += new System.EventHandler(this.helligkeitTrackBar_ValueChanged);
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
            this.randObenPanel.Size = new System.Drawing.Size(716, 10);
            this.randObenPanel.TabIndex = 18;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(10, 418);
            this.randLinksPanel.TabIndex = 17;
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(726, 0);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(10, 418);
            this.randRechtsPanel.TabIndex = 16;
            // 
            // randUntenPanel
            // 
            this.randUntenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randUntenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randUntenPanel.Location = new System.Drawing.Point(0, 418);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(736, 10);
            this.randUntenPanel.TabIndex = 15;
            // 
            // helligkeitBerechnungBW
            // 
            this.helligkeitBerechnungBW.WorkerSupportsCancellation = true;
            this.helligkeitBerechnungBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.helligkeitBerechnungBW_DoWork);
            this.helligkeitBerechnungBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.helligkeitBerechnungBW_RunWorkerCompleted);
            // 
            // helligkeit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 428);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.randObenPanel);
            this.Controls.Add(this.randLinksPanel);
            this.Controls.Add(this.randRechtsPanel);
            this.Controls.Add(this.randUntenPanel);
            this.Name = "helligkeit";
            this.Text = "Helligkeit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.helligkeit_FormClosing);
            this.centerPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.helligkeitPicturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.helligkeitPanel.ResumeLayout(false);
            this.helligkeitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helligkeitTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox helligkeitPicturebox;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label helligkeitLabel;
        private System.Windows.Forms.Panel helligkeitPanel;
        private System.Windows.Forms.Button anwendenTrackBarButton;
        private System.Windows.Forms.TextBox anwendenTextBox;
        private System.Windows.Forms.TrackBar helligkeitTrackBar;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Panel randObenPanel;
        private System.Windows.Forms.Panel randLinksPanel;
        private System.Windows.Forms.Panel randRechtsPanel;
        private System.Windows.Forms.Panel randUntenPanel;
        private System.ComponentModel.BackgroundWorker helligkeitBerechnungBW;
    }
}