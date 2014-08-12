﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class _hauptfenster : Form
    {
    //---------------------------------------------------------------------------------------------------
    //Konstruktor
        public _hauptfenster()
        {
            InitializeComponent();
            schrittspeicher = new _schrittspeicher(this);
            schrittspeicher.speicherAnlegen();

            //Accordion Menu
            initializeAccordionMenu();

            //Werkzeuge
            initialisiereTools();

            //Histogrammklasse
            histogramme = new _Histogramm(this);
            
            //Picturebox ordentlich anordnen
            bildPicturebox.Left = linkerContainer.Panel1.Left + 10;
            bildPicturebox.Top = linkerContainer.Panel1.Top + 35;
            bildPicturebox.Width = linkerContainer.Panel1.Width - 30;
            bildPicturebox.Height = linkerContainer.Panel1.Height - 55;

            //Tooltips festlegen
            toolTip.SetToolTip(korrekturenCheckBox, "Korrekturen anzeigen");
            toolTip.SetToolTip(werkzeugeCheckBox, "Werkzeuge anzeigen");
            toolTip.SetToolTip(ansichtCheckBox, "Optionen zur Ansicht des Bildes anzeigen");
            toolTip.SetToolTip(filterCheckBox, "Filter anzeigen");
            toolTip.SetToolTip(colorPickerCheckBox, "Color-Picker");
            toolTip.SetToolTip(handCheckBox, "Bild bewegen");
            toolTip.SetToolTip(zoomInButton, "Hereinzoomen");
            toolTip.SetToolTip(zoomOutButton, "Herauszoomen");
            toolTip.SetToolTip(linksDrehenButton, "Bild um 90° nach links drehen");
            toolTip.SetToolTip(rechtsDrehenButton, "Bild um 90° nach rechts drehen");
            toolTip.SetToolTip(button2, "Kontrast des Bildes verändern");
            toolTip.SetToolTip(saettigungButton, "Sättigung des Bildes verändern");
            toolTip.SetToolTip(helligkeitButton, "Helligkeit des Bildes verändern");
            toolTip.SetToolTip(greyValButton, "Aus dem geöffneten Bild ein Grauwertbild erstellen");
            toolTip.SetToolTip(blackWhiteButton, "Aus dem geöffneten Bild ein Schwarz-Weiß-Bild erstellen");
            toolTip.SetToolTip(invertedButton, "Aus dem geöffneten Bild ein Negativbild erstellen");
            toolTip.SetToolTip(sepiaButton, "Aus dem geöffneten Bild ein Sepiabild erstellen");
            toolTip.SetToolTip(tabControllHistogramme, "Histogramme erstellen und anzeigen");


            //Backgroundworker
            threadsInitialisieren();
        }

    //----------------------------------------------------------------------------------------------------
    //Globale Variablen

        //speichervorgang
        string speichernUnter;

        //bewegung der picturebox mit dem hand tool
        int xMouseMove;
        int yMouseMove;
        
        //Accordion Menu
        List<CheckBox> checkboxes;
        List<Panel> panels;

        //Backgroundworker
        List<BackgroundWorker> backWorkers;

        //Werkzeuge
        List<CheckBox> werkzeuge;

        //Metadaten
        string picDir;
        
        //Semaphore
        public Semaphore sem = new Semaphore(1, 1);

        //Histogramme
        public _Histogramm histogramme;

        //Schrittspeicher
        _schrittspeicher schrittspeicher;

    //----------------------------------------------------------------------------------------------------
    //MenuStrip
        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            threadsBeenden();

            //Dialog anzeigen
            DialogResult rs = bildOeffnenDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                //extrahiert die Endung des geöffneten Files
                string ext = Path.GetExtension(bildOeffnenDialog.FileName);
                //sortiert die NICHT Bildformate aus
                if (ext == ".jpg" || ext == ".JPG" || ext == ".jpeg" || ext == ".png" || ext == ".gif" || ext == ".tif" || ext == ".bmp")
                {
                    aufraeumen();

                    //bild laden, picturebox ausrichten, geladenes bild als zwischenschritt speichern
                    bildPicturebox.Image = Image.FromFile(bildOeffnenDialog.FileName);
                    bildPicturebox.Top = 0;
                    bildPicturebox.Left = 0;

                    schrittspeicher.schrittSpeichern((Bitmap)bildPicturebox.Image);

                    //Speicherort merken
                    picDir = bildOeffnenDialog.FileName;

                    speichernUnterToolStripMenuItem.Visible = true;
                    schließenToolStripMenuItem.Visible = true;

                    //rückgängig und wiederholen ausblenden
                    rückgängigToolStripMenuItem.Visible = false;
                    wiederholenToolStripMenuItem.Visible = false;

                    toolStripProgressBar.Maximum = bildPicturebox.Image.Width;
                    toolStripProgressBar.Value = 0;

                    getPicMeta();
                }                
            }
        }
        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aufraeumen();
        }
        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            aufraeumen();
        }
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sem.WaitOne(1000))
            {
                //um auf nummer sicher zu gehen
                Thread.Sleep(1000);

                //um an diese Funktion zu kommen, muss der Benutzer vorher die "Speichern unter" Funktion aufgerufen haben
                string ext = Path.GetExtension(bildOeffnenDialog.FileName);
                if (ext == ".jpg" || ext == ".jpeg")
                {
                    bildPicturebox.Image.Save(speichernUnter, ImageFormat.Jpeg);
                }
                else if (ext == ".png")
                {
                    bildPicturebox.Image.Save(speichernUnter, ImageFormat.Png);
                }
                else if (ext == ".gif")
                {
                    bildPicturebox.Image.Save(speichernUnter, ImageFormat.Gif);
                }
                else if (ext == ".tif" || ext == ".tiff")
                {
                    bildPicturebox.Image.Save(speichernUnter, ImageFormat.Tiff);
                }
                else if (ext == ".bmp")
                {
                    bildPicturebox.Image.Save(speichernUnter, ImageFormat.Bmp);
                }

                //Kritischen Bereich verlassen
                sem.Release();
            }
            else
            {
                MessageBox.Show("Bild kann nicht gespeichert werden, es wird noch bearbeitet");
            }
        }
        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sem.WaitOne(1000))
            {
                //speichern Dialog anzeigen
                DialogResult rs = bildSpeichernDialog.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    //falls kein Bild geöffnet wurde
                    if (bildPicturebox.Image == null)
                    {
                        MessageBox.Show("Es gibt nichts zu speichern");
                    }
                    //ansonsten als gewünschtes Format speichern
                    //Formate: jpeg, png, gif, tif, bmp
                    else
                    {
                        //speichern wird ab jetzt aktiviert, dies speichert unter dem hier angegeben namen
                        speichernToolStripMenuItem.Visible = true;
                        speichernUnter = bildSpeichernDialog.FileName;

                        string ext = Path.GetExtension(speichernUnter);
                        if (ext == ".jpg" || ext == ".jpeg")
                        {
                            bildPicturebox.Image.Save(speichernUnter, ImageFormat.Jpeg);
                        }
                        else if (ext == ".png")
                        {
                            bildPicturebox.Image.Save(speichernUnter, ImageFormat.Png);
                        }
                        else if (ext == ".gif")
                        {
                            bildPicturebox.Image.Save(speichernUnter, ImageFormat.Gif);
                        }
                        else if (ext == ".tif" || ext == ".tiff")
                        {
                            bildPicturebox.Image.Save(speichernUnter, ImageFormat.Tiff);
                        }
                        else if (ext == ".bmp")
                        {
                            bildPicturebox.Image.Save(speichernUnter, ImageFormat.Bmp);
                        }
                    }
                }
                //Kritischen Bereich verlassen
                sem.Release();
            }
            else
            {
                MessageBox.Show("Bild kann nicht gespeichert werden, es wird gerade bearbeitet");
            }
        }
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aufraeumen();
        }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aufraeumen();
            this.Close();
        }
        private void rückgängigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schrittspeicher.schrittZurueck();
        }
        private void wiederholenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schrittspeicher.schrittVor();
        }
        
    //----------------------------------------------------------------------------------------------------
    //aufräumen
        private void aufraeumen()
        {
            //Threads beenden
            threadsBeenden();

            bildPicturebox.Image = null;

            //Histogramme aufräumen
            histogramme.clearAllHistos();

            //datei
            speichernUnterToolStripMenuItem.Visible = false;
            speichernToolStripMenuItem.Visible = false;
            schließenToolStripMenuItem.Visible = false;

            //bearbeiten
            rückgängigToolStripMenuItem.Visible = false;
            wiederholenToolStripMenuItem.Visible = false;

            schrittspeicher.speicherlöschen();

            GC.Collect();
        }

    //----------------------------------------------------------------------------------------------------
    //get und set funktionen
        public void setAndSavePictureBox(Bitmap bitmap_in)
        {
            schrittspeicher.schrittSpeichern(bitmap_in);
            Debug.WriteLine("setAndSavePictureBox()");
            bildPicturebox.Image = bitmap_in;            
        }
        public Bitmap getPictureBoxImage()
        {
            return (Bitmap)bildPicturebox.Image;
        }
        public void lockMainWindow()
        {
            centerPanel.Enabled = false;
        }
        public void unlockMainWindow()
        {
            centerPanel.Enabled = true;
        }

    //----------------------------------------------------------------------------------------------------
    //Korrekturen
        private void kontrastButton_Click(object sender, EventArgs e)
        {
            //Kritischen Bereich betreten
            if (sem.WaitOne(1000))
            {
                //ganze form sperren
                lockMainWindow();

                //um auf nummer sicher zu gehen
                Thread.Sleep(1000);

                //neue Form öffnen
                kontrast neu = new kontrast(this, sem);
                neu.Show();
            }
            else
            {
                MessageBox.Show("Bild wird gerade bearbeitet");
            }
        }
        private void helligkeitButton_Click(object sender, EventArgs e)
        {
            //Kritischen Bereich betreten
            if (sem.WaitOne(1000))
            {
                //hauptfenster sperren
                lockMainWindow();

                //um auf nummer sicher zu gehen
                Thread.Sleep(1000);

                //neue Form öffnen
                helligkeit hell = new helligkeit(this,sem);
                hell.Show();
            }
            else
            {
                MessageBox.Show("Bild wird gerade bearbeitet");
            }
        }
        private void saettigungButton_Click(object sender, EventArgs e)
        {
            //Kritischen Bereich betreten
            if (sem.WaitOne(1000))
            {
                //ganze form sperren
                lockMainWindow();

                //um auf nummer sicher zu gehen
                Thread.Sleep(1000);

                //neue Form öffnen
                saettigung saet = new saettigung(getPictureBoxImage(), this, sem);
            }
            else
            {
                MessageBox.Show("Bild wird gerade bearbeitet");
            }
        }

    //----------------------------------------------------------------------------------------------------
    //Filter     

        //Korrekturen abbrechen
        private void abbrechenButton_CLick(object sender, EventArgs e)
        {
            threadsBeenden();
        }

        //Progress Bar und Abbrechen Button positionieren
        private void positioniereProgressBarPictureBox()
        {
            form1ProgressBar.Top = linkerContainer.Panel1.Height / 2;
            form1ProgressBar.Left = (linkerContainer.Width - form1ProgressBar.Width) / 2;

            progressBarAbbrechenButton.Top = linkerContainer.Panel1.Height / 2 + form1ProgressBar.Height;
            progressBarAbbrechenButton.Left = (linkerContainer.Width - progressBarAbbrechenButton.Width) / 2;
        }

        //GrauwertBild
        private void greyValButton_Click(object sender, EventArgs e)
        {
                //wenn ein Bild in der PictureBox ist, fang an zu rechnen
            if (bildPicturebox.Image != null)
            {
                threadsBeenden();

                positioniereProgressBarPictureBox();
                greyValButton.Enabled = false;


                if (sender.ToString().Contains("Grauwert"))
                {
                    //startet die Berechnung in einem neuen Thread
                    grauwertBW.RunWorkerAsync("grau");
                }
                else
                    grauwertBW.RunWorkerAsync("schwarz");
            }
            else
            {
                MessageBox.Show("Kein Bild zum Bearbeiten vorhanden");
            }
        }
        private void grauwertBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //da man hier in einem anderen Thread arbeitet, ist dieser Schritt von Nöten um Zugriff
            //auf die Variablen der hauptfenster zu haben
            form1ProgressBar.Invoke(new Action(() => form1ProgressBar.Visible = false));

            //abbrechen Button verschwinden lassen
            progressBarAbbrechenButton.Invoke(new Action(() => progressBarAbbrechenButton.Visible = false));

            //Grauwert Button wieder benutzbar machen
            greyValButton.Invoke(new Action(() => greyValButton.Enabled = true));

            Debug.WriteLine("Grauwert BW Arbeit beendet");
           
            //Verlasse den kritischen Bereich
            sem.Release();
        }
        private void grauwertBW_DoWork(object sender, DoWorkEventArgs e)
        {
            //Betrete den geschützten Bereich
            sem.WaitOne();

            string eingabe = e.Argument.ToString();

            Debug.WriteLine("Grauwert BW starten");

            //um auf nummer sicher zu gehen
            Thread.Sleep(1000);

            progressBarAbbrechenButton.Invoke(new Action(() => progressBarAbbrechenButton.Visible = true));

            //berechne das Grauwertbild            
            createGreyValPic(eingabe);
        }
        private void grauwertBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (grauwertBW.CancellationPending)
                return;

            //da man hier in einem anderen Thread arbeitet, ist dieser Schritt von Nöten um Zugriff
            //auf die Variablen der hauptfenster zu haben
            form1ProgressBar.Invoke(new Action(() =>
            {
                form1ProgressBar.Value = e.ProgressPercentage;
            }));
        }
        public void createGreyValPic(string eingabe_in)
        {
            Color oldColor, greyColor;
            Bitmap helpMap, greyMap;
            int width, height, i, j = 0, greyValue;

            //neue Instanz anlegen, sonst bekommt man eine Zugriffsverletzung
            helpMap = new Bitmap(bildPicturebox.Image);

            width = helpMap.Width;      //Bildbreite bestimmen
            height = helpMap.Height;    //Bildhöhe bestimmen
            greyMap = new Bitmap(width, height);        //Bitmap für das Grauwertbild erstellen

            form1ProgressBar.Invoke(new Action(() =>
            {
                form1ProgressBar.Maximum = height;
                form1ProgressBar.Visible = true;
                form1ProgressBar.Value = 0;
            }));

            while (j < height)      //Schleife zum durchlaufen der Bitmap in der  Breite
            {
                for (i = 0; i < width; i++)     //Schleife zum durchlaufen der Bitmap in der Höhe
                {
                    oldColor = helpMap.GetPixel(i, j);      //Farbwert bestimmen
                    greyValue = (int)(0.3 * oldColor.R + 0.6 * oldColor.G + 0.1 * oldColor.B);     //Grauwert berechnen
                    greyColor = Color.FromArgb(greyValue, greyValue, greyValue);        //Colorvariable aus Grauwert erzeugen
                    greyMap.SetPixel(i, j, greyColor);      //Farbe(Grau) setzen
                }
                j++;        //Laufvariable inkrementieren
                
                //falls die bearbeitung abgebrochen wird
                if (grauwertBW.CancellationPending)
                    return;

                grauwertBW.ReportProgress(j);
            }

            //Berechnung des Schwarz-Weiß Bildes
            if (eingabe_in != "grau")
            {
                Graphics gr = Graphics.FromImage(greyMap);
                var ia = new System.Drawing.Imaging.ImageAttributes();
                ia.SetThreshold(0.5f); // Change this threshold as needed
                var rc = new Rectangle(0, 0, width, height);
                gr.DrawImage(greyMap, rc, 0, 0, width, height, GraphicsUnit.Pixel, ia);
            }

            GC.Collect();

            if (grauwertBW.CancellationPending)
                return;

            bildPicturebox.Invoke(new Action(() =>
            {
                setAndSavePictureBox(greyMap);
            }));
        }

        //Negativ
        private void negativBW_DoWork(object sender, DoWorkEventArgs e)
        {
            //Kritischen Bereich betreten
            sem.WaitOne();

            Debug.WriteLine("Negativ BW starten");

            //nur um auf nummer sicher zu gehen
            Thread.Sleep(1000);

            progressBarAbbrechenButton.Invoke(new Action(() => progressBarAbbrechenButton.Visible = true));

            //negativ berechnen
            createInvertedPic();
        }
        private void negativBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (negativBW.CancellationPending)
                return;

            //Fortschritt in er Progress Bar anzeigen
            form1ProgressBar.Invoke(new Action(() => form1ProgressBar.Value = e.ProgressPercentage));
        }
        private void negativBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //progress bar verschwinden lassen
            form1ProgressBar.Invoke(new Action(() => form1ProgressBar.Visible = false));
            //abbrechen button verschwinden lassen
            progressBarAbbrechenButton.Invoke(new Action(() => progressBarAbbrechenButton.Visible = false));

            //Negativ Checkbox wieder benutzbar machen
            invertedButton.Enabled = true;

            Debug.WriteLine("Negativ BW Arbeit beendet");

            //Kritischen Bereich verlassen
            sem.Release();
        }
        private void invertedButton_Click(object sender, EventArgs e)
        {
            if (bildPicturebox.Image != null)
            {
                threadsBeenden();

                positioniereProgressBarPictureBox();
                invertedButton.Enabled = false;
                
                negativBW.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Kein Bild zum Bearbeiten vorhanden");
            }
        }
        private void createInvertedPic()
        {
            Color origColor, invertedColor;
            Bitmap origMap, invertedMap;
            int r, g, b, width, height, i, j = 0;

            //Hier muss ein neues Objekt angelegt werde, ansonsten bekommt man eine Zugriffsverletzung
            origMap = new Bitmap(bildPicturebox.Image);

            width = origMap.Width;      //Bildbreite bestimmen
            height = origMap.Height;    //Bildhöhe bestimmen

            invertedMap = new Bitmap(width, height);    //Bitmap für das invertierte Bild erstellen
            form1ProgressBar.Invoke(new Action(() =>
            {
                form1ProgressBar.Visible = true;
                form1ProgressBar.Value = 0;
                form1ProgressBar.Maximum = height;
            }));


            while (j < height)      //Schleife zum durchlaufen der Bitmap in der  Breite
            {
                for (i = 0; i < width; i++)     //Schleife zum durchlaufen der Bitmap in der Höhe
                {
                    origColor = origMap.GetPixel(i, j);      //Farbwert bestimmen
                    r = 255 - origColor.R;       //Farbwerte invertieren
                    g = 255 - origColor.G;       //
                    b = 255 - origColor.B;       //
                    invertedColor = Color.FromArgb(r, g, b);        //Colorvariable aus invertierten Farbwerten erstellen
                    invertedMap.SetPixel(i, j, invertedColor);      //Farbe setzen
                }
                j++;        //Laufvariable inkrementieren
                negativBW.ReportProgress(j);
                if (negativBW.CancellationPending)
                    return;
            }
            
            if (negativBW.CancellationPending)
                return;

            bildPicturebox.Invoke(new Action(() =>
            {
                setAndSavePictureBox(invertedMap);
            }));
        }

        //Sepia
        private void sepiaButton_Click(object sender, EventArgs e)
        {

        }

    //----------------------------------------------------------------------------------------------------
    //Threads
        private void threadsInitialisieren()
        {
            backWorkers = new List<BackgroundWorker> { negativBW, grauwertBW, histogramme.BwHisto };
        }
        private void threadsBeenden()
        {
            foreach (BackgroundWorker b in backWorkers)
            {
                if (b.IsBusy)
                    b.CancelAsync();
            }
        }         

    //----------------------------------------------------------------------------------------------------
    //Werkzeuge
        private void initialisiereTools()
        {
            werkzeuge = new List<CheckBox> { handCheckBox, colorPickerCheckBox };
        }
        private void lockTools(CheckBox selbst)
        {
            foreach (CheckBox c in werkzeuge)
            {
                if (!c.Equals(selbst))
                    c.Enabled = false;
            }
        }
        private void unlockTools(CheckBox selbst)
        {
            foreach (CheckBox c in werkzeuge)
            {
                if (!c.Equals(selbst))
                    c.Enabled = true;
            }
        }
        private bool checkTools(CheckBox selbst)
        {
            foreach (CheckBox c in werkzeuge)
            {
                if (c.Checked && !c.Equals(selbst))
                    return false;
            }
            return true;
        }

        //------------------------------------------------------------------------------------------------
        //Hand Tool
        private void handCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (handCheckBox.Checked)
            {
                if (checkTools(handCheckBox))   //wenn kein anderes tool aktiv
                {
                    //einfach so stehen lasse, die Funktionen "bildPicturebox_MouseMove" und 
                    //"bildPicturebox_MouseDown" arbeiten damit weiter

                    Cursor = Cursors.Hand;
                    lockTools(handCheckBox);
                }
                else
                {
                    handCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                if (checkTools(handCheckBox))
                {
                    unlockTools(handCheckBox);
                    Cursor = Cursors.Default;
                }
            }
        }
            
        //------------------------------------------------------------------------------------------------
        //Color Picker
        private void colorPickerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (colorPickerCheckBox.Checked)
            {
                if (checkTools(colorPickerCheckBox))   //wenn kein anderes tool aktiv
                {
                    //einfach so stehen lasse, die Funktionen "bildPicturebox_MouseMove" und 
                    //"bildPicturebox_MouseDown" arbeiten damit weiter

                    Cursor = Cursors.Cross;
                    lockTools(colorPickerCheckBox);
                }
                else
                {
                    colorPickerCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                if (checkTools(colorPickerCheckBox))
                {
                    unlockTools(colorPickerCheckBox);
                    Cursor = Cursors.Default;
                }
            }
        }
            private void getPixelColor(MouseEventArgs e, PictureBox picBox)
            {       //Funktion zum berechnen des Farbwerts einzelner Pixel
                Bitmap helpMap = new Bitmap(1, 1);
                Point picPos;
                Color pixelColor = new Color();
                try
                {
                    helpMap = new Bitmap(picBox.Image);     //Bitmap aus Bild in Picturebox erstellen
                    picPos = TranslateZoomMousePosition(new Point(e.X, e.Y), picBox);       //Position der Maus über dem Bild bestimmen
                    pixelColor = helpMap.GetPixel(picPos.X, picPos.Y);      //Pixelfarbe bestimmen
                }
                catch
                {
                    if (helpMap.Size == new Size(1, 1))
                    {
                        MessageBox.Show("Um die Farbe eines Pixels zu bestimmen muss ein Bild geöffnet sein.");
                    }
                    else
                    {
                        MessageBox.Show("Bitte klicken Sie in das Bild um die Farbe eines Pixels zu bestimmen!");
                    }
                }
                labelR.Text = pixelColor.R.ToString();      //Farbwerte(RGB) ausgeben
                labelG.Text = pixelColor.G.ToString();      //
                labelB.Text = pixelColor.B.ToString();      //
                labelH.Text = pixelColor.GetHue().ToString();           //Farbwerte(HSI) ausgeben
                labelS.Text = pixelColor.GetSaturation().ToString();    //
                labelBr.Text = pixelColor.GetBrightness().ToString();   //
            }
            private Point TranslateZoomMousePosition(Point coordinates, PictureBox picBox)
            {
                float imageAspect = (float)picBox.Image.Width / picBox.Image.Height;
                float controlAspect = (float)picBox.Width / picBox.Height;
                float newX = coordinates.X;
                float newY = coordinates.Y;
                if (imageAspect > controlAspect)        //Wenn Bild im Querformat vorliegt
                {
                    float ratioWidth = (float)picBox.Image.Width / picBox.Width;        //Verhältnis von Bildbreite zu Pictureboxbreite bestimmen
                    newX *= ratioWidth;     //X-Koordinate der Maus über dem vollen Bild bestimmen
                    float scale = (float)picBox.Width / picBox.Image.Width;     //Verhältnis von Pictureboxbreite zu Bildbreite bestimmen
                    float displayHeight = scale * picBox.Image.Height;      //Höhe des Bildes in der Picturebox bestimmen
                    float diffHeight = picBox.Height - displayHeight;       //Höhe beider freien Flächen der Picturebox bestimmen
                    diffHeight /= 2;        //Höhe einer freien Fläche bestimmen
                    newY -= diffHeight;     //Höhe einer freien Fläche von der y-Koordinate der Mausposition über der Picturebox abziehen...
                    newY /= scale;          //...und durch scale teilen -> Y-Koordinate der Maus über dem vollen Bild
                }
                else        //Wenn Bild im Hochformat vorliegt
                {
                    float ratioHeight = (float)picBox.Image.Height / picBox.Height;     //Verhältnis von Bildhöhe zu Pictureboxhöhe bestimmen
                    newY *= ratioHeight;        //Y-Koordinate der Maus über dem vollen Bild bestimmen
                    float scale = (float)picBox.Height / picBox.Image.Height;       //Verhältnis von Pictureboxhöhe zu Bildhöhe bestimmen
                    float displayWidth = scale * picBox.Image.Width;        //Breite des Bildes in der Picturebox bestimmen
                    float diffWidth = picBox.Width - displayWidth;          //Breite beider freien Flächen der Picturebox bestimmen
                    diffWidth /= 2;     //Breite einer freien Fläche bestimmen
                    newX -= diffWidth;      //Breite einer freien Fläche von der X-Koordinate der Mausposition über der Picturebox abziehen...
                    newX /= scale;          //...und durch scale teilen -> X-Koordinate der Maus über dem vollen Bild
                }
                return new Point((int)newX, (int)newY);     //Mauskoordinaten über dem vollen Bild zurückgeben
            }
            //siehe außerdem Funktion "bildPicturebox_MouseClick"

    //----------------------------------------------------------------------------------------------------
    //Metadaten auslesen
        private void getPicMeta() {
            PropertyItem[] picProps = bildPicturebox.Image.PropertyItems;
            ASCIIEncoding metaEncoder = new ASCIIEncoding();

            labelDate.Text = "default";

            foreach(PropertyItem item in picProps){
                if (item.Id == 0x9003)
                {
                    labelDate.Text = metaEncoder.GetString(item.Value);
                }
            }

            labelReso.Text = bildPicturebox.Image.Width + " x " + bildPicturebox.Image.Height;
            labelDirectory.Text = picDir;
        }

    //----------------------------------------------------------------------------------------------------
    //Mausbewegungen
        private void bildPicturebox_MouseMove(object sender, MouseEventArgs e)
        {
            //falls Hand Tool ausgewählt
            if (handCheckBox.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    bildPicturebox.Top += (e.Y - yMouseMove);
                    bildPicturebox.Left += (e.X - xMouseMove);
                }
            }
        }
        private void bildPicturebox_MouseDown(object sender, MouseEventArgs e)
        {    
            //falls Hand Tool ausgewählt
            if (handCheckBox.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    xMouseMove = e.X;
                    yMouseMove = e.Y;
                }
            }
        }
        private void bildPicturebox_MouseClick(object sender, MouseEventArgs e)
        {
            //Aktionen bei gedrückter linker Maustaste
            if (e.Button == MouseButtons.Left)
            {
                if (colorPickerCheckBox.Checked)
                {
                    getPixelColor(e, bildPicturebox);
                }
            }
            //Aktionen bei gedrückter rechter Maustaste
            else if (e.Button == MouseButtons.Right)
            {

            }
        }

    //----------------------------------------------------------------------------------------------------
    //Ansicht
        private void zoomInButton_Click(object sender, EventArgs e)
        {
            if (bildPicturebox.Image != null)
            {
                bildPicturebox.Width += bildPicturebox.Width / 5;
                bildPicturebox.Height += bildPicturebox.Height / 5;
            }
                //Ordnet die Picturebox ordentlich an
            else
            {
                bildPicturebox.Left = linkerContainer.Panel1.Left+10;
                bildPicturebox.Top = linkerContainer.Panel1.Top+35;
                bildPicturebox.Width = linkerContainer.Panel1.Width-30;
                bildPicturebox.Height = linkerContainer.Panel1.Height-55;
            }
        }
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            if (bildPicturebox.Image != null)
            {
                bildPicturebox.Width -= bildPicturebox.Width / 5;
                bildPicturebox.Height -= bildPicturebox.Height / 5;
            }
            //Ordnet die Picturebox ordentlich an
            else
            {
                bildPicturebox.Left = linkerContainer.Panel1.Left + 10;
                bildPicturebox.Top = linkerContainer.Panel1.Top + 35;
                bildPicturebox.Width = linkerContainer.Panel1.Width - 30;
                bildPicturebox.Height = linkerContainer.Panel1.Height - 55;
            }
        }
        private void rechtsDrehenButton_Click(object sender, EventArgs e)
        {
            //Kritischen Bereich betreten
            if (sem.WaitOne(1000))
            {
                //um auf nummer sicher zu gehen
                Thread.Sleep(1000);

                if (bildPicturebox.Image != null)
                {
                    Image img = bildPicturebox.Image;
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    setAndSavePictureBox((Bitmap)img);
                }
                else
                {
                    MessageBox.Show("Kein Bild zum Drehen geöffnet");
                }
                //Kritischen Bereich verlassen
                sem.Release();
            }
            else
            {
                MessageBox.Show("Bild wird gerade bearbeitet");
            }
        }
        private void linksDrehenButton_Click(object sender, EventArgs e)
        {
            //Kritischen Bereich betreten
            if (sem.WaitOne(1000))
            {
                //um auf nummer sicher zu gehen
                Thread.Sleep(1000);

                if (bildPicturebox.Image != null)
                {
                    Image img = bildPicturebox.Image;
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    setAndSavePictureBox((Bitmap)img);
                }
                else
                {
                    MessageBox.Show("Kein Bild zum Drehen geöffnet");
                }
                //Kritischen Bereich verlassen
                sem.Release();
            }
            else
            {
                MessageBox.Show("Bild wird gerade bearbeitet");
            }
        }

    //----------------------------------------------------------------------------------------------------
    //Accordion Menu
        private void korrekturenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            organizePanels();
        }
        private void ansichtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            organizePanels();
        }
        private void werkzeugeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            organizePanels();
        }
        private void filterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            organizePanels();
        }
        private void initializeAccordionMenu()
        {
            //neue listen für die checkboxen und panels anlegen
            checkboxes = new List<CheckBox> { korrekturenCheckBox, werkzeugeCheckBox, ansichtCheckBox,filterCheckBox };
            panels = new List<Panel> { korrekturenPanel, werkzeugPanel, ansichtPanel,FilterPanel };
            //auf Anfangszustand setzen(alles eingeklappt)
            organizePanels();
        }
        private void organizePanels()
        {
            //erste Checkbox
            if (checkboxes[0].Checked)
            {
                panels[0].Top = checkboxes[0].Bottom;
                panels[0].Left = checkboxes[0].Left;
                panels[0].Visible = true;
                checkboxes[0].Image = Prog3.Properties.Resources.pfeilunten;
            }
            else
            {
                panels[0].Visible = false;
                checkboxes[0].Image = Prog3.Properties.Resources.pfeil_rechts2;
            }
            //alle anderen Checkboxes
            for (int i = 1; i < checkboxes.Count; i++)
            {
                if (checkboxes[i].Checked)//nur die ausgewählten checkBoxen durchgehen
                {
                    //Das Bild der entsprechenden Box ändern
                    checkboxes[i].Image = Prog3.Properties.Resources.pfeilunten;

                    if (checkboxes[i - 1].Checked)  //falls der Vorgänger angeklickt ist
                    {
                        checkboxes[i].Top = panels[i - 1].Bottom;
                        panels[i].Top = checkboxes[i].Bottom;
                        panels[i].Left = checkboxes[i].Left;
                        panels[i].Visible = true;
                    }
                    else//falls der vorgänger nicht angeklickt ist
                    {
                        checkboxes[i].Top = checkboxes[i - 1].Bottom;
                        panels[i].Top = checkboxes[i].Bottom;
                        panels[i].Left = checkboxes[i].Left;
                        panels[i].Visible = true;
                    }
                }
                else//die nicht angeklickten checkBoxen
                {
                    //bild der checkboxen ändern
                    checkboxes[i].Image = Prog3.Properties.Resources.pfeil_rechts2;

                    if (checkboxes[i - 1].Checked)  //falls der vorgänger ausgewählt ist
                    {
                        checkboxes[i].Top = panels[i - 1].Bottom;
                        panels[i].Visible = false;
                    }
                    else//falls der vorgänger nicht ausgewählt ist
                    {
                        checkboxes[i].Top = checkboxes[i - 1].Bottom;
                        panels[i].Visible = false;
                    }
                }
            }
        }

    //----------------------------------------------------------------------------------------------------
    //Histogramme
        private void tabControllHistogramme_Click(object sender, EventArgs e)
        {
            histogramme.berechneHistogramm(tabControllHistogramme.SelectedTab.Text.ToString());
        }
        private void cancelHistoCalc(object sender, EventArgs e)
        {
            histogramme.BwHisto.CancelAsync();
        }

        private void buttonExif_Click(object sender, EventArgs e)
        {
            if (bildPicturebox.Image != null)
            {
                if (sem.WaitOne(1000))
                {
                    _EXIF exif = new _EXIF(bildPicturebox.Image);
                    exif.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bild wird gerade bearbeitet");
                }
            }
        }





        

        

        
        

       
        

        


        

        

        


        

        

        

        

        

        

        


        





        

        

        

        

        

        

        

    }

}
