using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciCalculator
    {
        public int CalcularFibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("El índice no puede ser negativo.");
            }

            if (n == 0) return 0;
            if (n == 1) return 1;

            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }

        public List<int> CalcularSerieFibonacci(int n)
        {
            List<int> serie = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                serie.Add(CalcularFibonacci(i));
            }

            return serie;
        }
    }
}

