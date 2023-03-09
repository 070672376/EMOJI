using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMOJI
{
    public partial class Form5 : Form
    {
        public static Form1 F1;
        public Form5(Form1 f1)
        {
            InitializeComponent();
            F1 = f1;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.F5 = null;
        }
    }
}
