using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double custoFab;
            double imp;
            double distri;
            double custoConsu;

            custoFab = double.Parse(label1.Text);

            
            imp = (custoFab * 45) / 100;
            
            distri = (imp * 28) / 100;
           
            custoConsu = custoFab + distri + imp;

            label2.Text = custoConsu.ToString();
        }
    }
}
