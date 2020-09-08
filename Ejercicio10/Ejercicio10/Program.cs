using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidacionEj11;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int exampleNumber;
            int valueMin=0;
            int valueMax = 0;
            int accumulator = 0;
            int average = 0;
            int count = 0;

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("Ingrese un numero del -100 al 100");
                string a = Console.ReadLine();
                int.TryParse(a, out exampleNumber);

                if (validacion.validated(exampleNumber, -100, 100) == true)
                {
                    if(i==1)
                    {
                        valueMin = exampleNumber;
                        valueMax = exampleNumber;
                    }
                    else
                    {
                        if(exampleNumber>valueMax)
                            valueMax = exampleNumber;

                        if (exampleNumber < valueMin)
                            valueMin = exampleNumber;
                    }
                    count++;
                    accumulator = accumulator + exampleNumber;
                }
            }
            average = accumulator / count;
            Console.WriteLine("Valor minimo: {0} , Valor maximo: {1} , Promedio: {2}",valueMin,valueMax,average);
            Console.ReadKey();

        }
    }
}
