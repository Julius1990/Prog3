namespace Prog3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.allesPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.fortschrittPanel = new System.Windows.Forms.Panel();
            this.optionenPanel = new System.Windows.Forms.Panel();
            this.pictureboxPanel = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allesPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // allesPanel
            // 
            this.allesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allesPanel.AutoScroll = true;
            this.allesPanel.AutoSize = true;
            this.allesPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.allesPanel.Controls.Add(this.infoPanel);
            this.allesPanel.Controls.Add(this.fortschrittPanel);
            this.allesPanel.Controls.Add(this.optionenPanel);
            this.allesPanel.Controls.Add(this.pictureboxPanel);
            this.allesPanel.Controls.Add(this.menuStrip2);
            this.allesPanel.Location = new System.Drawing.Point(12, 9);
            this.allesPanel.MinimumSize = new System.Drawing.Size(100, 100);
            this.allesPanel.Name = "allesPanel";
            this.allesPanel.Size = new System.Drawing.Size(608, 437);
            this.allesPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoPanel.AutoScroll = true;
            this.infoPanel.AutoSize = true;
            this.infoPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.infoPanel.Location = new System.Drawing.Point(4, 384);
            this.infoPanel.MinimumSize = new System.Drawing.Size(50, 50);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(439, 50);
            this.infoPanel.TabIndex = 3;
            // 
            // fortschrittPanel
            // 
            this.fortschrittPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fortschrittPanel.AutoScroll = true;
            this.fortschrittPanel.AutoSize = true;
            this.fortschrittPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fortschrittPanel.Location = new System.Drawing.Point(448, 334);
            this.fortschrittPanel.MinimumSize = new System.Drawing.Size(100, 100);
            this.fortschrittPanel.Name = "fortschrittPanel";
            this.fortschrittPanel.Size = new System.Drawing.Size(157, 100);
            this.fortschrittPanel.TabIndex = 2;
            // 
            // optionenPanel
            // 
            this.optionenPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionenPanel.AutoScroll = true;
            this.optionenPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.optionenPanel.Location = new System.Drawing.Point(448, 37);
            this.optionenPanel.MinimumSize = new System.Drawing.Size(100, 100);
            this.optionenPanel.Name = "optionenPanel";
            this.optionenPanel.Size = new System.Drawing.Size(157, 291);
            this.optionenPanel.TabIndex = 1;
            // 
            // pictureboxPanel
            // 
            this.pictureboxPanel.AutoScroll = true;
            this.pictureboxPanel.AutoSize = true;
            this.pictureboxPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureboxPanel.Location = new System.Drawing.Point(4, 37);
            this.pictureboxPanel.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureboxPanel.Name = "pictureboxPanel";
            this.pictureboxPanel.Size = new System.Drawing.Size(439, 341);
            this.pictureboxPanel.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(4, 5);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(601, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(632, 456);
            this.Controls.Add(this.allesPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.allesPanel.ResumeLayout(false);
            this.allesPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel allesPanel;
        private System.Windows.Forms.Panel pictureboxPanel;
        private System.Windows.Forms.Panel optionenPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel fortschrittPanel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;


    }
}

