using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R29A7
{
    public static class LogicaNegocio
    {
        public static bool ValidarPrimos(float num1)
        {
            // Recursos

            int contador = 2;

            string aux = "";

            bool esCorrecto = true;



            for (contador = 2; contador < num1 && esCorrecto; contador++)
            {
                if (num1 % contador == 0)
                {
                    esCorrecto = false;
                }
            }


            return esCorrecto;
        }
    }
}
