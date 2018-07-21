using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            string sexo = txtSexo.Text;
            double peso = Convert.ToDouble(txtPeso.Text);

            int valor = 239;

            //CONSTANTES DE VALORES FEMININOS
            double valorFeminino1 = 0.047;
            double valorFeminino2 = 2.951;
            double valorFeminino3 = 0.048;
            double valorFeminino4 = 2.562;

            //CONSTANTES DE VALORES MASCULINOS
            double valorMasculino1 = 0.084;
            double valorMasculino2 = 2.122;
            double valorMasculino3 = 0.056;
            double valorMasculino4 = 2.800;

            double resultadoTMB = 0;
            double resultadoGET = 0;

            if (sexo == "F" || sexo == "f")
            {
                if (idade >= 12 && idade <= 18) 
                {
                    resultadoTMB = (((valorFeminino1 * peso) + valorFeminino2) * valor);
                    txtResultadoTMB.Text = String.Format("{0:N}", resultadoTMB);
                } else
                {
                    if (idade == 19)
                    {
                        resultadoTMB = (((valorFeminino3 * peso) + valorFeminino4) * valor);
                        txtResultadoTMB.Text = String.Format("{0:N}", resultadoTMB);
                    }
                }
            }

            if (sexo == "M" || sexo == "m")
            {
                if (idade >= 12 && idade <= 18)
                {
                    resultadoTMB = (((valorMasculino1 * peso) + valorMasculino2) * valor);
                    txtResultadoTMB.Text = String.Format("{0:N}", resultadoTMB);
                }
                else
                {
                    if (idade == 19)
                    {
                        resultadoTMB = (((valorMasculino3 * peso) + valorMasculino4) * valor);
                        txtResultadoTMB.Text = String.Format("{0:N}", resultadoTMB);
                    }
                }
            }
        }
    }
}
