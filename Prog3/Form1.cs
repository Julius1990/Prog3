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
        int zwischenSchrittCounter = -1;
        int maxSchritt = 0;
        string zwischenSchrittOrdner = "zwischenSchritte";
        

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
                    //alte zwischenschritte löschen
                    schrittSpeicherLoeschen();

                    bildPicturebox.Image = Image.FromFile(bildOeffnenDialog.FileName);
                    schrittSpeichern((Bitmap)bildPicturebox.Image);

                    speichernUnterToolStripMenuItem.Visible = true;
                    schließenToolStripMenuItem.Visible = true;
                }
            }
            //rückgängig und wiederholen ausblenden
            rückgängigToolStripMenuItem.Visible = false;
            wiederholenToolStripMenuItem.Visible = false;
        }
        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //speichern Dialog anzeigen
            DialogResult rs = bildOeffnenDialog.ShowDialog();
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
                    string ext = Path.GetExtension(bildOeffnenDialog.FileName);
                    if (ext == ".jpg" || ext == ".jpeg")
                    {
                        bildPicturebox.Image.Save(bildOeffnenDialog.FileName, ImageFormat.Jpeg);
                    }
                    else if (ext == ".png")
                    {
                        bildPicturebox.Image.Save(bildOeffnenDialog.FileName, ImageFormat.Png);
                    }
                    else if (ext == ".gif")
                    {
                        bildPicturebox.Image.Save(bildOeffnenDialog.FileName, ImageFormat.Gif);
                    }
                    else if (ext == ".tif" || ext ==".tiff")
                    {
                        bildPicturebox.Image.Save(bildOeffnenDialog.FileName, ImageFormat.Tiff);
                    }
                    else if (ext == ".bmp")
                    {
                        bildPicturebox.Image.Save(bildOeffnenDialog.FileName, ImageFormat.Bmp);
                    }
                }
            }
        }
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speichernUnterToolStripMenuItem.Visible = false;
            schließenToolStripMenuItem.Visible = false;

            bildPicturebox.Image = null;
            schrittSpeicherLoeschen();
            GC.Collect();
        }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bildPicturebox.Image = null;
            schrittSpeicherLoeschen();
            GC.Collect();
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
            zwischenSchrittCounter = -1;
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
            zwischenSchrittCounter--;
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

        

        

        

        

    }

}
