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
        public kontrast(form1 parent_in)
        {
            InitializeComponent();

            //aus dieser form heraus wurde kontrast aufgerufen
            parent = parent_in;

            //Bild in PictureBox öffnen
            kontrastPicturebox.Image = parent.getPictureBoxImage();

            kontrastwert = 1.0f;
        }
    //------------------------------------------------------------------------------------------------
    //Globale Variablen
        form1 parent;
        float kontrastwert;

    //------------------------------------------------------------------------------------------------
    //Kontrast berechnen       
        private void kontrastBerechnen()
        {
            Bitmap neueBitmap = new Bitmap(kontrastPicturebox.Image.Width, kontrastPicturebox.Image.Height);

            kontrastPicturebox.Image = null;
            GC.Collect();
             
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
        private void showAndEndInfo()
        {
            statusFenster neu = new statusFenster();
            neu.Show();
        }

    //------------------------------------------------------------------------------------------------
    //Steuerung des Kontrasts 
        private void anwendenButton_Click(object sender, EventArgs e)
        {
            string einlesen = anwendenTextBox.Text.ToString();
            float eingabeKontrast = (float)Convert.ToDouble(einlesen);

            kontrastwert = eingabeKontrast;
            
            kontrastTrackBar.Value = (int)(50.0f + ((float)eingabeKontrast/2.0f));
            kontrastBerechnen();

        }
        private void kontrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (kontrastTrackBar.Value > 50)
            {
                kontrastwert = 1.0f + ((float)kontrastTrackBar.Value - 50.0f) * 0.06f;
                anwendenTextBox.Text = (((float)kontrastTrackBar.Value - 50.0f)*2.0f).ToString();
            }
            else if (kontrastTrackBar.Value == 50)
            {
                kontrastwert = 1;
                anwendenTextBox.Text = "1";
            }
            else
            {
                kontrastwert = 1.0f - ((50.0f - (float)kontrastTrackBar.Value) * 0.02f);
                anwendenTextBox.Text = (-((50.0f-(float)kontrastTrackBar.Value)*2.0f)).ToString();
            }                       
        }
        private void anwendenTrackBarButton_Click(object sender, EventArgs e)
        {
            Thread meinThread = new Thread(kontrastBerechnen);
            meinThread.Start();
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
      


    //------------------------------------------------------------------------------------------------
    //Kommentare
        /* Das Panel auf der rechten Seite enthält noch eine Progress Bar. Da die Funktion zur Konrastberechnung
         * aber keine Schleife ist, weiß ich noch nicht wie ich die Bar incrementieren soll.
         * 
         * Der Schieberegler arbeitet in einem Zahlenraum von 0 bis 100, die Mitte liegt auf 50. Für die Kontrast-
         * berechnung werden diese Werte in den Funktionen anwendenButtonClick und kontrastTrackBar_Valuechanged
         * modifieziert und mit den Modifizierten Werten dann die Funktion kontrastBerechnen() aufgerufen.
         * 
         * Wird am Schieberegler etwas geändert, ändert sich auch der Wert in der TextBox, und umgekehrt.
         * 
         * Mit abbrechen wird der GC aufgerufen und die bisherigen Änderungen werden verworfen
         * 
         * Mit Speichern wird der PictureBox im Hauptfenster (form1.bildPictureBox) das geänderte Bild übergeben. Innerhalb
         * dieser Funktion wird dann auch der zwischenschritt gespeichert, daher muss diese Funktion an dieser Stelle nicht
         * mehr aufgerufen werden.
         * 
         */
    }
}
