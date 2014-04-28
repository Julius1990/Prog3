namespace Prog3
{
    partial class form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkerContainer = new System.Windows.Forms.SplitContainer();
            this.bildPicturebox = new System.Windows.Forms.PictureBox();
            this.rechterContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildOeffnenDialog = new System.Windows.Forms.OpenFileDialog();
            this.randUntenPanel = new System.Windows.Forms.Panel();
            this.randRechtsPanel = new System.Windows.Forms.Panel();
            this.randLinksPanel = new System.Windows.Forms.Panel();
            this.randObenPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.menuePanel = new System.Windows.Forms.Panel();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildSpeichernDialog = new System.Windows.Forms.SaveFileDialog();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkerContainer)).BeginInit();
            this.linkerContainer.Panel1.SuspendLayout();
            this.linkerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bildPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechterContainer)).BeginInit();
            this.rechterContainer.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.menuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.linkerContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rechterContainer);
            this.splitContainer1.Size = new System.Drawing.Size(617, 478);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 5;
            // 
            // linkerContainer
            // 
            this.linkerContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkerContainer.Location = new System.Drawing.Point(0, 0);
            this.linkerContainer.Name = "linkerContainer";
            this.linkerContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // linkerContainer.Panel1
            // 
            this.linkerContainer.Panel1.AutoScroll = true;
            this.linkerContainer.Panel1.Controls.Add(this.bildPicturebox);
            this.linkerContainer.Size = new System.Drawing.Size(422, 478);
            this.linkerContainer.SplitterDistance = 280;
            this.linkerContainer.TabIndex = 0;
            // 
            // bildPicturebox
            // 
            this.bildPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bildPicturebox.Location = new System.Drawing.Point(0, 0);
            this.bildPicturebox.Name = "bildPicturebox";
            this.bildPicturebox.Size = new System.Drawing.Size(420, 278);
            this.bildPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bildPicturebox.TabIndex = 0;
            this.bildPicturebox.TabStop = false;
            // 
            // rechterContainer
            // 
            this.rechterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rechterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechterContainer.Location = new System.Drawing.Point(0, 0);
            this.rechterContainer.Name = "rechterContainer";
            this.rechterContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.rechterContainer.Size = new System.Drawing.Size(191, 478);
            this.rechterContainer.SplitterDistance = 280;
            this.rechterContainer.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.ansichtToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Margin = new System.Windows.Forms.Padding(2);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip2.Size = new System.Drawing.Size(615, 26);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.AutoSize = false;
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // bildOeffnenDialog
            // 
            this.bildOeffnenDialog.FileName = "openFileDialog1";
            // 
            // randUntenPanel
            // 
            this.randUntenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randUntenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randUntenPanel.Location = new System.Drawing.Point(0, 488);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(637, 10);
            this.randUntenPanel.TabIndex = 6;
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(627, 0);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(10, 488);
            this.randRechtsPanel.TabIndex = 7;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(10, 488);
            this.randLinksPanel.TabIndex = 8;
            // 
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(10, 0);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(617, 10);
            this.randObenPanel.TabIndex = 9;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.menuePanel);
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(617, 478);
            this.centerPanel.TabIndex = 10;
            // 
            // menuePanel
            // 
            this.menuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuePanel.Controls.Add(this.menuStrip2);
            this.menuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuePanel.Location = new System.Drawing.Point(0, 0);
            this.menuePanel.Name = "menuePanel";
            this.menuePanel.Size = new System.Drawing.Size(617, 28);
            this.menuePanel.TabIndex = 6;
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.wiederholenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // rückgängigToolStripMenuItem
            // 
            this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rückgängigToolStripMenuItem.Text = "Rückgängig";
            // 
            // wiederholenToolStripMenuItem
            // 
            this.wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
            this.wiederholenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wiederholenToolStripMenuItem.Text = "Wiederholen";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 498);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.randObenPanel);
            this.Controls.Add(this.randLinksPanel);
            this.Controls.Add(this.randRechtsPanel);
            this.Controls.Add(this.randUntenPanel);
            this.Name = "form1";
            this.Text = "Prog3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.linkerContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linkerContainer)).EndInit();
            this.linkerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bildPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechterContainer)).EndInit();
            this.rechterContainer.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            this.menuePanel.ResumeLayout(false);
            this.menuePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer linkerContainer;
        private System.Windows.Forms.SplitContainer rechterContainer;
        private System.Windows.Forms.PictureBox bildPicturebox;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog bildOeffnenDialog;
        private System.Windows.Forms.Panel randUntenPanel;
        private System.Windows.Forms.Panel randRechtsPanel;
        private System.Windows.Forms.Panel randLinksPanel;
        private System.Windows.Forms.Panel randObenPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel menuePanel;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog bildSpeichernDialog;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rückgängigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiederholenToolStripMenuItem;


    }
}

