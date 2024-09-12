using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximo_comun_divisor
{
    public class calcular_Comun_Divirsor
    {
        public int calcularMDC(int a, int b)
        {
            if (b == 0)
                return a;
            return calcularMDC(b, a % b);
        }
    }

}
