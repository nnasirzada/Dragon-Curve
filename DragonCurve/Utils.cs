using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCurve
{
    public static class Utils
    {
        // Convert degrees to radians
        public static double Sin(int angle)
        {
            return Math.Sin(angle * Math.PI / 180);
        }

        // Convert degrees to radians
        public static double Cos(int angle)
        {
            return Math.Cos(angle * Math.PI / 180);
        }
    }
}
