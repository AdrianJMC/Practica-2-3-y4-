using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_valor_factorial
{
    public partial class Form1 : Form
    {
        private FactorialCalculator calculadora;
        public Form1()
        {
            InitializeComponent();
            calculadora = new FactorialCalculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox1.Text);
                int resultado = calculadora.CalcularFactorial(numero);
                label4.Text = $"El factoria de {numero} es {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor,introduce un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
