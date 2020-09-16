using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void Soma_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if (txtValor1.Text == "")
            {
                MessageBox.Show("Informe o primeiro Valor");
            }

            else
            {
                if (txtValor2.Text == "")
                {
                    MessageBox.Show("Informe o segundo Valor");
                }


                else
                {

                    Valor1 = Convert.ToDouble(txtValor1.Text);
                    Valor2 = Convert.ToDouble(txtValor2.Text);
                    Resultado = (Valor1 + Valor2);

                    Result.Text = Resultado.ToString();
                }
            }
        }

        private void Subtrcao_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if (txtValor1.Text == "")
            {
                MessageBox.Show("Informe o primeiro Valor");
            }

            else
            {
                if (txtValor2.Text == "")
                {
                    MessageBox.Show("Informe o segundo Valor");
                }


                else
                {

                    Valor1 = Convert.ToDouble(txtValor1.Text);
                    Valor2 = Convert.ToDouble(txtValor2.Text);
                    Resultado = (Valor1 - Valor2);

                    Result.Text = Resultado.ToString();
                }
            }
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if (txtValor1.Text == "")
            {
                MessageBox.Show("Informe o primeiro Valor");
            }

            else
            {
                if (txtValor2.Text == "")
                {
                    MessageBox.Show("Informe o segundo Valor");
                }


                else
                {

                    Valor1 = Convert.ToDouble(txtValor1.Text);
                    Valor2 = Convert.ToDouble(txtValor2.Text);
                    Resultado = (Valor1 / Valor2);

                    Result.Text = Resultado.ToString();

                }
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if (txtValor1.Text == "")
            {
                MessageBox.Show("Informe o primeiro Valor");
            }

            else
            {
                if (txtValor2.Text == "")
                {
                    MessageBox.Show("Informe o segundo Valor");
                }


                else
                {

                    Valor1 = Convert.ToDouble(txtValor1.Text);
                    Valor2 = Convert.ToDouble(txtValor2.Text);
                    Resultado = (Valor1 * Valor2);

                    Result.Text = Resultado.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
