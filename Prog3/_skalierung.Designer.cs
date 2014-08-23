namespace Prog3
{
    partial class _skalierung
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.origHöheLabel = new System.Windows.Forms.Label();
            this.origBreiteLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.anwendenButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxSkaliert = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.checkBoxSeitenverhaeltnis = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkaliert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breite";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxOriginal);
            this.groupBox1.Controls.Add(this.origHöheLabel);
            this.groupBox1.Controls.Add(this.origBreiteLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original";
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(9, 76);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(345, 278);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 4;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // origHöheLabel
            // 
            this.origHöheLabel.AutoSize = true;
            this.origHöheLabel.Location = new System.Drawing.Point(59, 49);
            this.origHöheLabel.Name = "origHöheLabel";
            this.origHöheLabel.Size = new System.Drawing.Size(35, 13);
            this.origHöheLabel.TabIndex = 3;
            this.origHöheLabel.Text = "label4";
            // 
            // origBreiteLabel
            // 
            this.origBreiteLabel.AutoSize = true;
            this.origBreiteLabel.Location = new System.Drawing.Point(59, 25);
            this.origBreiteLabel.Name = "origBreiteLabel";
            this.origBreiteLabel.Size = new System.Drawing.Size(35, 13);
            this.origBreiteLabel.TabIndex = 2;
            this.origBreiteLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höhe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSeitenverhaeltnis);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.anwendenButton);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.pictureBoxSkaliert);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 360);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skalieren auf";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // anwendenButton
            // 
            this.anwendenButton.Location = new System.Drawing.Point(279, 44);
            this.anwendenButton.Name = "anwendenButton";
            this.anwendenButton.Size = new System.Drawing.Size(75, 23);
            this.anwendenButton.TabIndex = 12;
            this.anwendenButton.Text = "Anwenden";
            this.anwendenButton.UseVisualStyleBackColor = true;
            this.anwendenButton.Click += new System.EventHandler(this.anwendenButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // pictureBoxSkaliert
            // 
            this.pictureBoxSkaliert.Location = new System.Drawing.Point(9, 76);
            this.pictureBoxSkaliert.Name = "pictureBoxSkaliert";
            this.pictureBoxSkaliert.Size = new System.Drawing.Size(345, 278);
            this.pictureBoxSkaliert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSkaliert.TabIndex = 9;
            this.pictureBoxSkaliert.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Höhe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Breite";
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.Location = new System.Drawing.Point(561, 378);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.abbrechenButton.TabIndex = 11;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            this.abbrechenButton.Click += new System.EventHandler(this.abbrechenButton_Click);
            // 
            // speichernButton
            // 
            this.speichernButton.Location = new System.Drawing.Point(663, 378);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(75, 23);
            this.speichernButton.TabIndex = 10;
            this.speichernButton.Text = "Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // checkBoxSeitenverhaeltnis
            // 
            this.checkBoxSeitenverhaeltnis.AutoSize = true;
            this.checkBoxSeitenverhaeltnis.Location = new System.Drawing.Point(186, 21);
            this.checkBoxSeitenverhaeltnis.Name = "checkBoxSeitenverhaeltnis";
            this.checkBoxSeitenverhaeltnis.Size = new System.Drawing.Size(168, 17);
            this.checkBoxSeitenverhaeltnis.TabIndex = 13;
            this.checkBoxSeitenverhaeltnis.Text = "Seitenverhätnisse beibehalten";
            this.checkBoxSeitenverhaeltnis.UseVisualStyleBackColor = true;
            // 
            // _skalierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 408);
            this.Controls.Add(this.abbrechenButton);
            this.Controls.Add(this.speichernButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "_skalierung";
            this.Text = "Skalieren";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._skalierung_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkaliert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Label origHöheLabel;
        private System.Windows.Forms.Label origBreiteLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBoxSkaliert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button anwendenButton;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.CheckBox checkBoxSeitenverhaeltnis;
    }
}