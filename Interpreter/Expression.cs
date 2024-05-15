﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public abstract class Expression
    {
        public abstract double Interpret(Dictionary<string, double> context);
    }
}
