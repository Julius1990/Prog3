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
        }

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
                    bildPicturebox.Image = Image.FromFile(bildOeffnenDialog.FileName);
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
            this.Close();
        }
    
    }
}
