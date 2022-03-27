using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MembrosEstaticos
{
    static class Esfera
    {
        public static double PI = 3.1415;

        public static double Circ(double r)
        {
            return 2.0 * (PI * r);
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * Math.Pow(r, 3.0);
        }
    }
}
