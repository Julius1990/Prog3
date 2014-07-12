using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class helligkeit : Form
    {
        public helligkeit(form1 parent_in, Semaphore sem_in)
        {
            InitializeComponent();

            //Eltern Form
            parent = parent_in;

            //Semaphore zum Koordinieren der Threads
            hellSem = sem_in;

            //Helligkeit mit Standardwert initialisieren
            helligkeitParameter = -0.1f;

            //Bild in der PictureBox anzeigen
            helligkeitPicturebox.Image = parent.getPictureBoxImage();
        }

        //Variablen
        Semaphore hellSem;
        form1 parent;
        float helligkeitParameter;


    //------------------------------------------------------------------------------------------------
    //Helligkeit berechnen       
        private void helligkeitberechnen()
        {
            Bitmap neueBitmap = new Bitmap(helligkeitPicturebox.Image.Width, helligkeitPicturebox.Image.Height);

            //Vorigen Bearbeitungsschritt löschen
            helligkeitPicturebox.Image = null;
            GC.Collect();

            float[][] meineMatrix ={
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1.0f, 0},
                    new float[] {helligkeitParameter,helligkeitParameter,helligkeitParameter, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(meineMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(neueBitmap);
            g.DrawImage(parent.getPictureBoxImage(), new Rectangle(0, 0, neueBitmap.Width, neueBitmap.Height), 0, 0, neueBitmap.Width, neueBitmap.Height,
                GraphicsUnit.Pixel, imageAttributes);
            helligkeitPicturebox.Image = neueBitmap;
        }
        private void anwendenTrackBarButton_Click(object sender, EventArgs e)
        {
            string gelesen = anwendenTextBox.Text;
            try
            {
                float wert = (float)Convert.ToDouble(gelesen);
                Debug.WriteLine("Eingelesen :" + wert);

                if (wert == 0)
                    helligkeitParameter = 0;
                else
                    helligkeitParameter = wert * 0.01f;

                Debug.WriteLine("Umgerechnet in :" + helligkeitParameter);

                if (!helligkeitBerechnungBW.IsBusy)
                {
                    Cursor = Cursors.WaitCursor;
                    helligkeitBerechnungBW.RunWorkerAsync();
                }
            }
            catch
            {
                MessageBox.Show("Bitte Wert zwischen -100 und 100 eingeben");
            }
        }

    //------------------------------------------------------------------------------------------------
    //Speichern + abbrechen
        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            helligkeitPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }
        private void speichernButton_Click(object sender, EventArgs e)
        {
            parent.setAndSavePictureBox((Bitmap)helligkeitPicturebox.Image);

            helligkeitPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }

        private void helligkeit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kritischen Bereich verlassen
            hellSem.Release();

            //hauptfenster freigeben
            parent.unlockMainWindow();
        }

        //--------------------------------------------------------------------------------------
        //Backgroundworker
        private void helligkeitBerechnungBW_DoWork(object sender, DoWorkEventArgs e)
        {
            helligkeitberechnen();
        }

        private void helligkeitBerechnungBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void helligkeitTrackBar_ValueChanged(object sender, EventArgs e)
        {
            anwendenTextBox.Text = helligkeitTrackBar.Value.ToString();
        }

    }
}
