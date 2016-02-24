using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Helpers
{
    public class TextoHelper
    {
        public static string GetNumeros(string texto)
        {
            return String.IsNullOrEmpty(texto) ? String.Empty : new String(texto.Where(Char.IsDigit).ToArray());
        }
    }
}
