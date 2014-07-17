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
    public partial class kontrast : Form
    {
    //------------------------------------------------------------------------------------------------
    //Konstruktor
        public kontrast(_hauptfenster parent_in, Semaphore sem_in)
        {
            InitializeComponent();

            //aus dieser form heraus wurde kontrast aufgerufen
            parent = parent_in;

            //Bild in PictureBox öffnen
            kontrastPicturebox.Image = parent.getPictureBoxImage();

            //Default Kontrast einstellen
            kontrastwert = 1.0f;

            //Semaphore kommt aus Form1
            kontrSem = sem_in;
        }
    //------------------------------------------------------------------------------------------------
    //Globale Variablen
        _hauptfenster parent;
        float kontrastwert;
        Semaphore kontrSem;

    //------------------------------------------------------------------------------------------------
    //Kontrast berechnen       
        private void kontrastBerechnen()
        {
            Bitmap neueBitmap = new Bitmap(kontrastPicturebox.Image.Width, kontrastPicturebox.Image.Height);

            kontrastPicturebox.Image = null;
            GC.Collect();

            Debug.WriteLine("Verarbeiteter Wert: " + kontrastwert);

            float angepassteHelligkeit = (1.0f - kontrastwert) / 2.0f;

            float[][] meineMatrix ={
                    new float[] {kontrastwert, 0, 0, 0, 0},
                    new float[] {0, kontrastwert, 0, 0, 0},
                    new float[] {0, 0, kontrastwert, 0, 0},
                    new float[] {0, 0, 0, 1.0f, 0},
                    new float[] {angepassteHelligkeit,angepassteHelligkeit,angepassteHelligkeit, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(meineMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(neueBitmap);
            g.DrawImage(parent.getPictureBoxImage(), new Rectangle(0, 0, neueBitmap.Width, neueBitmap.Height), 0, 0, neueBitmap.Width, neueBitmap.Height,
                GraphicsUnit.Pixel, imageAttributes);
            kontrastPicturebox.Image = neueBitmap;
        }        

    //------------------------------------------------------------------------------------------------
    //Steuerung des Kontrasts                 
        private void anwendenTrackBarButton_Click(object sender, EventArgs e)
        {
            //Textbox auswerten und Wert speichern
            string einlesen = anwendenTextBox.Text;

            try
            {
                //Wert aus der Textbox einlesen
                float eingabeKontrast = (float)Convert.ToDouble(einlesen);

                kontrastTrackBar.Value = (int)eingabeKontrast;

                //Wert umrechnen
                if (eingabeKontrast == 0)
                    kontrastwert = 1;
                else if (eingabeKontrast > 0)
                {
                    kontrastwert = 1+eingabeKontrast * 0.04f;
                }
                else
                {
                    kontrastwert = 1 -(-eingabeKontrast * 0.01f);
                }

                //Berechnung im Hintergrund ausführen
                if (!kontrastBerechnungBW.IsBusy)   //verhindert Zugriffsprobleme
                {
                    kontrastBerechnungBW.RunWorkerAsync();
                    Cursor = Cursors.WaitCursor;
                }
            }
            catch
            {
                MessageBox.Show("Bitte einen Wert zwischen -100 und 100 eingeben");
            }
        }
        private void kontrastBerechnungBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private void kontrastBerechnungBW_DoWork(object sender, DoWorkEventArgs e)
        {
            kontrastBerechnen();
        }
        private void kontrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            anwendenTextBox.Text = kontrastTrackBar.Value.ToString();
        }

    //------------------------------------------------------------------------------------------------
    //Speichern + abbrechen
        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            kontrastPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }
        private void speichernButton_Click(object sender, EventArgs e)
        {
            parent.setAndSavePictureBox((Bitmap)kontrastPicturebox.Image);

            kontrastPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }

        private void kontrast_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kritischen Bereich freigeben
            kontrSem.Release();

            //hauptfenster wieder freigeben
            parent.unlockMainWindow();
        }              

    //------------------------------------------------------------------------------------------------
    //Kommentare
         /* Da die Funktion zur Konrastberechnung keine Schleife ist, weiß ich noch nicht wie ich die Bar
          * incrementieren soll.
         * 
         * Der Schieberegler arbeitet in einem Zahlenraum von 0 bis 100, die Mitte liegt auf 50. Für die Kontrast-
         * berechnung werden diese Werte in den Funktionen anwendenButtonClick und kontrastTrackBar_Valuechanged
         * modifieziert und mit den Modifizierten Werten dann die Funktion kontrastBerechnen() aufgerufen.
         * 
         * Wird am Schieberegler etwas geändert, ändert sich auch der Wert in der TextBox, und umgekehrt.
         * 
         * Mit abbrechen wird der GC aufgerufen und die bisherigen Änderungen werden verworfen
         * 
         * Mit Speichern wird der PictureBox im Hauptfenster (hauptfenster.bildPictureBox) das geänderte Bild übergeben. Innerhalb
         * dieser Funktion wird dann auch der zwischenschritt gespeichert, daher muss diese Funktion an dieser Stelle nicht
         * mehr aufgerufen werden.
         * 
         */
    }
}
