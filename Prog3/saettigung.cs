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
    public partial class saettigung : Form
    {
        form1 parent;
        Bitmap pictureBackup;

        public saettigung(Bitmap bm, form1 parent_in)
        {
            InitializeComponent();
            saettigungPicturebox.Image = bm;
            pictureBackup = bm;
            parent = parent_in;
            this.Show();
        }

        //Die folgende Funktion wurde übernommen von: http://www.geekymonkey.com/Programming/CSharp/RGB2HSL_HSL2RGB.htm (16.5.14)

        private static Color hsl2rgb(double h, double sl, double l)
        {
            double v;
            double r, g, b;

            r = l;   // default to gray
            g = l;
            b = l;
            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);

            if (v > 0)
            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;

                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }

            Color rgb = Color.FromArgb(Convert.ToByte(r * 255.0f), Convert.ToByte(g * 255.0f), Convert.ToByte(b * 255.0f));
            return rgb;
        }


        private void changeSaturation(double factor)
        {
            Color newColor, oldColor;
            int width, height, i, j = 0;
            Bitmap helpMap = pictureBackup;
            width = helpMap.Width;
            height = helpMap.Height;
            Bitmap newMap = new Bitmap(width, height);

            while (j < height)      //Schleife zum durchlaufen der Bitmap in der  Breite
            {
                for (i = 0; i < width; i++)     //Schleife zum durchlaufen der Bitmap in der Höhe
                {
                    oldColor = helpMap.GetPixel(i, j);
                    if ((oldColor.GetSaturation() * factor) > 1.0)
                    {
                        newColor = hsl2rgb(oldColor.GetHue() / 360, 1.0, oldColor.GetBrightness());
                    }
                    else
                    {
                        newColor = hsl2rgb(oldColor.GetHue() / 360, oldColor.GetSaturation() * factor, oldColor.GetBrightness());
                    }
                    newMap.SetPixel(i, j, newColor);

                }
                j++;        //Laufvariable inkrementieren
            }
            saettigungPicturebox.Image = newMap;
        }

        

        private void saettTrackBar_ValueChanged_1(object sender, EventArgs e)
        {
            if (saettTrackBar.Value < 0)
            {
                anwendenTextBox.Text = (-(1.0 / saettTrackBar.Value)).ToString();
                
            }
            else
            {
                anwendenTextBox.Text = saettTrackBar.Value.ToString();
            }
        }

        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            saettigungPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            parent.setAndSavePictureBox((Bitmap)saettigungPicturebox.Image);

            saettigungPicturebox.Image = null;
            GC.Collect();

            this.Close();
        }

        private void anwendenTrackBarButton_Click(object sender, EventArgs e)
        {
            changeSaturation(Convert.ToDouble(anwendenTextBox.Text));
        }
    }
}
