using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO013
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

            n1 = double.Parse(txtN1.Text);

            if (n1 > 10)
            {
                txtResultado.Text = "Este número é maior que 10";
            }
            else
            {
                txtResultado.Text = n1.ToString();

            }
        }
}
