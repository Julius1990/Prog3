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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkerContainer = new System.Windows.Forms.SplitContainer();
            this.form1ProgressBar = new System.Windows.Forms.ProgressBar();
            this.bildPicturebox = new System.Windows.Forms.PictureBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelTextB = new System.Windows.Forms.Label();
            this.labelTextG = new System.Windows.Forms.Label();
            this.labelTextR = new System.Windows.Forms.Label();
            this.rechterContainer = new System.Windows.Forms.SplitContainer();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.invertedButton = new System.Windows.Forms.Button();
            this.greyValButton = new System.Windows.Forms.Button();
            this.ansichtPanel = new System.Windows.Forms.Panel();
            this.linksDrehenButton = new System.Windows.Forms.Button();
            this.rechtsDrehenButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.korrekturenCheckBox = new System.Windows.Forms.CheckBox();
            this.werkzeugeCheckBox = new System.Windows.Forms.CheckBox();
            this.ansichtCheckBox = new System.Windows.Forms.CheckBox();
            this.werkzeugPanel = new System.Windows.Forms.Panel();
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.handButton = new System.Windows.Forms.Button();
            this.korrekturenPanel = new System.Windows.Forms.Panel();
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
            this.FilterPanel.SuspendLayout();
            this.ansichtPanel.SuspendLayout();
            this.werkzeugPanel.SuspendLayout();
            this.korrekturenPanel.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(723, 493);
            this.splitContainer1.SplitterDistance = 356;
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
            this.linkerContainer.Panel1.Controls.Add(this.form1ProgressBar);
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
            this.linkerContainer.Size = new System.Drawing.Size(356, 493);
            this.linkerContainer.SplitterDistance = 323;
            this.linkerContainer.TabIndex = 0;
            // 
            // form1ProgressBar
            // 
            this.form1ProgressBar.Location = new System.Drawing.Point(56, 136);
            this.form1ProgressBar.Margin = new System.Windows.Forms.Padding(6);
            this.form1ProgressBar.Name = "form1ProgressBar";
            this.form1ProgressBar.Size = new System.Drawing.Size(182, 23);
            this.form1ProgressBar.TabIndex = 7;
            this.form1ProgressBar.Visible = false;
            // 
            // bildPicturebox
            // 
            this.bildPicturebox.Location = new System.Drawing.Point(5, 31);
            this.bildPicturebox.Name = "bildPicturebox";
            this.bildPicturebox.Size = new System.Drawing.Size(412, 279);
            this.bildPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bildPicturebox.TabIndex = 0;
            this.bildPicturebox.TabStop = false;
            this.bildPicturebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseClick);
            this.bildPicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseDown);
            this.bildPicturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseMove);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(150, 21);
            this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(39, 13);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "default";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(75, 21);
            this.labelG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(39, 13);
            this.labelG.TabIndex = 5;
            this.labelG.Text = "default";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(4, 21);
            this.labelR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(39, 13);
            this.labelR.TabIndex = 4;
            this.labelR.Text = "default";
            // 
            // labelTextB
            // 
            this.labelTextB.AutoSize = true;
            this.labelTextB.Location = new System.Drawing.Point(150, 8);
            this.labelTextB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextB.Name = "labelTextB";
            this.labelTextB.Size = new System.Drawing.Size(34, 13);
            this.labelTextB.TabIndex = 3;
            this.labelTextB.Text = "Blau: ";
            // 
            // labelTextG
            // 
            this.labelTextG.AutoSize = true;
            this.labelTextG.Location = new System.Drawing.Point(75, 8);
            this.labelTextG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextG.Name = "labelTextG";
            this.labelTextG.Size = new System.Drawing.Size(36, 13);
            this.labelTextG.TabIndex = 2;
            this.labelTextG.Text = "Grün: ";
            // 
            // labelTextR
            // 
            this.labelTextR.AutoSize = true;
            this.labelTextR.Location = new System.Drawing.Point(4, 8);
            this.labelTextR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextR.Name = "labelTextR";
            this.labelTextR.Size = new System.Drawing.Size(30, 13);
            this.labelTextR.TabIndex = 1;
            this.labelTextR.Text = "Rot: ";
            // 
            // rechterContainer
            // 
            this.rechterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rechterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechterContainer.Location = new System.Drawing.Point(0, 0);
            this.rechterContainer.Name = "rechterContainer";
            this.rechterContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rechterContainer.Panel1
            // 
            this.rechterContainer.Panel1.AutoScroll = true;
            this.rechterContainer.Panel1.Controls.Add(this.filterCheckBox);
            this.rechterContainer.Panel1.Controls.Add(this.FilterPanel);
            this.rechterContainer.Panel1.Controls.Add(this.ansichtPanel);
            this.rechterContainer.Panel1.Controls.Add(this.korrekturenCheckBox);
            this.rechterContainer.Panel1.Controls.Add(this.werkzeugeCheckBox);
            this.rechterContainer.Panel1.Controls.Add(this.ansichtCheckBox);
            this.rechterContainer.Panel1.Controls.Add(this.werkzeugPanel);
            this.rechterContainer.Panel1.Controls.Add(this.korrekturenPanel);
            this.rechterContainer.Size = new System.Drawing.Size(363, 493);
            this.rechterContainer.SplitterDistance = 348;
            this.rechterContainer.TabIndex = 0;
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.filterCheckBox.Image = global::Prog3.Properties.Resources.pfeil_rechts2;
            this.filterCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterCheckBox.Location = new System.Drawing.Point(3, 121);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(161, 24);
            this.filterCheckBox.TabIndex = 11;
            this.filterCheckBox.Text = "      Filter";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // FilterPanel
            // 
            this.FilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FilterPanel.Controls.Add(this.invertedButton);
            this.FilterPanel.Controls.Add(this.greyValButton);
            this.FilterPanel.Location = new System.Drawing.Point(171, 248);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(161, 62);
            this.FilterPanel.TabIndex = 10;
            this.FilterPanel.Visible = false;
            // 
            // invertedButton
            // 
            this.invertedButton.Location = new System.Drawing.Point(3, 30);
            this.invertedButton.Margin = new System.Windows.Forms.Padding(2);
            this.invertedButton.Name = "invertedButton";
            this.invertedButton.Size = new System.Drawing.Size(114, 22);
            this.invertedButton.TabIndex = 12;
            this.invertedButton.Text = "Negativbild";
            this.invertedButton.UseVisualStyleBackColor = true;
            this.invertedButton.Click += new System.EventHandler(this.invertedButton_Click);
            // 
            // greyValButton
            // 
            this.greyValButton.Location = new System.Drawing.Point(3, 7);
            this.greyValButton.Margin = new System.Windows.Forms.Padding(2);
            this.greyValButton.Name = "greyValButton";
            this.greyValButton.Size = new System.Drawing.Size(114, 19);
            this.greyValButton.TabIndex = 11;
            this.greyValButton.Text = "Grauwertbild";
            this.greyValButton.UseVisualStyleBackColor = true;
            this.greyValButton.Click += new System.EventHandler(this.greyValButton_Click);
            // 
            // ansichtPanel
            // 
            this.ansichtPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ansichtPanel.Controls.Add(this.linksDrehenButton);
            this.ansichtPanel.Controls.Add(this.rechtsDrehenButton);
            this.ansichtPanel.Controls.Add(this.zoomOutButton);
            this.ansichtPanel.Controls.Add(this.zoomInButton);
            this.ansichtPanel.Location = new System.Drawing.Point(170, 180);
            this.ansichtPanel.Name = "ansichtPanel";
            this.ansichtPanel.Size = new System.Drawing.Size(161, 62);
            this.ansichtPanel.TabIndex = 5;
            this.ansichtPanel.Visible = false;
            // 
            // linksDrehenButton
            // 
            this.linksDrehenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("linksDrehenButton.BackgroundImage")));
            this.linksDrehenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.linksDrehenButton.Location = new System.Drawing.Point(88, 16);
            this.linksDrehenButton.Name = "linksDrehenButton";
            this.linksDrehenButton.Size = new System.Drawing.Size(30, 30);
            this.linksDrehenButton.TabIndex = 3;
            this.linksDrehenButton.UseVisualStyleBackColor = true;
            this.linksDrehenButton.Click += new System.EventHandler(this.linksDrehenButton_Click);
            // 
            // rechtsDrehenButton
            // 
            this.rechtsDrehenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rechtsDrehenButton.BackgroundImage")));
            this.rechtsDrehenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rechtsDrehenButton.Location = new System.Drawing.Point(124, 16);
            this.rechtsDrehenButton.Name = "rechtsDrehenButton";
            this.rechtsDrehenButton.Size = new System.Drawing.Size(30, 30);
            this.rechtsDrehenButton.TabIndex = 2;
            this.rechtsDrehenButton.UseVisualStyleBackColor = true;
            this.rechtsDrehenButton.Click += new System.EventHandler(this.rechtsDrehenButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.BackgroundImage")));
            this.zoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomOutButton.Location = new System.Drawing.Point(37, 16);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(30, 30);
            this.zoomOutButton.TabIndex = 1;
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomInButton.BackgroundImage")));
            this.zoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomInButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.zoomInButton.Location = new System.Drawing.Point(3, 16);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(30, 30);
            this.zoomInButton.TabIndex = 0;
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // korrekturenCheckBox
            // 
            this.korrekturenCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.korrekturenCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("korrekturenCheckBox.Image")));
            this.korrekturenCheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.korrekturenCheckBox.Location = new System.Drawing.Point(3, 31);
            this.korrekturenCheckBox.Name = "korrekturenCheckBox";
            this.korrekturenCheckBox.Size = new System.Drawing.Size(162, 24);
            this.korrekturenCheckBox.TabIndex = 9;
            this.korrekturenCheckBox.Text = "      Korrekturen";
            this.korrekturenCheckBox.UseVisualStyleBackColor = true;
            this.korrekturenCheckBox.CheckedChanged += new System.EventHandler(this.korrekturenCheckBox_CheckedChanged);
            // 
            // werkzeugeCheckBox
            // 
            this.werkzeugeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.werkzeugeCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("werkzeugeCheckBox.Image")));
            this.werkzeugeCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.werkzeugeCheckBox.Location = new System.Drawing.Point(3, 61);
            this.werkzeugeCheckBox.Name = "werkzeugeCheckBox";
            this.werkzeugeCheckBox.Size = new System.Drawing.Size(161, 24);
            this.werkzeugeCheckBox.TabIndex = 8;
            this.werkzeugeCheckBox.Text = "      Werkzeuge";
            this.werkzeugeCheckBox.UseVisualStyleBackColor = true;
            this.werkzeugeCheckBox.CheckedChanged += new System.EventHandler(this.werkzeugeCheckBox_CheckedChanged);
            // 
            // ansichtCheckBox
            // 
            this.ansichtCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ansichtCheckBox.Image = global::Prog3.Properties.Resources.pfeil_rechts2;
            this.ansichtCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ansichtCheckBox.Location = new System.Drawing.Point(3, 91);
            this.ansichtCheckBox.Name = "ansichtCheckBox";
            this.ansichtCheckBox.Size = new System.Drawing.Size(161, 24);
            this.ansichtCheckBox.TabIndex = 7;
            this.ansichtCheckBox.Text = "      Ansicht";
            this.ansichtCheckBox.UseVisualStyleBackColor = true;
            this.ansichtCheckBox.CheckedChanged += new System.EventHandler(this.ansichtCheckBox_CheckedChanged);
            // 
            // werkzeugPanel
            // 
            this.werkzeugPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.werkzeugPanel.Controls.Add(this.colorPickerButton);
            this.werkzeugPanel.Controls.Add(this.handButton);
            this.werkzeugPanel.Location = new System.Drawing.Point(171, 117);
            this.werkzeugPanel.Name = "werkzeugPanel";
            this.werkzeugPanel.Size = new System.Drawing.Size(161, 57);
            this.werkzeugPanel.TabIndex = 3;
            this.werkzeugPanel.Visible = false;
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorPickerButton.BackgroundImage")));
            this.colorPickerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colorPickerButton.Location = new System.Drawing.Point(37, 10);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(30, 30);
            this.colorPickerButton.TabIndex = 1;
            this.colorPickerButton.UseVisualStyleBackColor = true;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click);
            // 
            // handButton
            // 
            this.handButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("handButton.BackgroundImage")));
            this.handButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.handButton.Location = new System.Drawing.Point(3, 10);
            this.handButton.Name = "handButton";
            this.handButton.Size = new System.Drawing.Size(30, 30);
            this.handButton.TabIndex = 0;
            this.handButton.UseVisualStyleBackColor = true;
            this.handButton.Click += new System.EventHandler(this.handButton_Click);
            // 
            // korrekturenPanel
            // 
            this.korrekturenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.korrekturenPanel.Controls.Add(this.button2);
            this.korrekturenPanel.Location = new System.Drawing.Point(171, 33);
            this.korrekturenPanel.Name = "korrekturenPanel";
            this.korrekturenPanel.Size = new System.Drawing.Size(160, 78);
            this.korrekturenPanel.TabIndex = 1;
            this.korrekturenPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Kontrast //temporär";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.kontrastButton_Click);
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
            this.menuStrip2.Size = new System.Drawing.Size(721, 26);
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
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Visible = false;
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            this.speichernUnterToolStripMenuItem.Visible = false;
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Visible = false;
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
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
            this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.rückgängigToolStripMenuItem.Text = "Rückgängig";
            this.rückgängigToolStripMenuItem.Click += new System.EventHandler(this.rückgängigToolStripMenuItem_Click);
            // 
            // wiederholenToolStripMenuItem
            // 
            this.wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
            this.wiederholenToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.wiederholenToolStripMenuItem.Text = "Wiederholen";
            this.wiederholenToolStripMenuItem.Click += new System.EventHandler(this.wiederholenToolStripMenuItem_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
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
            this.randUntenPanel.Location = new System.Drawing.Point(0, 503);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(743, 10);
            this.randUntenPanel.TabIndex = 6;
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(733, 0);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(10, 503);
            this.randRechtsPanel.TabIndex = 7;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(10, 503);
            this.randLinksPanel.TabIndex = 8;
            // 
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(10, 0);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(723, 10);
            this.randObenPanel.TabIndex = 9;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.menuePanel);
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(723, 493);
            this.centerPanel.TabIndex = 10;
            // 
            // menuePanel
            // 
            this.menuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuePanel.Controls.Add(this.menuStrip2);
            this.menuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuePanel.Location = new System.Drawing.Point(0, 0);
            this.menuePanel.Name = "menuePanel";
            this.menuePanel.Size = new System.Drawing.Size(723, 28);
            this.menuePanel.TabIndex = 6;
            // 
            // bildSpeichernDialog
            // 
            this.bildSpeichernDialog.Filter = "JPG|.jpg|PNG|.png|GIF|.gif|TIF|.tif|BMP|.bmp";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 513);
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
            this.linkerContainer.Panel2.ResumeLayout(false);
            this.linkerContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkerContainer)).EndInit();
            this.linkerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bildPicturebox)).EndInit();
            this.rechterContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rechterContainer)).EndInit();
            this.rechterContainer.ResumeLayout(false);
            this.FilterPanel.ResumeLayout(false);
            this.ansichtPanel.ResumeLayout(false);
            this.werkzeugPanel.ResumeLayout(false);
            this.korrekturenPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel werkzeugPanel;
        private System.Windows.Forms.Button handButton;
        private System.Windows.Forms.Panel korrekturenPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel ansichtPanel;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelTextB;
        private System.Windows.Forms.Label labelTextG;
        private System.Windows.Forms.Label labelTextR;
        private System.Windows.Forms.Button rechtsDrehenButton;
        private System.Windows.Forms.Button linksDrehenButton;
        private System.Windows.Forms.Button colorPickerButton;
        private System.Windows.Forms.Button greyValButton;
        private System.Windows.Forms.Button invertedButton;
        private System.Windows.Forms.CheckBox ansichtCheckBox;
        private System.Windows.Forms.CheckBox werkzeugeCheckBox;
        private System.Windows.Forms.CheckBox korrekturenCheckBox;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.ProgressBar form1ProgressBar;


    }
}

