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
    public partial class kontrast : Form
    {
        public kontrast(Bitmap bitmap_in, form1 parent_in)
        {
            InitializeComponent();

            //aus dieser form heraus wurde kontrast aufgerufen
            parent = parent_in;

            //Bild in PictureBox öffnen
            kontrastPicturebox.Image = bitmap_in;
        }
    //------------------------------------------------------------------------------------------------
    //Globale Variablen
        form1 parent;

    //------------------------------------------------------------------------------------------------
    //Kontrast        
        private void kontrastBerechnen()
        {
            
        }
    }
}
