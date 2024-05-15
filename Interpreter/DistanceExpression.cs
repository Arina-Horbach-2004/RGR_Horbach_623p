using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class DistanceExpression : Expression
    {
        private double _distance;

        public DistanceExpression(double distance)
        {
            _distance = distance;
        }

        public override double Interpret(Dictionary<string, double> context)
        {
            return _distance;
        }
    }      
}
