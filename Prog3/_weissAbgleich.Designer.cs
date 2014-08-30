namespace Prog3
{
    partial class _weissAbgleich
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
            this.weissabgleichPicturebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weissabgleichLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAnwenden = new System.Windows.Forms.Button();
            this.textBoxWert = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.weissabgleichTrackBar = new System.Windows.Forms.TrackBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.weissabgleichPicturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weissabgleichTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(724, 412);
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
            this.splitContainer1.Panel1.Controls.Add(this.weissabgleichPicturebox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(724, 412);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.TabIndex = 0;
            // 
            // weissabgleichPicturebox
            // 
            this.weissabgleichPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weissabgleichPicturebox.Location = new System.Drawing.Point(0, 0);
            this.weissabgleichPicturebox.Name = "weissabgleichPicturebox";
            this.weissabgleichPicturebox.Size = new System.Drawing.Size(526, 410);
            this.weissabgleichPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weissabgleichPicturebox.TabIndex = 0;
            this.weissabgleichPicturebox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.weissabgleichLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.abbrechenButton);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 410);
            this.panel1.TabIndex = 0;
            // 
            // weissabgleichLabel
            // 
            this.weissabgleichLabel.AutoSize = true;
            this.weissabgleichLabel.Location = new System.Drawing.Point(22, 10);
            this.weissabgleichLabel.Name = "weissabgleichLabel";
            this.weissabgleichLabel.Size = new System.Drawing.Size(72, 13);
            this.weissabgleichLabel.TabIndex = 13;
            this.weissabgleichLabel.Text = "Weißabgleich";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonAnwenden);
            this.panel2.Controls.Add(this.textBoxWert);
            this.panel2.Controls.Add(this.labelMax);
            this.panel2.Controls.Add(this.labelMin);
            this.panel2.Controls.Add(this.weissabgleichTrackBar);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 99);
            this.panel2.TabIndex = 14;
            // 
            // buttonAnwenden
            // 
            this.buttonAnwenden.Location = new System.Drawing.Point(95, 65);
            this.buttonAnwenden.Name = "buttonAnwenden";
            this.buttonAnwenden.Size = new System.Drawing.Size(75, 23);
            this.buttonAnwenden.TabIndex = 17;
            this.buttonAnwenden.Text = "Anwenden";
            this.buttonAnwenden.UseVisualStyleBackColor = true;
            this.buttonAnwenden.Click += new System.EventHandler(this.buttonAnwenden_Click);
            // 
            // textBoxWert
            // 
            this.textBoxWert.Location = new System.Drawing.Point(14, 67);
            this.textBoxWert.Name = "textBoxWert";
            this.textBoxWert.Size = new System.Drawing.Size(72, 20);
            this.textBoxWert.TabIndex = 15;
            this.textBoxWert.Text = "0";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(145, 37);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(25, 13);
            this.labelMax.TabIndex = 16;
            this.labelMax.Text = "255";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(11, 37);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(28, 13);
            this.labelMin.TabIndex = 15;
            this.labelMin.Text = "-255";
            // 
            // weissabgleichTrackBar
            // 
            this.weissabgleichTrackBar.AutoSize = false;
            this.weissabgleichTrackBar.Location = new System.Drawing.Point(3, 13);
            this.weissabgleichTrackBar.Maximum = 510;
            this.weissabgleichTrackBar.Name = "weissabgleichTrackBar";
            this.weissabgleichTrackBar.Size = new System.Drawing.Size(167, 37);
            this.weissabgleichTrackBar.TabIndex = 7;
            this.weissabgleichTrackBar.TickFrequency = 10;
            this.weissabgleichTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.weissabgleichTrackBar.Value = 255;
            this.weissabgleichTrackBar.ValueChanged += new System.EventHandler(this.weissabgleich_ValueChanged);
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.Location = new System.Drawing.Point(6, 375);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.abbrechenButton.TabIndex = 9;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            this.abbrechenButton.Click += new System.EventHandler(this.abbrechenButton_Click_1);
            // 
            // speichernButton
            // 
            this.speichernButton.Location = new System.Drawing.Point(108, 375);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(75, 23);
            this.speichernButton.TabIndex = 8;
            this.speichernButton.Text = "Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click_1);
            // 
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(10, 0);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(724, 10);
            this.randObenPanel.TabIndex = 18;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(10, 422);
            this.randLinksPanel.TabIndex = 17;
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(734, 0);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(10, 422);
            this.randRechtsPanel.TabIndex = 16;
            // 
            // randUntenPanel
            // 
            this.randUntenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randUntenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randUntenPanel.Location = new System.Drawing.Point(0, 422);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(744, 10);
            this.randUntenPanel.TabIndex = 15;
            // 
            // kontrastBerechnungBW
            // 
            this.kontrastBerechnungBW.WorkerSupportsCancellation = true;
            // 
            // _weissAbgleich
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
            this.Name = "_weissAbgleich";
            this.Text = "Weißabgleich";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._weissAbgleich_FormClosing);
            this.centerPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weissabgleichPicturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weissabgleichTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox weissabgleichPicturebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label weissabgleichLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar weissabgleichTrackBar;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Panel randObenPanel;
        private System.Windows.Forms.Panel randLinksPanel;
        private System.Windows.Forms.Panel randRechtsPanel;
        private System.Windows.Forms.Panel randUntenPanel;
        private System.ComponentModel.BackgroundWorker kontrastBerechnungBW;
        private System.Windows.Forms.Button buttonAnwenden;
        private System.Windows.Forms.TextBox textBoxWert;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
    }
}