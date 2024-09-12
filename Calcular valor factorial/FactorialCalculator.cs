using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_valor_factorial
{
    public class FactorialCalculator
    {
        public int CalcularFactorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("El numero debe se mayor a cero o igual a cero.");
            }

            int resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
