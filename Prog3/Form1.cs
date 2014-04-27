using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
