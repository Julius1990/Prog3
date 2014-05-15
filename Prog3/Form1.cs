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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            schrittSpeicherAnlegen();

            //Accordion Menu
            initializeAccordionMenu();
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

        //Werkzeuge
        bool toolAusgewaehlt = false;
        bool colorPickerAusgewaehlt = false;
        bool handToolAusgewaehlt = false;

        //Accordion Menu
        List<CheckBox> checkboxes;
        List<Panel> panels;

    //----------------------------------------------------------------------------------------------------
    //MenuStrip
        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

                    speichernUnterToolStripMenuItem.Visible = true;
                    schließenToolStripMenuItem.Visible = true;
                }
            }
            //rückgängig und wiederholen ausblenden
            rückgängigToolStripMenuItem.Visible = false;
            wiederholenToolStripMenuItem.Visible = false;
        }
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }
        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
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
                    else if (ext == ".tif" || ext ==".tiff")
                    {
                        bildPicturebox.Image.Save(speichernUnter, ImageFormat.Tiff);
                    }
                    else if (ext == ".bmp")
                    {
                        bildPicturebox.Image.Save(speichernUnter, ImageFormat.Bmp);
                    }
                }
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
        public void schrittSpeichern(Bitmap bitmap_in)
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
            zwischenSchrittCounter--;
            Debug.WriteLine("ZwischenSchrittCounter: " + zwischenSchrittCounter.ToString());
            string dateiname = zwischenSchrittOrdner + "\\" + zwischenSchrittCounter.ToString() + ".bmp";
            bildPicturebox.Image = Image.FromFile(dateiname);
            if (zwischenSchrittCounter == 0)
            {
                rückgängigToolStripMenuItem.Visible = false;
            }
            wiederholenToolStripMenuItem.Visible = true;
        }
        private void schrittVor()
        {
            zwischenSchrittCounter++;
            string dateiname = zwischenSchrittOrdner + "\\" + zwischenSchrittCounter.ToString() + ".bmp";
            bildPicturebox.Image = Image.FromFile(dateiname);
            if (zwischenSchrittCounter == maxSchritt)
                wiederholenToolStripMenuItem.Visible = false;
            rückgängigToolStripMenuItem.Visible = true;
        }

    //----------------------------------------------------------------------------------------------------
    //aufräumen
        private void aufraeumen()
        {
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

    //----------------------------------------------------------------------------------------------------
    //Korrekturen
        private void kontrastButton_Click(object sender, EventArgs e)
        {
            kontrast neu = new kontrast(this);
            neu.Show();
        }
        private void greyValButton_Click(object sender, EventArgs e)
        {
            //grauwert gw = new grauwert(bildPicturebox, this);
            //gw.Show();
            //gw.createGreyValPic();
            createGreyValPic();
        }
        public void createGreyValPic()
        {
            Color oldColor, greyColor;
            Bitmap helpMap, greyMap;
            int width, height, i, j = 0, greyValue;

            try
            {
                helpMap = (Bitmap)bildPicturebox.Image;   //Bitmap aus Bild in picBoxOld erstellen
                width = helpMap.Width;      //Bildbreite bestimmen
                height = helpMap.Height;    //Bildhöhe bestimmen
                greyMap = new Bitmap(width, height);        //Bitmap für das Grauwertbild erstellen
                form1ProgressBar.Top = linkerContainer.Panel1.Height / 2;
                form1ProgressBar.Left = linkerContainer.Width / 2 - form1ProgressBar.Width;
                form1ProgressBar.Maximum = height;
                form1ProgressBar.Visible = true; //Progressbar sichtbar machen
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
                    form1ProgressBar.Increment(1);   //Fortschritt der Progressbar erhöhen
                }
                setAndSavePictureBox(greyMap);
                form1ProgressBar.Value = 0;  //Progressbar leeren
                form1ProgressBar.Visible = false;
            }
            catch
            {
                MessageBox.Show("Bitte öffnen Sie ein Bild bevor Sie diese Funktion nutzen!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);     //Ausgabe bei Exception
            }
            GC.Collect();       //Garbage Collection auslösen
        }
        private void invertedButton_Click(object sender, EventArgs e)
        {
            negativ neg = new negativ(bildPicturebox, this);
        }

    //----------------------------------------------------------------------------------------------------
    //Werkzeuge
        private void lockUnlockTools()
        {
            if (toolAusgewaehlt)
            {
                handButton.Enabled=false;
                colorPickerButton.Enabled=false;

                if (handToolAusgewaehlt)
                    handButton.Enabled = true;
                if (colorPickerAusgewaehlt)
                    colorPickerButton.Enabled = true;
            }
            else
            {
                handButton.Enabled = true;
                colorPickerButton.Enabled = true;
            }
        }
        //------------------------------------------------------------------------------------------------
        //Hand Tool
            private void handButton_Click(object sender, EventArgs e)
        {
            if (!handToolAusgewaehlt && !toolAusgewaehlt)
            {
                handToolAusgewaehlt = true;
                Cursor = Cursors.Hand;

                toolAusgewaehlt = true;
                lockUnlockTools();
            }
            else
            {
                handToolAusgewaehlt = false;
                Cursor = Cursors.Default;

                toolAusgewaehlt = false;
                lockUnlockTools();
            }
        }
            //siehe außerdem Funktion "bildPicturebox_MouseMove" und "bildPicturebox_MouseDown"
        //------------------------------------------------------------------------------------------------
        //Color Picker
            private void colorPickerButton_Click(object sender, EventArgs e)
            {
                if (!colorPickerAusgewaehlt && !toolAusgewaehlt)
                {
                    colorPickerAusgewaehlt = true;
                    Cursor = Cursors.Cross;

                    toolAusgewaehlt = true;
                    lockUnlockTools();
                }
                else
                {
                    colorPickerAusgewaehlt = false;
                    Cursor = Cursors.Default;

                    toolAusgewaehlt = false;
                    lockUnlockTools();
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
    //Mausbewegungen
        private void bildPicturebox_MouseMove(object sender, MouseEventArgs e)
        {
            //falls Hand Tool ausgewählt
            if (handToolAusgewaehlt)
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
            if (handToolAusgewaehlt)
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
                if (colorPickerAusgewaehlt)
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
            bildPicturebox.Width += bildPicturebox.Width / 5;
            bildPicturebox.Height += bildPicturebox.Height / 5;
        }
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            bildPicturebox.Width -= bildPicturebox.Width / 5;
            bildPicturebox.Height -= bildPicturebox.Height / 5;
        }
        private void rechtsDrehenButton_Click(object sender, EventArgs e)
        {
            Image img = bildPicturebox.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            setAndSavePictureBox((Bitmap)img);
        }
        private void linksDrehenButton_Click(object sender, EventArgs e)
        {
            Image img = bildPicturebox.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            setAndSavePictureBox((Bitmap)img);
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

        


        





        

        

        

        

        

        

        

    }

}
