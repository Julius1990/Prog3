using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class negativ : Form
    {
        private PictureBox picBoxOld;
        private form1 parent;

        public negativ(PictureBox pb, form1 parent_in)
        {
            InitializeComponent();
            picBoxOld = pb;
            parent = parent_in;
            this.Show();
            createInvertedPic();
        }

        public void createInvertedPic(){
        Color oldColor, invertedColor;
            Bitmap helpMap, invertedMap;
            int r, g, b, width, height, i, j = 0;

            try
            {
                helpMap = (Bitmap)picBoxOld.Image;      //Bitmap aus Bild in picBoxOld erstellen
                width = helpMap.Width;      //Bildbreite bestimmen
                height = helpMap.Height;    //Bildhöhe bestimmen
                invertedMap = new Bitmap(width, height);    //Bitmap für das invertierte Bild erstellen

                negativProgressBar.Maximum = height;      //Maximum der Progressbar festlegen

                while (j < height)      //Schleife zum durchlaufen der Bitmap in der  Breite
                {
                    for (i = 0; i < width; i++)     //Schleife zum durchlaufen der Bitmap in der Höhe
                    {
                        oldColor = helpMap.GetPixel(i, j);      //Farbwert bestimmen
                        r = 255 - oldColor.R;       //Farbwerte invertieren
                        g = 255 - oldColor.G;       //
                        b = 255 - oldColor.B;       //
                        invertedColor = Color.FromArgb(r, g, b);        //Colorvariable aus invertierten Farbwerten erstellen
                        invertedMap.SetPixel(i, j, invertedColor);      //Farbe setzen
                    }
                    j++;        //Laufvariable inkrementieren
                    negativProgressBar.Increment(1);      //Fortschritt der Progressbar erhöhen
                }
                negativPicturebox.Image = invertedMap;      //Invertiertes Bild anzeigen
                negativProgressBar.Value = 0;     //Progressbar leeren
            }
            catch
            {
                MessageBox.Show("Bitte öffnen Sie ein Bild bevor Sie diese Funktion nutzen!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Ausgabe bei Exception
            }
            GC.Collect();      //Auslösen der Garbage Collection
        }

        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            negativPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            parent.setAndSavePictureBox((Bitmap)negativPicturebox.Image);

            negativPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }
    }
}
