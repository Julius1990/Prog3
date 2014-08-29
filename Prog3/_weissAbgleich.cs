using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class _weissAbgleich : Form
    {
        public _weissAbgleich(Bitmap bit_in,_hauptfenster parent_in,Semaphore sem_in)
        {
            InitializeComponent();
        
            //aus dieser form heraus wurde kontrast aufgerufen
            parent = parent_in;

            //Bild in PictureBox öffnen
            weissabgleichPicturebox.Image = bit_in;
            orig = bit_in;

            //Semaphore kommt aus Form1
            sem = sem_in;
        }

        //------------------------------------------------------------------------------------------------
        //Globale Variablen
        _hauptfenster parent;
        Semaphore sem;
        Bitmap orig;

        //------------------------------------------------------------------------------------------------
        //Steuerung Button + Trackbar
        private void kontrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            calc_white();
        }
        private void buttonAnwenden_Click(object sender, EventArgs e)
        {
            //Textbox auswerten und Wert speichern
            string einlesen = textBoxWert.Text;

            try
            {
                //Wert aus der Textbox einlesen
                int eingabeWert = Convert.ToInt32(einlesen);

                eingabeWert += 255;

                weissabgleichTrackBar.Value = eingabeWert;

                calc_white();
            }
            catch
            {
                MessageBox.Show("Bitte einen Wert zwischen -255 und 255 eingeben");
            }
        }
        
        //------------------------------------------------------------------------------------------------
        //Berechnung Weißabgleich
        private void calc_white()
        {

            textBoxWert.Text = (weissabgleichTrackBar.Value - 255).ToString();

            Bitmap sourceBitmap = orig;

            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                        sourceBitmap.Width, sourceBitmap.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            float blue = 0;
            float green = 0;
            float red = 0;

            float blueLevelFloat = weissabgleichTrackBar.Value;
            float greenLevelFloat = weissabgleichTrackBar.Value;
            float redLevelFloat = weissabgleichTrackBar.Value;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = 255.0f / blueLevelFloat * (float)pixelBuffer[k];
                green = 255.0f / greenLevelFloat * (float)pixelBuffer[k + 1];
                red = 255.0f / redLevelFloat * (float)pixelBuffer[k + 2];

                if (blue > 255) { blue = 255; }
                else if (blue < 0) { blue = 0; }

                if (green > 255) { green = 255; }
                else if (green < 0) { green = 0; }

                if (red > 255) { red = 255; }
                else if (red < 0) { red = 0; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }


            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);


            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                       ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);


            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            weissabgleichPicturebox.Image = resultBitmap;
        }

        //------------------------------------------------------------------------------------------------
        //Speichern + abbrechen
        private void abbrechenButton_Click_1(object sender, EventArgs e)
        {
            weissabgleichPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }
        private void speichernButton_Click_1(object sender, EventArgs e)
        {
            parent.setAndSavePictureBox((Bitmap)weissabgleichPicturebox.Image);

            weissabgleichPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }
        private void _weissAbgleich_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kritischen Bereich freigeben
            sem.Release();

            //hauptfenster wieder freigeben
            parent.unlockMainWindow();
        }              
    }
}
