using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int zwischenSchrittCounter = 0;
        string zwischenSchrittOrdner = "zwischenSchritte";
        

    //----------------------------------------------------------------------------------------------------
    //Menu Bar
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
                }
            }
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
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schrittSpeicherLoeschen();
            this.Close();
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
        }
        private void schrittSpeicherLoeschen()
        {
            zwischenSchrittCounter = 0;
            //sucht alle dateien und löscht diese
            string[] dateien = Directory.GetFiles(zwischenSchrittOrdner);
            foreach (string filePath in dateien)
            {
                File.Delete(filePath);
            }
        }
        private void schrittSpeichern(Bitmap bitmap_in)
        {
            string dateiName = "zwischenSchritte\\";
            dateiName += zwischenSchrittCounter.ToString();
            dateiName += ".bmp";
            bitmap_in.Save(dateiName);
            zwischenSchrittCounter++;
        }
        private void schrittZurueck()
        {
            zwischenSchrittCounter--;
            string dateiname = zwischenSchrittOrdner + "\\" + zwischenSchrittCounter.ToString();
            bildPicturebox.Image = Image.FromFile(dateiname);

        }

    }

}
