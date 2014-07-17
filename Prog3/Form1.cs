using System;
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
        public _hauptfenster()
        {
            InitializeComponent();
            schrittSpeicherAnlegen();

            //Accordion Menu
            initializeAccordionMenu();

            //Backgroundworker
            threadsInitialisieren();

            //Werkzeuge
            initialisiereTools();

            //Histogramme
            initialisiereHistogramme();

            //Picturebox ordentlich anordnen
            bildPicturebox.Left = linkerContainer.Panel1.Left + 10;
            bildPicturebox.Top = linkerContainer.Panel1.Top + 35;
            bildPicturebox.Width = linkerContainer.Panel1.Width - 30;
            bildPicturebox.Height = linkerContainer.Panel1.Height - 55;
        }
    //----------------------------------------------------------------------------------------------------
    //Globale Variablen
        //zwischenschritte
        int zwischenSchrittCounter = -1;
        int maxSchritt = 0;
        string zwischenSchrittOrdner = "zwischenSchritte";

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

        //Histogramme
        List<CheckBox> histogramme;

        //Semaphore
        public Semaphore sem = new Semaphore(1, 1);

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
                    schrittSpeichern((Bitmap)bildPicturebox.Image);

                    //Speicherort merken
                    picDir = bildOeffnenDialog.FileName;

                    speichernUnterToolStripMenuItem.Visible = true;
                    schließenToolStripMenuItem.Visible = true;

                    //rückgängig und wiederholen ausblenden
                    rückgängigToolStripMenuItem.Visible = false;
                    wiederholenToolStripMenuItem.Visible = false;

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
            schrittZurueck();
        }
        private void wiederholenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schrittVor();
        }
        
    //----------------------------------------------------------------------------------------------------
    //Zwischenschritte
        private void schrittSpeicherAnlegen()
        {
            //Ordner für Zwischenschritte anlegen
            bool existiert = System.IO.Directory.Exists(zwischenSchrittOrdner);
            //falls er existiert, lösche den Inhalt
            if (existiert)
            {
                schrittSpeicherLoeschen();
            }
            //falls er nicht existiert, legt er den Ordner an
            else if (!existiert)
            {
                System.IO.Directory.CreateDirectory(zwischenSchrittOrdner);
            }
            //optionen für rückgängig und wiederholen "ausblenden"
            rückgängigToolStripMenuItem.Visible = false;
            wiederholenToolStripMenuItem.Visible = false;
        }
        private void schrittSpeicherLoeschen()
        {
            bildPicturebox.Image = null;
            GC.Collect();
            zwischenSchrittCounter = -1;
            maxSchritt = zwischenSchrittCounter;
            //sucht alle dateien und löscht diese
            string[] dateien = Directory.GetFiles(zwischenSchrittOrdner);
            foreach (string filePath in dateien)
            {
                File.Delete(filePath);
            }
            //optionen für rückgängig und wiederholen ausblenden
            rückgängigToolStripMenuItem.Visible = false;
            wiederholenToolStripMenuItem.Visible = false;
        }
        private void schrittSpeichern(Bitmap bitmap_in)
        {
            //überflüssig gespeichertes löschen
            if (maxSchritt>zwischenSchrittCounter)
            {
                string[] dateien = Directory.GetFiles(zwischenSchrittOrdner);
                foreach (string filePath in dateien)
                {
                    string name = Path.GetFileNameWithoutExtension(filePath);
                    Int32 number = Convert.ToInt32(name);

                    if (number > zwischenSchrittCounter)
                    {
                        File.Delete(filePath);
                    }
                }
            }

            zwischenSchrittCounter++;
            Debug.WriteLine("ZwischenSchrittCounter: " + zwischenSchrittCounter.ToString());

            //bild speichern
            string dateiName = "zwischenSchritte\\" + zwischenSchrittCounter.ToString() + ".bmp";
            bitmap_in.Save(dateiName);

            //rückgängig zulassen oder blockieren
            if (zwischenSchrittCounter > 0)
                rückgängigToolStripMenuItem.Visible = true;
            else
                rückgängigToolStripMenuItem.Visible = false;

            //wiederholen deaktivieren
            wiederholenToolStripMenuItem.Visible = false;
            //benötigt für wiederholen
            maxSchritt = zwischenSchrittCounter;
        }
        private void schrittZurueck()
        {
            if (sem.WaitOne(500))
            {
                Thread.Sleep(1000);

                Debug.WriteLine("Schritt zurück Angefordert");

                zwischenSchrittCounter--;
                Debug.WriteLine("ZwischenSchrittCounter: " + zwischenSchrittCounter.ToString());
                string dateiname = zwischenSchrittOrdner + "\\" + zwischenSchrittCounter.ToString() + ".bmp";
                bildPicturebox.Image = Image.FromFile(dateiname);
                if (zwischenSchrittCounter == 0)
                {
                    rückgängigToolStripMenuItem.Visible = false;
                }
                wiederholenToolStripMenuItem.Visible = true;

                Debug.WriteLine("Schritt zurück Ausgeführt");

                sem.Release();
            }
            else
            {
                MessageBox.Show("Das Bild wird gerade bearbeitet");
            }
        }
        private void schrittVor()
        {
            if (sem.WaitOne(500))
            {
                Debug.WriteLine("Schritt vor Angefordert");

                Thread.Sleep(1000);

                zwischenSchrittCounter++;
                string dateiname = zwischenSchrittOrdner + "\\" + zwischenSchrittCounter.ToString() + ".bmp";
                bildPicturebox.Image = Image.FromFile(dateiname);
                if (zwischenSchrittCounter == maxSchritt)
                    wiederholenToolStripMenuItem.Visible = false;
                rückgängigToolStripMenuItem.Visible = true;

                Debug.WriteLine("Schritt vor Ausgeführt");

                sem.Release();
            }
            else
            {
                MessageBox.Show("Das Bild wird gerade bearbeitet");
            }
        }

    //----------------------------------------------------------------------------------------------------
    //aufräumen
        private void aufraeumen()
        {
            //Threads beenden
            threadsBeenden();

            schrittSpeicherLoeschen();

            bildPicturebox.Image = null;

            //datei
            speichernUnterToolStripMenuItem.Visible = false;
            speichernToolStripMenuItem.Visible = false;
            schließenToolStripMenuItem.Visible = false;

            //bearbeiten
            rückgängigToolStripMenuItem.Visible = false;
            wiederholenToolStripMenuItem.Visible = false;

            GC.Collect();
        }

    //----------------------------------------------------------------------------------------------------
    //get und set funktionen
        public void setAndSavePictureBox(Bitmap bitmap_in)
        {
            bildPicturebox.Image = bitmap_in;
            schrittSpeichern(bitmap_in);
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
        private void positioniereProgressBarHistogramme()
        {
            histoProgressBar.Top = histoPictureBox.Height / 2;
            histoProgressBar.Left = (histoPictureBox.Width - histoProgressBar.Width) / 2;

            histoAbbrechenButton.Top = histoPictureBox.Height / 2 + histoProgressBar.Height;
            histoAbbrechenButton.Left = (histoPictureBox.Width - histoAbbrechenButton.Width) / 2;
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

                //startet die Berechnung in einem neuen Thread
                grauwertBW.RunWorkerAsync();
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

            Debug.WriteLine("Grauwert BW starten");

            //um auf nummer sicher zu gehen
            Thread.Sleep(1000);

            progressBarAbbrechenButton.Invoke(new Action(() => progressBarAbbrechenButton.Visible = true));

            //berechne das Grauwertbild            
            createGreyValPic();
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
        public void createGreyValPic()
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
            backWorkers = new List<BackgroundWorker> { negativBW, grauwertBW, histoBW };
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
                Bitmap helpMap;
                Point picPos;
                Color pixelColor;
                helpMap = new Bitmap(picBox.Image);     //Bitmap aus Bild in Picturebox erstellen
                picPos = TranslateZoomMousePosition(new Point(e.X, e.Y), picBox);       //Position der Maus über dem Bild bestimmen
                pixelColor = helpMap.GetPixel(picPos.X, picPos.Y);      //Pixelfarbe bestimmen
                labelR.Text = pixelColor.R.ToString();      //Farbwerte ausgeben
                labelG.Text = pixelColor.G.ToString();      //
                labelB.Text = pixelColor.B.ToString();      //
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
        //BackgroundWorker
        private void histoBW_DoWork(object sender, DoWorkEventArgs e)
        {
            //Kritischen Bereich betreten
            sem.WaitOne();

            Debug.WriteLine("Hisrogramm BW startet");

            Thread.Sleep(1000);

            histoAbbrechenButton.Invoke(new Action(() => histoAbbrechenButton.Visible = true));

            if (grauHistCheckBox.Checked)
            {
                histGray();
            }
            else if (rgbHistCheckBox.Checked)
            {
                histRGB();
            }
            else if (rHistCheckBox.Checked)
            {
                histRed();
            }
            else if (gHistCheckBox.Checked)
            {
                histGreen();
            }
            else if (bHistCheckBox.Checked)
            {
                histBlue();
            }
        }
        private void histoBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            histoProgressBar.Invoke(new Action(() => histoProgressBar.Value = e.ProgressPercentage));
        }
        private void histoBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Fortschritt
            histoProgressBar.Invoke(new Action(() => histoProgressBar.Visible = false));
            histoAbbrechenButton.Invoke(new Action(() => histoAbbrechenButton.Visible = false));

            unlockHistoButtons();

            Debug.WriteLine("Histo BW Arbeit beendet");

            //Kritischen Bereich verlassen
            sem.Release();
        }


        //Funktionen zur Histogramm Berechnung
        private void histGray()
        {
            if (histoBW.CancellationPending)
                return;

            Bitmap origBitmap = (Bitmap)bildPicturebox.Image.Clone();

            int[] hist = new int[256];
            int max = 0;

            for (int a = 0; a < 255; a++)
            {
                hist[a] = 0;
            }

            //Fortschritt
            histoProgressBar.Invoke(new Action(() =>
            {
                histoProgressBar.Visible = true;
                histoProgressBar.Maximum = origBitmap.Width;
                histoProgressBar.Value = 0;
            }));


            //läuft jedes Pixel einzeln durch
            for (int x = 0; x < origBitmap.Width; x++)
            {
                for (int y = 0; y < origBitmap.Height; y++)
                {
                    Color orig = origBitmap.GetPixel(x, y);
                    //Diese Werte sind aus der Vorlesung
                    int grey = (int)((orig.R * 0.3) + (orig.G * 0.6) + (orig.B * 0.1));

                    int grauWert = grey;
                    hist[grauWert]++;
                    if (hist[grauWert] > max)
                    {
                        max = hist[grauWert];
                    }
                }
                histoBW.ReportProgress(x);
                if (histoBW.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            histoPictureBox.Invoke(new Action(() => histoPictureBox.BackColor = Color.White));

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)hist[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Black);
                }
                if (histoBW.CancellationPending)
                    return;
            }
            if (!negativBW.IsBusy && !grauwertBW.IsBusy)
            {
                histoPictureBox.Invoke(new Action(() => histoPictureBox.Image = histogramm));
            }
        }
        private void histRGB()
        {
            if (histoBW.CancellationPending)
                return;

            Bitmap orig = new Bitmap(bildPicturebox.Image);

            //blau
            long[] blue = new long[256];
            long maxBlau = 0;
            for (int a = 0; a < 255; a++)
            {
                blue[a] = 0;
            }

            //rot
            long[] red = new long[256];
            long maxRot = 0;
            for (int a = 0; a < 255; a++)
            {
                red[a] = 0;
            }

            //Grün
            long[] greene = new long[256];
            long maxGruen = 0;
            for (int a = 0; a < 255; a++)
            {
                greene[a] = 0;
            }

            //Fortschritt
            histoProgressBar.Invoke(new Action(() =>
            {
                histoProgressBar.Visible = true;
                histoProgressBar.Maximum = orig.Width;
                histoProgressBar.Value = 0;
            }));

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int rotwert = orig.GetPixel(x, y).R;
                    int gruenwert = orig.GetPixel(x, y).G;
                    int blauwert = orig.GetPixel(x, y).B;

                    //rot
                    red[rotwert]++;
                    if (red[rotwert] > maxRot)
                        maxRot = red[rotwert];

                    //grün
                    greene[gruenwert]++;
                    if (greene[gruenwert] > maxGruen)
                        maxGruen = greene[gruenwert];

                    //blau
                    blue[blauwert]++;
                    if (blue[blauwert] > maxBlau)
                        maxBlau = blue[blauwert];
                }
                histoBW.ReportProgress(x);
                if (histoBW.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);
            histoPictureBox.Invoke(new Action(() => histoPictureBox.BackColor = Color.White));

            long groesste = 0;

            if (maxBlau > maxGruen && maxBlau > maxRot)
            {
                groesste = maxBlau;
            }
            else if (maxGruen > maxBlau && maxGruen > maxRot)
            {
                groesste = maxGruen;
            }
            else
                groesste = maxRot;

            Debug.WriteLine(groesste);
            Debug.WriteLine("Blau:" + maxBlau.ToString());

            double ratio = 132.0 / (double)groesste;

            //rot
            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)red[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Red);
                }
                if (histoBW.CancellationPending)
                    return;
            }

            //grün
            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)greene[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    if (histogramm.GetPixel(x, 131 - b).R != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.Yellow);
                    }
                    else
                        histogramm.SetPixel(x, 131 - b, Color.Green);
                }
                if (histoBW.CancellationPending)
                    return;
            }

            //blau
            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)blue[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    Color grab = histogramm.GetPixel(x + 1, 131 - b);
                    if (grab.R != 0 && grab.G != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.Gray);
                    }
                    else if (grab.R != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.Magenta);
                    }
                    else if (grab.G != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.LightBlue);
                    }
                    else
                        histogramm.SetPixel(x, 131 - b, Color.Blue);
                }
                if (histoBW.CancellationPending)
                    return;
            }
            histoPictureBox.Invoke(new Action(() => histoPictureBox.Image = histogramm));
        }
        private void histRed()
        {
            if (histoBW.CancellationPending)
                return;

            Bitmap orig = new Bitmap(bildPicturebox.Image);
            int[] rot = new int[256];
            int max = 0;
            for (int a = 0; a < 255; a++)
            {
                rot[a] = 0;
            }

            //Fortschritt
            histoProgressBar.Invoke(new Action(() =>
            {
                histoProgressBar.Visible = true;
                histoProgressBar.Maximum = orig.Width;
                histoProgressBar.Value = 0;
            }));

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int rotwert = orig.GetPixel(x, y).R;
                    rot[rotwert]++;
                    if (rot[rotwert] > max)
                        max = rot[rotwert];
                }
                histoBW.ReportProgress(x);
                if (histoBW.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            histoPictureBox.Invoke(new Action(() => histoPictureBox.BackColor = Color.White));

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)rot[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Red);
                }
                if (histoBW.CancellationPending)
                    return;
            }
            histoPictureBox.Invoke(new Action(() => histoPictureBox.Image = histogramm));
        }
        private void histGreen()
        {
            if (histoBW.CancellationPending)
                return;

            Bitmap orig = new Bitmap(bildPicturebox.Image);
            int[] green = new int[256];
            int max = 0;
            for (int a = 0; a < 255; a++)
            {
                green[a] = 0;
                }

            //Fortschritt
            histoProgressBar.Invoke(new Action(() =>
            {
                histoProgressBar.Visible = true;
                histoProgressBar.Maximum = orig.Width;
                histoProgressBar.Value = 0;
            }));

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int gruenwert = orig.GetPixel(x, y).G;
                    green[gruenwert]++;
                    if (green[gruenwert] > max)
                        max = green[gruenwert];
            }
                histoBW.ReportProgress(x);
                if (histoBW.CancellationPending)
                    return;
        }
            Bitmap histogramm = new Bitmap(258, 132);

            histoPictureBox.Invoke(new Action(() => histoPictureBox.BackColor = Color.White));

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)green[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Green);
                }
                if (histoBW.CancellationPending)
                    return;
            }
            histoPictureBox.Invoke(new Action(() => histoPictureBox.Image = histogramm));
        }
        private void histBlue()
        {
            if (histoBW.CancellationPending)
                return;

            Bitmap orig = new Bitmap(bildPicturebox.Image);
            int[] blue = new int[256];
            int max = 0;
            for (int a = 0; a <= 255; a++)
            {
                blue[a] = 0;
            }

            //Fortschritt
            histoProgressBar.Invoke(new Action(() =>
            {
                histoProgressBar.Visible = true;
                histoProgressBar.Maximum = orig.Width;
                histoProgressBar.Value = 0;
            }));

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int blauwert = orig.GetPixel(x, y).B;
                    blue[blauwert]++;
                    if (blue[blauwert] > max)
                        max = blue[blauwert];
                }
                histoBW.ReportProgress(x);
                if (histoBW.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            histoPictureBox.Invoke(new Action(() => histoPictureBox.BackColor = Color.White));

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)blue[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Blue);
                }
                if (histoBW.CancellationPending)
                    return;
            }
            histoPictureBox.Invoke(new Action(() => histoPictureBox.Image = histogramm));
        }

        //Histogramm CheckBoxes
        private void grauHistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (grauHistCheckBox.Checked && bildPicturebox.Image!=null)
            {
                if (checkHistogramme(grauHistCheckBox) && !histoBW.IsBusy)
                {
                    lockHistoButtons();
                    positioniereProgressBarHistogramme();
                    histoBW.RunWorkerAsync();
                }
                else
                {
                    grauHistCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                if (checkHistogramme(grauHistCheckBox))
                    unlockHistoButtons();
            }
        }
        private void rgbHistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbHistCheckBox.Checked && bildPicturebox.Image != null)
            {
                if (checkHistogramme(rgbHistCheckBox) && !histoBW.IsBusy)
                {
                    lockHistoButtons();
                    positioniereProgressBarHistogramme();
                    histoBW.RunWorkerAsync();
                }
                else
                {
                    rgbHistCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                if (checkHistogramme(rgbHistCheckBox))
                    unlockHistoButtons();
            }
        }
        private void rHistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rHistCheckBox.Checked && bildPicturebox.Image != null)
            {
                if (checkHistogramme(rHistCheckBox) && !histoBW.IsBusy)
                {
                    lockHistoButtons();
                    positioniereProgressBarHistogramme();
                    histoBW.RunWorkerAsync();
                }
                else
                {
                    rHistCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                if (checkHistogramme(rHistCheckBox))
                    unlockHistoButtons();
            }
        }
        private void gHistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gHistCheckBox.Checked && bildPicturebox.Image != null)
            {
                if (checkHistogramme(gHistCheckBox) && !histoBW.IsBusy)
                {
                    lockHistoButtons();
                    positioniereProgressBarHistogramme();
                    histoBW.RunWorkerAsync();
                }
                else
                {
                    gHistCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                if (checkHistogramme(gHistCheckBox))
                    unlockHistoButtons();
            }
        }
        private void bHistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bHistCheckBox.Checked && bildPicturebox.Image != null)
            {
                if (checkHistogramme(bHistCheckBox) && !histoBW.IsBusy)
                {
                    lockHistoButtons();
                    positioniereProgressBarHistogramme();
                    histoBW.RunWorkerAsync();
                }
                else
                {
                    bHistCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                if (checkHistogramme(bHistCheckBox))
                    unlockHistoButtons();
            }
        }

        //Histogramm Checkbox Logik
        private void initialisiereHistogramme()
        {
            histogramme = new List<CheckBox> { grauHistCheckBox, rgbHistCheckBox, rHistCheckBox, gHistCheckBox, bHistCheckBox };
        }
        private bool checkHistogramme(CheckBox selbst)
        {
            //Prüft ob ein anderes Histogramm gerade aktiv ist
            foreach (CheckBox h in histogramme)
            {
                if (h.Checked && !h.Equals(selbst))
                    return false;
            }
            return true;
        }
        private void lockHistoButtons()
        {
            foreach (CheckBox c in histogramme)
            {
                c.Enabled = false;
            }
        }
        private void unlockHistoButtons()
        {
            foreach (CheckBox c in histogramme)
            {
                c.Enabled = true;
                c.CheckState = CheckState.Unchecked;
            }
        }

        private void histoAbbrechenButton_Click(object sender, EventArgs e)
        {
            threadsBeenden();
        }


        

        

        
        

       
        

        


        

        

        


        

        

        

        

        

        

        


        





        

        

        

        

        

        

        

    }

}
