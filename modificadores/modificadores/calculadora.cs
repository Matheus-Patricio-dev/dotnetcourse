using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadores
{
    class calculadora
    {

        public static void Triple(ref int x)
        {
            x = x * x;
        }
        public static void Double(int origin, out int result)
        {
            result = origin * 10;
        }

    }
}
