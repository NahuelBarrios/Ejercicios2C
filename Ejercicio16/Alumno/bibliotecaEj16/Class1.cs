using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaEj16
{
    public class Alumno
    {
        /// <summary>
        /// Campos
        /// </summary>
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        string apellido;
        int legajo;
        string nombre;

        /// <summary>
        /// Constructores
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="legajo"></param>
        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        ///<summary>
        /// Metodos
        /// </summary>
            
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random nroGenerado = new Random();
                this.notaFinal = nroGenerado.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} {1} {2}",this.legajo,this.apellido,this.nombre);
            Console.WriteLine("Nota1: {0} Nota2: {1}",this.nota1,this.nota2);
            
            if(this.notaFinal != -1)
            {
                Console.WriteLine("Nota final: {0}",this.notaFinal);
            }
            else
            {
                Console.WriteLine("Alumno desaprobado");
            }

        }

    }
}
