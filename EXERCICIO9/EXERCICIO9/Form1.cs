using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double VD;
            double VJ;

            VD = double.Parse(txt1.Text);

            VJ = VD + (VD * 7) / 1000;

            txt2.Text = VJ.ToString();
        }
    }
}
