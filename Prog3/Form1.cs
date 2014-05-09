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
        bool handToolAusgewählt = false;

        

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
        private void button1_Click(object sender, EventArgs e)
        {
            kontrast neu = new kontrast(this);
            neu.Show();
        }

        private void handButton_Click(object sender, EventArgs e)
        {
            if (handToolAusgewählt)
            {
                handToolAusgewählt = false;
                Cursor = Cursors.Default;
            }
            else
            {
                handToolAusgewählt = true;
                Cursor = Cursors.Hand;
            }
        }

    //----------------------------------------------------------------------------------------------------
    //Mausbewegungen
        private void bildPicturebox_MouseMove(object sender, MouseEventArgs e)
        {
            //falls Hand Tool ausgewählt
            if (handToolAusgewählt)
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
            if (handToolAusgewählt)
            {
                if (e.Button == MouseButtons.Left)
                {
                    xMouseMove = e.X;
                    yMouseMove = e.Y;
                }
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


        //----------------------------------------------------------------------------------------------------
        //Color-Picker
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

        private void bildPicturebox_MouseClick(object sender, MouseEventArgs e)
        {
            getPixelColor(e, bildPicturebox);
        }

        

        

        

    }

}
