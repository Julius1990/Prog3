namespace Prog3
{
    partial class grauwert
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
            this.grauwertProgressBar = new System.Windows.Forms.ProgressBar();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grauwertPicturebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.randObenPanel = new System.Windows.Forms.Panel();
            this.randLinksPanel = new System.Windows.Forms.Panel();
            this.randRechtsPanel = new System.Windows.Forms.Panel();
            this.randUntenPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grauwertPicturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grauwertProgressBar
            // 
            this.grauwertProgressBar.Location = new System.Drawing.Point(6, 346);
            this.grauwertProgressBar.Name = "grauwertProgressBar";
            this.grauwertProgressBar.Size = new System.Drawing.Size(177, 23);
            this.grauwertProgressBar.TabIndex = 10;
            this.grauwertProgressBar.Visible = false;
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.Location = new System.Drawing.Point(6, 375);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.abbrechenButton.TabIndex = 9;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            // 
            // speichernButton
            // 
            this.speichernButton.Location = new System.Drawing.Point(108, 375);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(75, 23);
            this.speichernButton.TabIndex = 8;
            this.speichernButton.Text = "Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.grauwertPicturebox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(743, 412);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.TabIndex = 0;
            // 
            // grauwertPicturebox
            // 
            this.grauwertPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grauwertPicturebox.Location = new System.Drawing.Point(0, 0);
            this.grauwertPicturebox.Name = "grauwertPicturebox";
            this.grauwertPicturebox.Size = new System.Drawing.Size(539, 410);
            this.grauwertPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grauwertPicturebox.TabIndex = 0;
            this.grauwertPicturebox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grauwertProgressBar);
            this.panel1.Controls.Add(this.abbrechenButton);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 410);
            this.panel1.TabIndex = 0;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(743, 412);
            this.centerPanel.TabIndex = 19;
            // 
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(10, 0);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(743, 10);
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
            this.randRechtsPanel.Location = new System.Drawing.Point(753, 0);
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
            this.randUntenPanel.Size = new System.Drawing.Size(763, 10);
            this.randUntenPanel.TabIndex = 15;
            // 
            // grauwert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 432);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.randObenPanel);
            this.Controls.Add(this.randLinksPanel);
            this.Controls.Add(this.randRechtsPanel);
            this.Controls.Add(this.randUntenPanel);
            this.Name = "grauwert";
            this.Text = "Grauwert";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grauwertPicturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar grauwertProgressBar;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox grauwertPicturebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel randObenPanel;
        private System.Windows.Forms.Panel randLinksPanel;
        private System.Windows.Forms.Panel randRechtsPanel;
        private System.Windows.Forms.Panel randUntenPanel;
    }
}