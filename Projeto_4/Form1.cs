using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbxProcessoTecnica_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.SteelBlue, Color.WhiteSmoke);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor, Color backgroundColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Coloque a cor do background aqui
                g.Clear(backgroundColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 190);
            groupBox2.Visible = false;
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            //Limpar
            //textBox_nome.Text = "";
            textBox_nome.Clear();
            //comboBox_destino.Text = "";
            comboBox_destino.Text = string.Empty;
            radioButton_aviao.Checked = false;
            radioButton_onibus.Checked = false;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            //Confirmar
            if(textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite seu nome!");
                textBox_nome.Focus();
            }

            if(comboBox_destino.Text == "")
            {
                MessageBox.Show("Destino não selecionado!");
                comboBox_destino.Focus();
            }

            if(radioButton_aviao.Checked == false && radioButton_onibus.Checked == false)
            {
                MessageBox.Show("Meio de Transporte não selecionado!");
                radioButton_aviao.Focus();
            }

        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            //CALCULAR

            double gasto_destino, gasto_transporte, gasto_total;
             
            //Destino
            switch (comboBox_destino.Text.ToUpper())
            {
                case "SP":
                    gasto_destino = 1000;
                    break;
                case "RJ":
                    gasto_destino = 1500;
                    break;
                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                    break;
            }

            //Meio de Transporte
            if(radioButton_aviao.Checked == true)
            {
                gasto_transporte = 100;
            }
            else
            {
                gasto_transporte = 30;
            }

            //Calculo Valor Total
            gasto_total = gasto_transporte + gasto_destino;

            //Redimensionamento
            this.ClientSize = new System.Drawing.Size(640, 300);
            groupBox2.Visible = true;

            //Exibir
            label_gastoTransp.Text = gasto_transporte.ToString("F2");
            label_gastoDest.Text = gasto_destino.ToString("F2");
            label_valorTotal.Text = gasto_total.ToString("F2");
            //C2 = O ponto no milhar e R$

        }   
    }
}