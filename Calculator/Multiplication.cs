﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Multiplication : Calculator
    {
        public override float Answer(float number1, float number2)
        {
            return number1 * number2;
        }
    }
}
