using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class MultiplyExpression : Expression
    {
        private Expression _expr1;
        private Expression _expr2;

        public MultiplyExpression(Expression expr1, Expression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public override double Interpret(Dictionary<string, double> context)
        {
            return _expr1.Interpret(context) * _expr2.Interpret(context);
        }
    }
}
