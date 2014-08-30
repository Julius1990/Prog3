namespace Prog3
{
    partial class _hauptfenster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_hauptfenster));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkerContainer = new System.Windows.Forms.SplitContainer();
            this.progressBarAbbrechenButton = new System.Windows.Forms.Button();
            this.form1ProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelBr = new System.Windows.Forms.Label();
            this.labelTextBr = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelTextS = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelTextH = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelTextB = new System.Windows.Forms.Label();
            this.labelTextG = new System.Windows.Forms.Label();
            this.labelTextR = new System.Windows.Forms.Label();
            this.rechterContainer = new System.Windows.Forms.SplitContainer();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            this.sepiaButton = new System.Windows.Forms.Button();
            this.invertedButton = new System.Windows.Forms.Button();
            this.greyValButton = new System.Windows.Forms.Button();
            this.ansichtPanel = new System.Windows.Forms.Panel();
            this.werkzeugPanel = new System.Windows.Forms.Panel();
            this.buttonExif = new System.Windows.Forms.Button();
            this.korrekturenPanel = new System.Windows.Forms.Panel();
            this.weissabgleichButton = new System.Windows.Forms.Button();
            this.helligkeitButton = new System.Windows.Forms.Button();
            this.saettigungButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControllHistogramme = new System.Windows.Forms.TabControl();
            this.tabGrau = new System.Windows.Forms.TabPage();
            this.buttonCancelHistGray = new System.Windows.Forms.Button();
            this.tabRGB = new System.Windows.Forms.TabPage();
            this.buttonCancelHistRGB = new System.Windows.Forms.Button();
            this.tabR = new System.Windows.Forms.TabPage();
            this.buttonCancelHistoRed = new System.Windows.Forms.Button();
            this.tabG = new System.Windows.Forms.TabPage();
            this.buttonCancelHistoGreen = new System.Windows.Forms.Button();
            this.tabB = new System.Windows.Forms.TabPage();
            this.buttonCancelHistoBlue = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drehe90RechtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drehe90LinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verkleinernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildOeffnenDialog = new System.Windows.Forms.OpenFileDialog();
            this.randUntenPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.randRechtsPanel = new System.Windows.Forms.Panel();
            this.randLinksPanel = new System.Windows.Forms.Panel();
            this.randObenPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.menuePanel = new System.Windows.Forms.Panel();
            this.bildSpeichernDialog = new System.Windows.Forms.SaveFileDialog();
            this.grauwertBW = new System.ComponentModel.BackgroundWorker();
            this.negativBW = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sepiaBackWorker = new System.ComponentModel.BackgroundWorker();
            this.bildPicturebox = new System.Windows.Forms.PictureBox();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.linksDrehenButton = new System.Windows.Forms.Button();
            this.rechtsDrehenButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.korrekturenCheckBox = new System.Windows.Forms.CheckBox();
            this.werkzeugeCheckBox = new System.Windows.Forms.CheckBox();
            this.ansichtCheckBox = new System.Windows.Forms.CheckBox();
            this.beschneidenCheckBox = new System.Windows.Forms.CheckBox();
            this.skalierenButton = new System.Windows.Forms.Button();
            this.handCheckBox = new System.Windows.Forms.CheckBox();
            this.colorPickerCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBoxHistoGrau = new System.Windows.Forms.PictureBox();
            this.pictureBoxHistoRGB = new System.Windows.Forms.PictureBox();
            this.pictureBoxHistoRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxHistoGruen = new System.Windows.Forms.PictureBox();
            this.pictureBoxHistoBlau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkerContainer)).BeginInit();
            this.linkerContainer.Panel1.SuspendLayout();
            this.linkerContainer.Panel2.SuspendLayout();
            this.linkerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechterContainer)).BeginInit();
            this.rechterContainer.Panel1.SuspendLayout();
            this.rechterContainer.Panel2.SuspendLayout();
            this.rechterContainer.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.ansichtPanel.SuspendLayout();
            this.werkzeugPanel.SuspendLayout();
            this.korrekturenPanel.SuspendLayout();
            this.tabControllHistogramme.SuspendLayout();
            this.tabGrau.SuspendLayout();
            this.tabRGB.SuspendLayout();
            this.tabR.SuspendLayout();
            this.tabG.SuspendLayout();
            this.tabB.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.randUntenPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.menuePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bildPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoGrau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoGruen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoBlau)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(838, 441);
            this.splitContainer1.SplitterDistance = 548;
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
            this.linkerContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkerContainer.Panel1.Controls.Add(this.progressBarAbbrechenButton);
            this.linkerContainer.Panel1.Controls.Add(this.form1ProgressBar);
            this.linkerContainer.Panel1.Controls.Add(this.bildPicturebox);
            // 
            // linkerContainer.Panel2
            // 
            this.linkerContainer.Panel2.Controls.Add(this.pictureBoxColor);
            this.linkerContainer.Panel2.Controls.Add(this.labelBr);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextBr);
            this.linkerContainer.Panel2.Controls.Add(this.labelS);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextS);
            this.linkerContainer.Panel2.Controls.Add(this.labelH);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextH);
            this.linkerContainer.Panel2.Controls.Add(this.labelB);
            this.linkerContainer.Panel2.Controls.Add(this.labelG);
            this.linkerContainer.Panel2.Controls.Add(this.labelR);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextB);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextG);
            this.linkerContainer.Panel2.Controls.Add(this.labelTextR);
            this.linkerContainer.Size = new System.Drawing.Size(548, 441);
            this.linkerContainer.SplitterDistance = 365;
            this.linkerContainer.TabIndex = 0;
            // 
            // progressBarAbbrechenButton
            // 
            this.progressBarAbbrechenButton.Location = new System.Drawing.Point(94, 168);
            this.progressBarAbbrechenButton.Name = "progressBarAbbrechenButton";
            this.progressBarAbbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.progressBarAbbrechenButton.TabIndex = 12;
            this.progressBarAbbrechenButton.Text = "Abbrechen";
            this.progressBarAbbrechenButton.UseVisualStyleBackColor = true;
            this.progressBarAbbrechenButton.Visible = false;
            this.progressBarAbbrechenButton.Click += new System.EventHandler(this.abbrechenButton_CLick);
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
            // labelBr
            // 
            this.labelBr.AutoSize = true;
            this.labelBr.Location = new System.Drawing.Point(273, 50);
            this.labelBr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBr.Name = "labelBr";
            this.labelBr.Size = new System.Drawing.Size(39, 13);
            this.labelBr.TabIndex = 18;
            this.labelBr.Text = "default";
            // 
            // labelTextBr
            // 
            this.labelTextBr.AutoSize = true;
            this.labelTextBr.Location = new System.Drawing.Point(202, 50);
            this.labelTextBr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextBr.Name = "labelTextBr";
            this.labelTextBr.Size = new System.Drawing.Size(59, 13);
            this.labelTextBr.TabIndex = 17;
            this.labelTextBr.Text = "Brightness:";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(273, 28);
            this.labelS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(39, 13);
            this.labelS.TabIndex = 16;
            this.labelS.Text = "default";
            // 
            // labelTextS
            // 
            this.labelTextS.AutoSize = true;
            this.labelTextS.Location = new System.Drawing.Point(203, 28);
            this.labelTextS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextS.Name = "labelTextS";
            this.labelTextS.Size = new System.Drawing.Size(58, 13);
            this.labelTextS.TabIndex = 15;
            this.labelTextS.Text = "Saturation:";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(273, 8);
            this.labelH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(39, 13);
            this.labelH.TabIndex = 14;
            this.labelH.Text = "default";
            // 
            // labelTextH
            // 
            this.labelTextH.AutoSize = true;
            this.labelTextH.Location = new System.Drawing.Point(231, 8);
            this.labelTextH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextH.Name = "labelTextH";
            this.labelTextH.Size = new System.Drawing.Size(30, 13);
            this.labelTextH.TabIndex = 13;
            this.labelTextH.Text = "Hue:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(53, 50);
            this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(39, 13);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "default";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(53, 28);
            this.labelG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(39, 13);
            this.labelG.TabIndex = 5;
            this.labelG.Text = "default";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(53, 8);
            this.labelR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(39, 13);
            this.labelR.TabIndex = 4;
            this.labelR.Text = "default";
            // 
            // labelTextB
            // 
            this.labelTextB.AutoSize = true;
            this.labelTextB.Location = new System.Drawing.Point(7, 50);
            this.labelTextB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextB.Name = "labelTextB";
            this.labelTextB.Size = new System.Drawing.Size(31, 13);
            this.labelTextB.TabIndex = 3;
            this.labelTextB.Text = "Blau:";
            // 
            // labelTextG
            // 
            this.labelTextG.AutoSize = true;
            this.labelTextG.Location = new System.Drawing.Point(5, 28);
            this.labelTextG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextG.Name = "labelTextG";
            this.labelTextG.Size = new System.Drawing.Size(33, 13);
            this.labelTextG.TabIndex = 2;
            this.labelTextG.Text = "Grün:";
            // 
            // labelTextR
            // 
            this.labelTextR.AutoSize = true;
            this.labelTextR.Location = new System.Drawing.Point(11, 9);
            this.labelTextR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextR.Name = "labelTextR";
            this.labelTextR.Size = new System.Drawing.Size(27, 13);
            this.labelTextR.TabIndex = 1;
            this.labelTextR.Text = "Rot:";
            // 
            // rechterContainer
            // 
            this.rechterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rechterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechterContainer.Location = new System.Drawing.Point(0, 0);
            this.rechterContainer.MinimumSize = new System.Drawing.Size(272, 0);
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
            // 
            // rechterContainer.Panel2
            // 
            this.rechterContainer.Panel2.Controls.Add(this.tabControllHistogramme);
            this.rechterContainer.Size = new System.Drawing.Size(286, 441);
            this.rechterContainer.SplitterDistance = 255;
            this.rechterContainer.TabIndex = 0;
            // 
            // FilterPanel
            // 
            this.FilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FilterPanel.Controls.Add(this.blackWhiteButton);
            this.FilterPanel.Controls.Add(this.sepiaButton);
            this.FilterPanel.Controls.Add(this.invertedButton);
            this.FilterPanel.Controls.Add(this.greyValButton);
            this.FilterPanel.Location = new System.Drawing.Point(3, 353);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(256, 62);
            this.FilterPanel.TabIndex = 10;
            this.FilterPanel.Visible = false;
            // 
            // blackWhiteButton
            // 
            this.blackWhiteButton.Location = new System.Drawing.Point(125, 5);
            this.blackWhiteButton.Margin = new System.Windows.Forms.Padding(2);
            this.blackWhiteButton.Name = "blackWhiteButton";
            this.blackWhiteButton.Size = new System.Drawing.Size(114, 22);
            this.blackWhiteButton.TabIndex = 14;
            this.blackWhiteButton.Text = "Schwarz-Weiß";
            this.blackWhiteButton.UseVisualStyleBackColor = true;
            this.blackWhiteButton.Click += new System.EventHandler(this.greyValButton_Click);
            // 
            // sepiaButton
            // 
            this.sepiaButton.Location = new System.Drawing.Point(125, 30);
            this.sepiaButton.Margin = new System.Windows.Forms.Padding(2);
            this.sepiaButton.Name = "sepiaButton";
            this.sepiaButton.Size = new System.Drawing.Size(114, 22);
            this.sepiaButton.TabIndex = 13;
            this.sepiaButton.Text = "Sepia";
            this.sepiaButton.UseVisualStyleBackColor = true;
            this.sepiaButton.Click += new System.EventHandler(this.sepiaButton_Click);
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
            this.ansichtPanel.Location = new System.Drawing.Point(4, 214);
            this.ansichtPanel.Name = "ansichtPanel";
            this.ansichtPanel.Size = new System.Drawing.Size(255, 62);
            this.ansichtPanel.TabIndex = 5;
            this.ansichtPanel.Visible = false;
            // 
            // werkzeugPanel
            // 
            this.werkzeugPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.werkzeugPanel.Controls.Add(this.beschneidenCheckBox);
            this.werkzeugPanel.Controls.Add(this.skalierenButton);
            this.werkzeugPanel.Controls.Add(this.buttonExif);
            this.werkzeugPanel.Controls.Add(this.handCheckBox);
            this.werkzeugPanel.Controls.Add(this.colorPickerCheckBox);
            this.werkzeugPanel.Location = new System.Drawing.Point(4, 151);
            this.werkzeugPanel.Name = "werkzeugPanel";
            this.werkzeugPanel.Size = new System.Drawing.Size(255, 57);
            this.werkzeugPanel.TabIndex = 3;
            this.werkzeugPanel.Visible = false;
            // 
            // buttonExif
            // 
            this.buttonExif.Location = new System.Drawing.Point(151, 10);
            this.buttonExif.Name = "buttonExif";
            this.buttonExif.Size = new System.Drawing.Size(66, 28);
            this.buttonExif.TabIndex = 4;
            this.buttonExif.Text = "Exif-Daten";
            this.buttonExif.UseVisualStyleBackColor = true;
            this.buttonExif.Click += new System.EventHandler(this.buttonExif_Click);
            // 
            // korrekturenPanel
            // 
            this.korrekturenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.korrekturenPanel.Controls.Add(this.weissabgleichButton);
            this.korrekturenPanel.Controls.Add(this.helligkeitButton);
            this.korrekturenPanel.Controls.Add(this.saettigungButton);
            this.korrekturenPanel.Controls.Add(this.button2);
            this.korrekturenPanel.Location = new System.Drawing.Point(3, 282);
            this.korrekturenPanel.Name = "korrekturenPanel";
            this.korrekturenPanel.Size = new System.Drawing.Size(256, 65);
            this.korrekturenPanel.TabIndex = 1;
            this.korrekturenPanel.Visible = false;
            // 
            // weissabgleichButton
            // 
            this.weissabgleichButton.Location = new System.Drawing.Point(125, 33);
            this.weissabgleichButton.Name = "weissabgleichButton";
            this.weissabgleichButton.Size = new System.Drawing.Size(114, 23);
            this.weissabgleichButton.TabIndex = 3;
            this.weissabgleichButton.Text = "Weißabgleich";
            this.weissabgleichButton.UseVisualStyleBackColor = true;
            this.weissabgleichButton.Click += new System.EventHandler(this.weissabgleichButton_Click);
            // 
            // helligkeitButton
            // 
            this.helligkeitButton.Location = new System.Drawing.Point(3, 33);
            this.helligkeitButton.Name = "helligkeitButton";
            this.helligkeitButton.Size = new System.Drawing.Size(114, 23);
            this.helligkeitButton.TabIndex = 2;
            this.helligkeitButton.Text = "Helligkeit";
            this.helligkeitButton.UseVisualStyleBackColor = true;
            this.helligkeitButton.Click += new System.EventHandler(this.helligkeitButton_Click);
            // 
            // saettigungButton
            // 
            this.saettigungButton.Location = new System.Drawing.Point(125, 3);
            this.saettigungButton.Name = "saettigungButton";
            this.saettigungButton.Size = new System.Drawing.Size(114, 23);
            this.saettigungButton.TabIndex = 1;
            this.saettigungButton.Text = "Sättigung";
            this.saettigungButton.UseVisualStyleBackColor = true;
            this.saettigungButton.Click += new System.EventHandler(this.saettigungButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Kontrast";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.kontrastButton_Click);
            // 
            // tabControllHistogramme
            // 
            this.tabControllHistogramme.Controls.Add(this.tabGrau);
            this.tabControllHistogramme.Controls.Add(this.tabRGB);
            this.tabControllHistogramme.Controls.Add(this.tabR);
            this.tabControllHistogramme.Controls.Add(this.tabG);
            this.tabControllHistogramme.Controls.Add(this.tabB);
            this.tabControllHistogramme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControllHistogramme.Location = new System.Drawing.Point(0, 0);
            this.tabControllHistogramme.Name = "tabControllHistogramme";
            this.tabControllHistogramme.SelectedIndex = 0;
            this.tabControllHistogramme.Size = new System.Drawing.Size(284, 180);
            this.tabControllHistogramme.TabIndex = 12;
            this.tabControllHistogramme.Click += new System.EventHandler(this.tabControllHistogramme_Click);
            // 
            // tabGrau
            // 
            this.tabGrau.Controls.Add(this.buttonCancelHistGray);
            this.tabGrau.Controls.Add(this.pictureBoxHistoGrau);
            this.tabGrau.Location = new System.Drawing.Point(4, 22);
            this.tabGrau.Name = "tabGrau";
            this.tabGrau.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrau.Size = new System.Drawing.Size(276, 154);
            this.tabGrau.TabIndex = 0;
            this.tabGrau.Text = "Grau";
            this.tabGrau.UseVisualStyleBackColor = true;
            // 
            // buttonCancelHistGray
            // 
            this.buttonCancelHistGray.AutoSize = true;
            this.buttonCancelHistGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelHistGray.Location = new System.Drawing.Point(59, 86);
            this.buttonCancelHistGray.Name = "buttonCancelHistGray";
            this.buttonCancelHistGray.Size = new System.Drawing.Size(127, 35);
            this.buttonCancelHistGray.TabIndex = 2;
            this.buttonCancelHistGray.Text = "Abbrechen";
            this.buttonCancelHistGray.UseVisualStyleBackColor = true;
            this.buttonCancelHistGray.Visible = false;
            this.buttonCancelHistGray.Click += new System.EventHandler(this.cancelHistoCalc);
            // 
            // tabRGB
            // 
            this.tabRGB.Controls.Add(this.buttonCancelHistRGB);
            this.tabRGB.Controls.Add(this.pictureBoxHistoRGB);
            this.tabRGB.Location = new System.Drawing.Point(4, 22);
            this.tabRGB.Name = "tabRGB";
            this.tabRGB.Padding = new System.Windows.Forms.Padding(3);
            this.tabRGB.Size = new System.Drawing.Size(276, 154);
            this.tabRGB.TabIndex = 1;
            this.tabRGB.Text = "RGB";
            this.tabRGB.UseVisualStyleBackColor = true;
            // 
            // buttonCancelHistRGB
            // 
            this.buttonCancelHistRGB.AutoSize = true;
            this.buttonCancelHistRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelHistRGB.Location = new System.Drawing.Point(54, 92);
            this.buttonCancelHistRGB.Name = "buttonCancelHistRGB";
            this.buttonCancelHistRGB.Size = new System.Drawing.Size(127, 35);
            this.buttonCancelHistRGB.TabIndex = 1;
            this.buttonCancelHistRGB.Text = "Abbrechen";
            this.buttonCancelHistRGB.UseVisualStyleBackColor = true;
            this.buttonCancelHistRGB.Visible = false;
            this.buttonCancelHistRGB.Click += new System.EventHandler(this.cancelHistoCalc);
            // 
            // tabR
            // 
            this.tabR.Controls.Add(this.buttonCancelHistoRed);
            this.tabR.Controls.Add(this.pictureBoxHistoRed);
            this.tabR.Location = new System.Drawing.Point(4, 22);
            this.tabR.Name = "tabR";
            this.tabR.Padding = new System.Windows.Forms.Padding(3);
            this.tabR.Size = new System.Drawing.Size(276, 154);
            this.tabR.TabIndex = 2;
            this.tabR.Text = "Rot";
            this.tabR.UseVisualStyleBackColor = true;
            // 
            // buttonCancelHistoRed
            // 
            this.buttonCancelHistoRed.AutoSize = true;
            this.buttonCancelHistoRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelHistoRed.Location = new System.Drawing.Point(119, 99);
            this.buttonCancelHistoRed.Name = "buttonCancelHistoRed";
            this.buttonCancelHistoRed.Size = new System.Drawing.Size(127, 35);
            this.buttonCancelHistoRed.TabIndex = 4;
            this.buttonCancelHistoRed.Text = "Abbrechen";
            this.buttonCancelHistoRed.UseVisualStyleBackColor = true;
            this.buttonCancelHistoRed.Visible = false;
            this.buttonCancelHistoRed.Click += new System.EventHandler(this.cancelHistoCalc);
            // 
            // tabG
            // 
            this.tabG.Controls.Add(this.buttonCancelHistoGreen);
            this.tabG.Controls.Add(this.pictureBoxHistoGruen);
            this.tabG.Location = new System.Drawing.Point(4, 22);
            this.tabG.Name = "tabG";
            this.tabG.Padding = new System.Windows.Forms.Padding(3);
            this.tabG.Size = new System.Drawing.Size(276, 154);
            this.tabG.TabIndex = 3;
            this.tabG.Text = "Grün";
            this.tabG.UseVisualStyleBackColor = true;
            // 
            // buttonCancelHistoGreen
            // 
            this.buttonCancelHistoGreen.AutoSize = true;
            this.buttonCancelHistoGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelHistoGreen.Location = new System.Drawing.Point(119, 99);
            this.buttonCancelHistoGreen.Name = "buttonCancelHistoGreen";
            this.buttonCancelHistoGreen.Size = new System.Drawing.Size(127, 35);
            this.buttonCancelHistoGreen.TabIndex = 4;
            this.buttonCancelHistoGreen.Text = "Abbrechen";
            this.buttonCancelHistoGreen.UseVisualStyleBackColor = true;
            this.buttonCancelHistoGreen.Visible = false;
            this.buttonCancelHistoGreen.Click += new System.EventHandler(this.cancelHistoCalc);
            // 
            // tabB
            // 
            this.tabB.Controls.Add(this.buttonCancelHistoBlue);
            this.tabB.Controls.Add(this.pictureBoxHistoBlau);
            this.tabB.Location = new System.Drawing.Point(4, 22);
            this.tabB.Name = "tabB";
            this.tabB.Padding = new System.Windows.Forms.Padding(3);
            this.tabB.Size = new System.Drawing.Size(276, 154);
            this.tabB.TabIndex = 4;
            this.tabB.Text = "Blau";
            this.tabB.UseVisualStyleBackColor = true;
            // 
            // buttonCancelHistoBlue
            // 
            this.buttonCancelHistoBlue.AutoSize = true;
            this.buttonCancelHistoBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelHistoBlue.Location = new System.Drawing.Point(119, 99);
            this.buttonCancelHistoBlue.Name = "buttonCancelHistoBlue";
            this.buttonCancelHistoBlue.Size = new System.Drawing.Size(127, 35);
            this.buttonCancelHistoBlue.TabIndex = 4;
            this.buttonCancelHistoBlue.Text = "Abbrechen";
            this.buttonCancelHistoBlue.UseVisualStyleBackColor = true;
            this.buttonCancelHistoBlue.Visible = false;
            this.buttonCancelHistoBlue.Click += new System.EventHandler(this.cancelHistoCalc);
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
            this.menuStrip2.Size = new System.Drawing.Size(836, 26);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.exportierenToolStripMenuItem,
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
            // exportierenToolStripMenuItem
            // 
            this.exportierenToolStripMenuItem.Name = "exportierenToolStripMenuItem";
            this.exportierenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportierenToolStripMenuItem.Text = "Exportieren";
            this.exportierenToolStripMenuItem.Visible = false;
            this.exportierenToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
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
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drehe90RechtsToolStripMenuItem,
            this.drehe90LinksToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.verkleinernToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // drehe90RechtsToolStripMenuItem
            // 
            this.drehe90RechtsToolStripMenuItem.Name = "drehe90RechtsToolStripMenuItem";
            this.drehe90RechtsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.drehe90RechtsToolStripMenuItem.Text = "Drehe 90° Rechts";
            this.drehe90RechtsToolStripMenuItem.Click += new System.EventHandler(this.rechtsDrehenButton_Click);
            // 
            // drehe90LinksToolStripMenuItem
            // 
            this.drehe90LinksToolStripMenuItem.Name = "drehe90LinksToolStripMenuItem";
            this.drehe90LinksToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.drehe90LinksToolStripMenuItem.Text = "Drehe 90° Links";
            this.drehe90LinksToolStripMenuItem.Click += new System.EventHandler(this.linksDrehenButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Vergrößern";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // verkleinernToolStripMenuItem
            // 
            this.verkleinernToolStripMenuItem.Name = "verkleinernToolStripMenuItem";
            this.verkleinernToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.verkleinernToolStripMenuItem.Text = "Verkleinern";
            this.verkleinernToolStripMenuItem.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // bildOeffnenDialog
            // 
            this.bildOeffnenDialog.FileName = "openFileDialog1";
            this.bildOeffnenDialog.Filter = "Bilder|*.jpg;*.gif;*.tiff";
            // 
            // randUntenPanel
            // 
            this.randUntenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randUntenPanel.Controls.Add(this.statusStrip1);
            this.randUntenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randUntenPanel.Location = new System.Drawing.Point(0, 451);
            this.randUntenPanel.Name = "randUntenPanel";
            this.randUntenPanel.Size = new System.Drawing.Size(858, 25);
            this.randUntenPanel.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelDirectory,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelDirectory
            // 
            this.labelDirectory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Maximum = 10000;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // randRechtsPanel
            // 
            this.randRechtsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randRechtsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.randRechtsPanel.Location = new System.Drawing.Point(848, 0);
            this.randRechtsPanel.Name = "randRechtsPanel";
            this.randRechtsPanel.Size = new System.Drawing.Size(10, 451);
            this.randRechtsPanel.TabIndex = 7;
            // 
            // randLinksPanel
            // 
            this.randLinksPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randLinksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.randLinksPanel.Location = new System.Drawing.Point(0, 0);
            this.randLinksPanel.Name = "randLinksPanel";
            this.randLinksPanel.Size = new System.Drawing.Size(10, 451);
            this.randLinksPanel.TabIndex = 8;
            // 
            // randObenPanel
            // 
            this.randObenPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randObenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randObenPanel.Location = new System.Drawing.Point(10, 0);
            this.randObenPanel.Name = "randObenPanel";
            this.randObenPanel.Size = new System.Drawing.Size(838, 10);
            this.randObenPanel.TabIndex = 9;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.menuePanel);
            this.centerPanel.Controls.Add(this.splitContainer1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(10, 10);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(838, 441);
            this.centerPanel.TabIndex = 10;
            // 
            // menuePanel
            // 
            this.menuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuePanel.Controls.Add(this.menuStrip2);
            this.menuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuePanel.Location = new System.Drawing.Point(0, 0);
            this.menuePanel.Name = "menuePanel";
            this.menuePanel.Size = new System.Drawing.Size(838, 28);
            this.menuePanel.TabIndex = 6;
            // 
            // bildSpeichernDialog
            // 
            this.bildSpeichernDialog.Filter = "JPG|.jpg|PNG|.png|GIF|.gif|TIF|.tif|BMP|.bmp";
            // 
            // grauwertBW
            // 
            this.grauwertBW.WorkerReportsProgress = true;
            this.grauwertBW.WorkerSupportsCancellation = true;
            this.grauwertBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.grauwertBW_DoWork);
            this.grauwertBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.grauwertBW_ProgressChanged);
            this.grauwertBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.grauwertBW_RunWorkerCompleted);
            // 
            // negativBW
            // 
            this.negativBW.WorkerReportsProgress = true;
            this.negativBW.WorkerSupportsCancellation = true;
            this.negativBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.negativBW_DoWork);
            this.negativBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.negativBW_ProgressChanged);
            this.negativBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.negativBW_RunWorkerCompleted);
            // 
            // sepiaBackWorker
            // 
            this.sepiaBackWorker.WorkerReportsProgress = true;
            this.sepiaBackWorker.WorkerSupportsCancellation = true;
            this.sepiaBackWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sepiaBackWorker_DoWork);
            this.sepiaBackWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.sepiaBackWorker_ProgressChanged);
            this.sepiaBackWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.sepiaBackWorker_RunWorkerCompleted);
            // 
            // bildPicturebox
            // 
            this.bildPicturebox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bildPicturebox.Location = new System.Drawing.Point(5, 31);
            this.bildPicturebox.Name = "bildPicturebox";
            this.bildPicturebox.Size = new System.Drawing.Size(541, 379);
            this.bildPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bildPicturebox.TabIndex = 0;
            this.bildPicturebox.TabStop = false;
            this.bildPicturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.bildPictureBox_Paint);
            this.bildPicturebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseClick);
            this.bildPicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseDown);
            this.bildPicturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bildPicturebox_MouseMove);
            this.bildPicturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bildPictureBox_MouseUp);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxColor.Location = new System.Drawing.Point(97, 9);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(100, 54);
            this.pictureBoxColor.TabIndex = 19;
            this.pictureBoxColor.TabStop = false;
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.filterCheckBox.Image = global::Prog3.Properties.Resources.pfeil_rechts2;
            this.filterCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterCheckBox.Location = new System.Drawing.Point(3, 121);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(256, 24);
            this.filterCheckBox.TabIndex = 11;
            this.filterCheckBox.Text = "      Filter";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
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
            this.korrekturenCheckBox.Image = global::Prog3.Properties.Resources.pfeil_rechts2;
            this.korrekturenCheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.korrekturenCheckBox.Location = new System.Drawing.Point(3, 31);
            this.korrekturenCheckBox.Name = "korrekturenCheckBox";
            this.korrekturenCheckBox.Size = new System.Drawing.Size(256, 24);
            this.korrekturenCheckBox.TabIndex = 9;
            this.korrekturenCheckBox.Text = "      Korrekturen";
            this.korrekturenCheckBox.UseVisualStyleBackColor = true;
            this.korrekturenCheckBox.CheckedChanged += new System.EventHandler(this.korrekturenCheckBox_CheckedChanged);
            // 
            // werkzeugeCheckBox
            // 
            this.werkzeugeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.werkzeugeCheckBox.Image = global::Prog3.Properties.Resources.pfeil_rechts2;
            this.werkzeugeCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.werkzeugeCheckBox.Location = new System.Drawing.Point(3, 61);
            this.werkzeugeCheckBox.Name = "werkzeugeCheckBox";
            this.werkzeugeCheckBox.Size = new System.Drawing.Size(256, 24);
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
            this.ansichtCheckBox.Size = new System.Drawing.Size(256, 24);
            this.ansichtCheckBox.TabIndex = 7;
            this.ansichtCheckBox.Text = "      Ansicht";
            this.ansichtCheckBox.UseVisualStyleBackColor = true;
            this.ansichtCheckBox.CheckedChanged += new System.EventHandler(this.ansichtCheckBox_CheckedChanged);
            // 
            // beschneidenCheckBox
            // 
            this.beschneidenCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.beschneidenCheckBox.BackgroundImage = global::Prog3.Properties.Resources.crop1;
            this.beschneidenCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beschneidenCheckBox.Location = new System.Drawing.Point(75, 10);
            this.beschneidenCheckBox.Name = "beschneidenCheckBox";
            this.beschneidenCheckBox.Size = new System.Drawing.Size(32, 30);
            this.beschneidenCheckBox.TabIndex = 6;
            this.beschneidenCheckBox.UseVisualStyleBackColor = true;
            this.beschneidenCheckBox.CheckedChanged += new System.EventHandler(this.beschneidenCheckBox_CheckedChanged);
            // 
            // skalierenButton
            // 
            this.skalierenButton.BackgroundImage = global::Prog3.Properties.Resources.ScaleIcon;
            this.skalierenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skalierenButton.Location = new System.Drawing.Point(113, 10);
            this.skalierenButton.Name = "skalierenButton";
            this.skalierenButton.Size = new System.Drawing.Size(32, 30);
            this.skalierenButton.TabIndex = 5;
            this.skalierenButton.UseVisualStyleBackColor = true;
            this.skalierenButton.Click += new System.EventHandler(this.skalierenButton_Click_1);
            // 
            // handCheckBox
            // 
            this.handCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.handCheckBox.BackgroundImage = global::Prog3.Properties.Resources.move_1;
            this.handCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.handCheckBox.Location = new System.Drawing.Point(3, 10);
            this.handCheckBox.Name = "handCheckBox";
            this.handCheckBox.Size = new System.Drawing.Size(30, 30);
            this.handCheckBox.TabIndex = 3;
            this.handCheckBox.UseVisualStyleBackColor = true;
            this.handCheckBox.CheckedChanged += new System.EventHandler(this.handCheckBox_CheckedChanged);
            // 
            // colorPickerCheckBox
            // 
            this.colorPickerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorPickerCheckBox.BackgroundImage = global::Prog3.Properties.Resources.color_picker;
            this.colorPickerCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colorPickerCheckBox.Location = new System.Drawing.Point(39, 10);
            this.colorPickerCheckBox.Name = "colorPickerCheckBox";
            this.colorPickerCheckBox.Size = new System.Drawing.Size(30, 30);
            this.colorPickerCheckBox.TabIndex = 2;
            this.colorPickerCheckBox.UseVisualStyleBackColor = true;
            this.colorPickerCheckBox.CheckedChanged += new System.EventHandler(this.colorPickerCheckBox_CheckedChanged);
            // 
            // pictureBoxHistoGrau
            // 
            this.pictureBoxHistoGrau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxHistoGrau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistoGrau.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHistoGrau.Name = "pictureBoxHistoGrau";
            this.pictureBoxHistoGrau.Size = new System.Drawing.Size(270, 148);
            this.pictureBoxHistoGrau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistoGrau.TabIndex = 0;
            this.pictureBoxHistoGrau.TabStop = false;
            // 
            // pictureBoxHistoRGB
            // 
            this.pictureBoxHistoRGB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxHistoRGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistoRGB.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHistoRGB.Name = "pictureBoxHistoRGB";
            this.pictureBoxHistoRGB.Size = new System.Drawing.Size(270, 148);
            this.pictureBoxHistoRGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistoRGB.TabIndex = 0;
            this.pictureBoxHistoRGB.TabStop = false;
            // 
            // pictureBoxHistoRed
            // 
            this.pictureBoxHistoRed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxHistoRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistoRed.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHistoRed.Name = "pictureBoxHistoRed";
            this.pictureBoxHistoRed.Size = new System.Drawing.Size(270, 148);
            this.pictureBoxHistoRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistoRed.TabIndex = 0;
            this.pictureBoxHistoRed.TabStop = false;
            // 
            // pictureBoxHistoGruen
            // 
            this.pictureBoxHistoGruen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxHistoGruen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistoGruen.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHistoGruen.Name = "pictureBoxHistoGruen";
            this.pictureBoxHistoGruen.Size = new System.Drawing.Size(270, 148);
            this.pictureBoxHistoGruen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistoGruen.TabIndex = 0;
            this.pictureBoxHistoGruen.TabStop = false;
            // 
            // pictureBoxHistoBlau
            // 
            this.pictureBoxHistoBlau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxHistoBlau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistoBlau.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHistoBlau.Name = "pictureBoxHistoBlau";
            this.pictureBoxHistoBlau.Size = new System.Drawing.Size(270, 148);
            this.pictureBoxHistoBlau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistoBlau.TabIndex = 0;
            this.pictureBoxHistoBlau.TabStop = false;
            // 
            // _hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 476);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.randObenPanel);
            this.Controls.Add(this.randLinksPanel);
            this.Controls.Add(this.randRechtsPanel);
            this.Controls.Add(this.randUntenPanel);
            this.Name = "_hauptfenster";
            this.Text = "Photoshop für Arme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.linkerContainer.Panel1.ResumeLayout(false);
            this.linkerContainer.Panel2.ResumeLayout(false);
            this.linkerContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkerContainer)).EndInit();
            this.linkerContainer.ResumeLayout(false);
            this.rechterContainer.Panel1.ResumeLayout(false);
            this.rechterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rechterContainer)).EndInit();
            this.rechterContainer.ResumeLayout(false);
            this.FilterPanel.ResumeLayout(false);
            this.ansichtPanel.ResumeLayout(false);
            this.werkzeugPanel.ResumeLayout(false);
            this.korrekturenPanel.ResumeLayout(false);
            this.tabControllHistogramme.ResumeLayout(false);
            this.tabGrau.ResumeLayout(false);
            this.tabGrau.PerformLayout();
            this.tabRGB.ResumeLayout(false);
            this.tabRGB.PerformLayout();
            this.tabR.ResumeLayout(false);
            this.tabR.PerformLayout();
            this.tabG.ResumeLayout(false);
            this.tabG.PerformLayout();
            this.tabB.ResumeLayout(false);
            this.tabB.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.randUntenPanel.ResumeLayout(false);
            this.randUntenPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            this.menuePanel.ResumeLayout(false);
            this.menuePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bildPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoGrau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoGruen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoBlau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer linkerContainer;
        private System.Windows.Forms.SplitContainer rechterContainer;
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
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.Panel werkzeugPanel;
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
        private System.Windows.Forms.Button greyValButton;
        private System.Windows.Forms.Button invertedButton;
        private System.Windows.Forms.CheckBox ansichtCheckBox;
        private System.Windows.Forms.CheckBox werkzeugeCheckBox;
        private System.Windows.Forms.CheckBox korrekturenCheckBox;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.ProgressBar form1ProgressBar;
        private System.Windows.Forms.Button progressBarAbbrechenButton;
        private System.Windows.Forms.CheckBox colorPickerCheckBox;
        private System.Windows.Forms.CheckBox handCheckBox;
        private System.Windows.Forms.Button saettigungButton;
        private System.Windows.Forms.Button helligkeitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelDirectory;
        private System.Windows.Forms.ToolStripMenuItem drehe90RechtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drehe90LinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verkleinernToolStripMenuItem;
        private System.Windows.Forms.Button sepiaButton;
        public System.Windows.Forms.TabPage tabGrau;
        public System.Windows.Forms.TabControl tabControllHistogramme;
        public System.Windows.Forms.TabPage tabRGB;
        public System.Windows.Forms.TabPage tabR;
        public System.Windows.Forms.TabPage tabG;
        public System.Windows.Forms.TabPage tabB;
        public System.Windows.Forms.PictureBox bildPicturebox;
        public System.ComponentModel.BackgroundWorker grauwertBW;
        public System.ComponentModel.BackgroundWorker negativBW;
        public System.Windows.Forms.PictureBox pictureBoxHistoGrau;
        public System.Windows.Forms.PictureBox pictureBoxHistoRGB;
        public System.Windows.Forms.PictureBox pictureBoxHistoRed;
        public System.Windows.Forms.PictureBox pictureBoxHistoGruen;
        public System.Windows.Forms.PictureBox pictureBoxHistoBlau;
        public System.Windows.Forms.Button buttonCancelHistGray;
        public System.Windows.Forms.Button buttonCancelHistRGB;
        public System.Windows.Forms.Button buttonCancelHistoRed;
        public System.Windows.Forms.Button buttonCancelHistoGreen;
        public System.Windows.Forms.Button buttonCancelHistoBlue;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        public System.Windows.Forms.ToolStripMenuItem rückgängigToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem wiederholenToolStripMenuItem;
        private System.Windows.Forms.Button blackWhiteButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelBr;
        private System.Windows.Forms.Label labelTextBr;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelTextS;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelTextH;
        private System.Windows.Forms.Button buttonExif;
        private System.ComponentModel.BackgroundWorker sepiaBackWorker;
        private System.Windows.Forms.Button skalierenButton;
        private System.Windows.Forms.ToolStripMenuItem exportierenToolStripMenuItem;
        private System.Windows.Forms.CheckBox beschneidenCheckBox;
        private System.Windows.Forms.Button weissabgleichButton;
        private System.Windows.Forms.PictureBox pictureBoxColor;


    }
}

