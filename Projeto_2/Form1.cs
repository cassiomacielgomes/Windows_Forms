using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Form_Saudacao : Form
    {
        public Form_Saudacao()
        {
            InitializeComponent();
        }

        private void button_exibir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Olá {textBox_nome.Text}");

            string nome = textBox_nome.Text;
            MessageBox.Show($"Olá {nome}",
                    "Título da Resposta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
        }
    }
}
