﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    struct Equation
    {
        double k;
        double b;
        public Equation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public double Root()
        {
            double res = -b / k;
            return res;
        }
    }
}
