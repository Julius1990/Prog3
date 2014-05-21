using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            helligkeitberechnen();
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

    }
}
