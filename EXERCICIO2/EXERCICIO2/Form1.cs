using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SOMAR_Click(object sender, EventArgs e)
        {
            double a, b, r;
            a = (Convert.ToDouble(T1.Text));
            b = (Convert.ToDouble(T2.Text));
            r = a + b;

            R1.Text = Convert.ToString(r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, r;
            a = (Convert.ToDouble(T1.Text));
            b = (Convert.ToDouble(T2.Text));
            r = a * b;

            R1.Text = Convert.ToString(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, r;
            a = (Convert.ToDouble(T1.Text));
            b = (Convert.ToDouble(T2.Text));
            r = a / b;

            R1.Text = Convert.ToString(r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, r;
            a = (Convert.ToDouble(T1.Text));
            b = (Convert.ToDouble(T2.Text));
            r = a - b;

            R1.Text = Convert.ToString(r);
        }
    }
}
