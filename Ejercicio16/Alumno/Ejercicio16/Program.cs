using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bibliotecaEj16;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno0 = new Alumno("Nahuel","Barrios",1);
            Alumno alumno1 = new Alumno("Candelaria", "Scanavino", 2);
            Alumno alumno2 = new Alumno("Walter", "Barrios", 3);

            alumno0.Estudiar(6, 6);
            alumno1.Estudiar(7, 6);
            alumno2.Estudiar(3, 7);

            alumno0.CalcularFinal();
            alumno1.CalcularFinal();
            alumno2.CalcularFinal();

            alumno0.Mostrar();
            alumno1.Mostrar();
            alumno2.Mostrar();

            Console.ReadKey();
        }
    }
}
