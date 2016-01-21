using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Helpers
{
    public class Guard
    {
        public static void ForNullOrEmpty(string value, string msgErro)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception(msgErro);
        }

        public static void StringLength(string msgErro, string value, int length)
        {
            if (value.Length > length)
                throw new Exception(msgErro);
        }
    }
}
