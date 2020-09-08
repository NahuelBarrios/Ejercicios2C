using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class  Calculadorinador
    {
        public static int Calculador(int numberA, int numberB, string operation)
        {
            int resultado = 0;

            if (operation == "+")
            {
                resultado = numberA + numberB;
            }
            else if (operation == "-")
            {
                resultado = numberA - numberB;
            }
            else if (operation == "*")
            {
                resultado = numberA * numberB;
            }
            else if (operation == "/")
            {
                if (Validar(numberB) == false)
                {
                    resultado = numberA / numberB;
                }
            }
            return resultado;
        }

        private static bool Validar(int numero)
        {
            bool retorn = false;

            if (numero == 0)
            {
                retorn = true;
            }
            return retorn;
        }
    }
}
