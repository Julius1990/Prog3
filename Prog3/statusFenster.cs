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
    public partial class statusFenster : Form
    {
        public statusFenster()
        {
            InitializeComponent();            
        }

        public void keepBusy()
        {
            if (progressBar1.Value > 9999)
            {
                progressBar1.Value = 0;
            }
            progressBar1.Increment(1);            
        }
    }
}
