using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class RatePerKmExpression : Expression
    {
        private double _rate;

        public RatePerKmExpression(double rate)
        {
            _rate = rate;
        }

        public override double Interpret(Dictionary<string, double> context)
        {
            return _rate;
        }
    }
}
