﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCurve
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return "X: " + X + ", Y: " + Y;
        }
    }
}
