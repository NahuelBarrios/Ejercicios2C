using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;

            Console.WriteLine("Ingrese un numero base:");
            string a = Console.ReadLine();
            double.TryParse(a, out number1);

            Console.WriteLine("Ingrese un numero altura(Para calcular triangulo):");
            a = Console.ReadLine();
            double.TryParse(a, out number2);


            Console.WriteLine("Cuadrado: {0}",CalculoDeArea.CalcularCuadrado(number1));
            Console.WriteLine("Triangulo: {0}", CalculoDeArea.CalcularTriangulo(number1,number2));
            Console.WriteLine("Circulo: {0}", CalculoDeArea.CalcularCirculo(number1));

            Console.ReadKey();
        }
    }
}
