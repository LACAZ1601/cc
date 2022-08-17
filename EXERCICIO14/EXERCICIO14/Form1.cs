using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);

            if (n1 > n2)
            {
                txtResultado.Text = n1.ToString();
            }
            else
            {
                txtResultado.Text = n2.ToString();

            }
        }
}
