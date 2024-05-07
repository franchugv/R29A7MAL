using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R29A7
{
    public static class UI
    {
        private static void MostrarResutadoPrimos(float num, string text)
        {
            string cadena = Convert.ToString(num);

            MessageBox.Show($"{cadena} {text}", "Números Primos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void RealizarValidacionPrimos(string numCadena)
        {
            float num = Convert.ToSingle(numCadena);

            if (LogicaNegocio.ValidarPrimos(num) == true) MostrarResutadoPrimos(num, "es Primo");
            else MostrarResutadoPrimos(num, "no es Primo");
        }
    }
}
