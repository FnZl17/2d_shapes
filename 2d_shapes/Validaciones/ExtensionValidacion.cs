using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shapes.Validaciones
{
    public static class ExtensionesValidacion
    {
        public static double ValidarNumero(this string texto)
        {
            return double.TryParse(texto, out double resultado) ? resultado : 0;
        }

        public static double AsegurarMinimo(this double valor, double minimo)
        {
            return Math.Max(valor, minimo);
        }
    }
}