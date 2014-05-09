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
            this.ansicht = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.handButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildOeffnenDialog = new System.Windows.Forms.OpenFileDialog();
            this.randUntenPanel = new System.Windows.Forms.Panel();
            this.randRechtsPanel = new System.Windows.Forms.Panel();
            this.randLinksPanel = new System.Windows.Forms.Panel();
            this.randObenPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.menuePanel = new System.Windows.Forms.Panel();
            this.bildSpeichernDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelTextR = new System.Windows.Forms.Label();
            this.labelTextG = new System.Windows.Forms.Label();
            this.labelTextB = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkerContainer)).BeginInit();
            this.linkerContainer.Panel1.SuspendLayout();
            this.linkerContainer.Panel2.SuspendLayout();
            this.linkerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bildPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechterContainer)).BeginInit();
            this.rechterContainer.Panel1.SuspendLayout();
            this.rechterContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.menuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.linkerContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rechterContainer);
            this.splitContainer1.Size = new System.Drawing.Size(926, 736);
            this.splitContainer1.SplitterDistance = 633;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 5;
            // 
            // linkerContainer
            // 
            this.linkerContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkerContainer.Location = new System.Drawing.Point(0, 0);
            this.linkerContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.linkerContainer.Name = "linkerContainer";
            this.linkerContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // linkerContainer.Panel1
            // 
            this.linkerContainer.Panel1.AutoScroll = true;
            this.linkerContainer.Panel1.Controls.Add(this.bildPicturebox);
            // 
            // linkerContainer.Panel2
            // 
            this.linkerContainer.Panel2.Controls.Add(this.labelB);
            this.linkerContainer.Panel2.Controls.Add(this.labelG);
            this.linkerContainer.Panel2.Controls.Add(this.labelR);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextB);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextG);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextR);
            this.linkerContainer.Size = new System.Drawing.Size(633, 736);
            this.linkerContainer.SplitterDistance = 485;
            this.linkerContainer.SplitterWidth = 6;
            this.linkerContainer.TabIndex = 0;
            // 
            // bildPicturebox
            // 
            this.bildPicturebox.Location = new System.Drawing.Point(8, 48);
            this.bildPicturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bildPicturebox.Name = "bildPicturebox";
            this.bildPicturebox.Size = new System.Drawing.Size(618, 429);
            this.bildPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bildPicturebox.TabIndex = 0;
            this.bildPicturebox.TabStop = false;
            this.bildPicturebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseClick);
            this.bildPicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseDown);
            this.bildPicturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseMove);
            // 
            // rechterContainer
            // 
            this.rechterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rechterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechterContainer.Location = new System.Drawing.Point(0, 0);
            this.rechterContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rechterContainer.Name = "rechterContainer";
            this.rechterContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rechterContainer.Panel1
            // 
            this.rechterContainer.Panel1.Controls.Add(this.ansicht);
            this.rechterContainer.Panel1.Controls.Add(this.panel3);
            this.rechterContainer.Panel1.Controls.Add(this.label2);
            this.rechterContainer.Panel1.Controls.Add(this.panel1);
            this.rechterContainer.Panel1.Controls.Add(this.label1);
            this.rechterContainer.Panel1.Controls.Add(this.panel2);
            this.rechterContainer.Size = new System.Drawing.Size(287, 736);
            this.rechterContainer.SplitterDistance = 483;
            this.rechterContainer.SplitterWidth = 6;
            this.rechterContainer.TabIndex = 0;
            // 
            // ansicht
            // 
            this.ansicht.AutoSize = true;
            this.ansicht.Location = new System.Drawing.Point(22, 366);
            this.ansicht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ansicht.Name = "ansicht";
            this.ansicht.Size = new System.Drawing.Size(62, 20);
            this.ansicht.TabIndex = 6;
            this.ansicht.Text = "Ansicht";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.zoomOutButton);
            this.panel3.Controls.Add(this.zoomInButton);
            this.panel3.Location = new System.Drawing.Point(12, 380);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 93);
            this.panel3.TabIndex = 5;
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(63, 25);
            this.zoomOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(38, 35);
            this.zoomOutButton.TabIndex = 1;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(4, 25);
            this.zoomInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(38, 35);
            this.zoomInButton.TabIndex = 0;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Werkzeuge";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.handButton);
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 118);
            this.panel1.TabIndex = 3;
            // 
            // handButton
            // 
            this.handButton.Location = new System.Drawing.Point(4, 25);
            this.handButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.handButton.Name = "handButton";
            this.handButton.Size = new System.Drawing.Size(171, 35);
            this.handButton.TabIndex = 0;
            this.handButton.Text = "Hand";
            this.handButton.UseVisualStyleBackColor = true;
            this.handButton.Click += new System.EventHandler(this.handButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korrekturen";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 104);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Kontrast //temporär";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.ansichtToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.menuStrip2.Size = new System.Drawing.Size(924, 40);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.schließenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(65, 34);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Visible = false;
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            this.speichernUnterToolStripMenuItem.Visible = false;
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Visible = false;
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.wiederholenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(107, 34);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // rückgängigToolStripMenuItem
            // 
            this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.rückgängigToolStripMenuItem.Text = "Rückgängig";
            this.rückgängigToolStripMenuItem.Click += new System.EventHandler(this.rückgängigToolStripMenuItem_Click);
            // 
            // wiederholenToolStripMenuItem
            // 
            this.wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
            this.wiederholenToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.wiederholenToolStripMenuItem.Text = "Wiederholen";
            this.wiederholenToolStripMenuItem.Click += new System.EventHandler(this.wiederholenToolStripMenuItem_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(82, 34);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // bildOeffnenDialog
            // 
            this.bildOeffnenDialog.FileName = "openFileDialog1";
            // 
            // randUntenPanel
            // 
            this.randUntenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randUntenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randUntenPanel.Location = new System.Drawing.Point(0, 751);
            this.randUntenPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(956, 15);
            this.randUntenPanel.TabIndex = 6;
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(941, 0);
            this.randRechtsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(15, 751);
            this.randRechtsPanel.TabIndex = 7;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(15, 751);
            this.randLinksPanel.TabIndex = 8;
            // 
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(15, 0);
            this.randObenPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(926, 15);
            this.randObenPanel.TabIndex = 9;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.menuePanel);
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(15, 15);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(926, 736);
            this.centerPanel.TabIndex = 10;
            // 
            // menuePanel
            // 
            this.menuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuePanel.Controls.Add(this.menuStrip2);
            this.menuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuePanel.Location = new System.Drawing.Point(0, 0);
            this.menuePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuePanel.Name = "menuePanel";
            this.menuePanel.Size = new System.Drawing.Size(926, 42);
            this.menuePanel.TabIndex = 6;
            // 
            // bildSpeichernDialog
            // 
            this.bildSpeichernDialog.Filter = "JPG|.jpg|PNG|.png|GIF|.gif|TIF|.tif|BMP|.bmp";
            // 
            // labelTextR
            // 
            this.labelTextR.AutoSize = true;
            this.labelTextR.Location = new System.Drawing.Point(6, 12);
            this.labelTextR.Name = "labelTextR";
            this.labelTextR.Size = new System.Drawing.Size(43, 20);
            this.labelTextR.TabIndex = 1;
            this.labelTextR.Text = "Rot: ";
            // 
            // labelTextG
            // 
            this.labelTextG.AutoSize = true;
            this.labelTextG.Location = new System.Drawing.Point(112, 12);
            this.labelTextG.Name = "labelTextG";
            this.labelTextG.Size = new System.Drawing.Size(53, 20);
            this.labelTextG.TabIndex = 2;
            this.labelTextG.Text = "Grün: ";
            // 
            // labelTextB
            // 
            this.labelTextB.AutoSize = true;
            this.labelTextB.Location = new System.Drawing.Point(225, 12);
            this.labelTextB.Name = "labelTextB";
            this.labelTextB.Size = new System.Drawing.Size(49, 20);
            this.labelTextB.TabIndex = 3;
            this.labelTextB.Text = "Blau: ";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(6, 32);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(58, 20);
            this.labelR.TabIndex = 4;
            this.labelR.Text = "default";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(112, 32);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(58, 20);
            this.labelG.TabIndex = 5;
            this.labelG.Text = "default";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(225, 32);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(58, 20);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "default";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 766);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.randObenPanel);
            this.Controls.Add(this.randLinksPanel);
            this.Controls.Add(this.randRechtsPanel);
            this.Controls.Add(this.randUntenPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form1";
            this.Text = "Prog3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.linkerContainer.Panel1.ResumeLayout(false);
            this.linkerContainer.Panel2.ResumeLayout(false);
            this.linkerContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkerContainer)).EndInit();
            this.linkerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bildPicturebox)).EndInit();
            this.rechterContainer.Panel1.ResumeLayout(false);
            this.rechterContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechterContainer)).EndInit();
            this.rechterContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rückgängigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiederholenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button handButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ansicht;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelTextB;
        private System.Windows.Forms.Label labelTextG;
        private System.Windows.Forms.Label labelTextR;


    }
}

