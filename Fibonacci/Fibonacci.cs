using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Fibonacci : Form
    {
        private FibonacciCalculator calculadora;

        public Fibonacci()
        {
            InitializeComponent();
            calculadora = new FibonacciCalculator();
        }

        private void boton_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(ingresar_valor.Text);
                List<int> serie = calculadora.CalcularSerieFibonacci(numero);
                respuesta.Text = $"Serie de Fibonacci hasta la posición {numero}: {string.Join(", ", serie)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se carga el formulario
        }

        private void Instrucción_Click(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se hace clic en un control llamado "Instrucción"
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se hace clic en un control llamado "Titulo"
        }

        private void ingresar_valor_TextChanged(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando el texto en el control "ingresar_valor" cambia
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se hace clic en un control llamado "resultado"
        }

        private void respuesta_Click(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se hace clic en un control llamado "respuesta"
        }
    }
}
