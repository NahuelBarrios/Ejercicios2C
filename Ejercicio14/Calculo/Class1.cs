using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double number)
        {
            double retorn;

            retorn = number * number;

            return retorn;
        }

        public static double CalcularTriangulo(double baseA,double altura)
        {
            double retorn;

            retorn = (baseA * altura) / 2;

            return retorn;
        }

        public static double CalcularCirculo(double number)
        {
            double retorn;

            retorn = 3.14 * Math.Pow(number,2);

            return retorn;
        }
    }
}
