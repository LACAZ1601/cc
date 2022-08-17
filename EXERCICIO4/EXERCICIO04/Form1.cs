using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_button_Click_Click(object sender, EventArgs e)
        {
            if (alunoTextBox.Text == "") ;
            {
                MessageBox.Show("O Campo nome é obrigatório", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (materiaCombobox.SelectedIndex == -1) ;
            MessageBox.Show("Selecione uma matéria", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
            if (bimestre1TextBox.Text == "");

            {
            MessageBox.Show("Digite o valor do 1 bimestre", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
    {
            if (alunoTextBox.Text == "") ;
        }

            MessageBox.Show("Digite o valor do 2 bimestre", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            

}
    }
}
