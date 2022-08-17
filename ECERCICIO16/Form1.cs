using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECERCICIO16
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
            double n3;
            double media;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);

            media = (n1 + n2 + n3) / 3;

            txtMedia.Text = media.ToString();

            if (media >= 7)
            {
                txtResultado.Text = "APROVADO";

            }
            else
            {
                txtResultado.Text = "RECUPERAÇÃO";
            }
            if (media <= 5)
            {
                txtResultado.Text = "REPROVADO";
            }

        }
    }
}
