using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA;
            int numberB;
            string operation;
            string continuar;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                string a = Console.ReadLine();
                int.TryParse(a, out numberA);

                Console.WriteLine("Ingrese un numero: ");
                a = Console.ReadLine();
                int.TryParse(a, out numberB);

                Console.WriteLine("Ingrese la operacion que desea realizar: ");
                operation = Console.ReadLine();

                if(operation == "/" && numberB == 0)
                {
                    Console.WriteLine("No se puede dividir por 0");
                }
                else
                {
                    Console.WriteLine("el resultado es: {0}", Calculadorinador.Calculador(numberA, numberB, operation));
                }
           
                Console.WriteLine("Desea continuar? SI/NO");
                continuar = Console.ReadLine();

            } while (continuar != "NO");

            Console.ReadKey();
        }
    }
}
