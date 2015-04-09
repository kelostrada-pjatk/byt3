using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division : Operation
    {
        protected override OperationType OperationType
        {
            get { return OperationType.Divide; }
        }

        protected override decimal Calculate(decimal x, decimal y)
        {
            if (y == 0) throw new DivideByZeroException();
            return x / y;
        }
    }
}
