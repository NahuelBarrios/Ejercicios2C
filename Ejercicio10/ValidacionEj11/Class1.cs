using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionEj11
{
    public class validacion
    {
        public static bool validated(int valor, int min, int max)
        {
            bool retorn = false;

            if(valor>=min && valor<=max)
            {
                retorn = true;
            }
            return retorn;
        }

    }
}
