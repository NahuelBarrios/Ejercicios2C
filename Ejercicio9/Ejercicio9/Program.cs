using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int ateriscos = 0;

            Console.WriteLine("Ingrese la altura que desee para generar su piramide: ");
            string a = Console.ReadLine();
            int.TryParse(a, out altura);

            while(ateriscos <= altura)
            {
                ateriscos++;
                for(int j = 1; j< ateriscos; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }

            Console.ReadKey();
        }
    }
}
