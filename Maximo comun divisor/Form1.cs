using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maximo_comun_divisor
{
    public partial class Form1 : Form
    {
        private calcular_Comun_Divirsor calculadora;

        public Form1()
        {
            InitializeComponent();
            calculadora = new calcular_Comun_Divirsor();
        }


        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(numero_1.Text);
                int numero2 = int.Parse(numero_2.Text);
                int resultado = calculadora.calcularMDC(numero1, numero2);
                Resultado.Text = ($"El MCD del numero {numero1} y del numero {numero2} es: {resultado} ");

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce numero validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Instruccion_1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numero_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
