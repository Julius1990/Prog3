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
    public partial class grauwert : Form
    {
        //------------------------------------------------------------------------------------------------
        //Globale Variabeln  
        private PictureBox picBoxOld;
        form1 parent;
        //------------------------------------------------------------------------------------------------
        //Konstruktor  
        public grauwert(PictureBox pb, form1 parent_in){
            InitializeComponent();
            picBoxOld = pb;
            parent = parent_in;
            this.Show();
            createGreyValPic();
        }
        //------------------------------------------------------------------------------------------------
        //Grauwertbild berechnen  
        public void createGreyValPic(){
            Color oldColor, greyColor;
            Bitmap helpMap, greyMap;
            int width, height, i, j = 0, greyValue;

            try
            {
                helpMap = (Bitmap)picBoxOld.Image;   //Bitmap aus Bild in picBoxOld erstellen
                width = helpMap.Width;      //Bildbreite bestimmen
                height = helpMap.Height;    //Bildhöhe bestimmen
                greyMap = new Bitmap(width, height);        //Bitmap für das Grauwertbild erstellen
                grauwertProgressBar.Maximum = height;
                //parent.setProBarMax(height);      //Maximum der Progressbar festlegen
grauwertProgressBar.Maximum = height; //JULIUS
grauwertProgressBar.Visible = true; //JULIUS
                while (j < height)      //Schleife zum durchlaufen der Bitmap in der  Breite
                {
                    for (i = 0; i < width; i++)     //Schleife zum durchlaufen der Bitmap in der Höhe
                    {
                        oldColor = helpMap.GetPixel(i, j);      //Farbwert bestimmen
                        greyValue = (int) (0.3 * oldColor.R + 0.6 * oldColor.G + 0.1 * oldColor.B);     //Grauwert berechnen
                        greyColor = Color.FromArgb(greyValue, greyValue, greyValue);        //Colorvariable aus Grauwert erzeugen
                        greyMap.SetPixel(i, j, greyColor);      //Farbe(Grau) setzen
                    }
                    j++;        //Laufvariable inkrementieren
grauwertProgressBar.Increment(1);//Julius
                    //parent.incProBar();      //Fortschritt der Progressbar erhöhen
                }
                grauwertPicturebox.Image = greyMap;      //Grauwertbild anzeigen
                grauwertProgressBar.Value = 0;
                //parent.setProBarToZero();     //Progressbar leeren
            }
            catch
            {
                MessageBox.Show("Bitte öffnen Sie ein Bild bevor Sie diese Funktion nutzen!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);     //Ausgabe bei Exception
            }
            GC.Collect();       //Garbage Collection auslösen
        }
        //------------------------------------------------------------------------------------------------
        //Klickevents  
        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            grauwertPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            parent.setAndSavePictureBox((Bitmap)grauwertPicturebox.Image);

            grauwertPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }



    }
}
