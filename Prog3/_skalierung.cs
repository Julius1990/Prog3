using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class _skalierung : Form
    {
        public _skalierung(_hauptfenster parent_in, Semaphore sem_in)
        {
            InitializeComponent();

            //Mitteilen aus welcher Form heraus das Fester geöffnet wurde
            parent = parent_in;

            //Unskaliertes Bild in der einen Picturebox anzeigen
            pictureBoxOriginal.Image = parent.getPictureBoxImage();

            //Höhe und Breite auslesen und in 2 Labels anzeigen
            origBreiteLabel.Text = pictureBoxOriginal.Image.Width.ToString();
            origHöheLabel.Text = pictureBoxOriginal.Image.Height.ToString();

            //Semaphore
            sem = sem_in;
        }

        //-------------------------------------------------------------------------------------------
        //Globale Variablen
        _hauptfenster parent;
        Semaphore sem;

        private void anwendenButton_Click(object sender, EventArgs e)
        {
            //neue Bimap + dazu gehörendes Graphics Objekt anlegen
            Bitmap orig = (Bitmap)parent.getPictureBoxImage();
            int targetWidth = Convert.ToInt32(textBox1.Text);
            int targetHeight = Convert.ToInt32(textBox2.Text);
            Bitmap gross = new Bitmap(targetWidth, targetHeight);
            Graphics gr = Graphics.FromImage(gross);
            try
            {
                //Zielbild erstellen
                gr.Clear(Color.Black);
                gr.InterpolationMode = InterpolationMode.Bicubic;
                gr.DrawImage(orig, new Rectangle(0, 0, targetWidth, targetHeight), new Rectangle(0, 0, orig.Width, orig.Height), GraphicsUnit.Pixel);
                gr.Dispose();
                pictureBoxSkaliert.Image = gross;
            }
            //falls was schief geht
            catch
            {
                MessageBox.Show("Bitte gültige Werte eingeben");
            }
        }

        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            //aufräumen bzw die beiden bilder der pictureboxen löschen
            pictureBoxSkaliert.Image = null;
            pictureBoxOriginal.Image = null;
            GC.Collect();

            //Form schließen
            this.Close();
        }
        private void speichernButton_Click(object sender, EventArgs e)
        {
            //Geändertes Bild an das Hauptfenster übergeben und Bearbeitunsschritt speichern
            parent.setAndSavePictureBox((Bitmap)pictureBoxSkaliert.Image);

            //aufräumen bzw die beiden bilder der pictureboxen löschen
            pictureBoxSkaliert.Image = null;
            pictureBoxOriginal.Image = null;
            GC.Collect();

            //Form schließen
            this.Close();
        }

        private void _skalierung_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kritischen Bereich freigeben
            sem.Release();

            //hauptfenster wieder freigeben
            parent.unlockMainWindow();
        }
    }
}
