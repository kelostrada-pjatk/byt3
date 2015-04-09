using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Substraction : Operation
    {
        protected override OperationType OperationType
        {
            get { return OperationType.Substract; }
        }

        protected override decimal Calculate(decimal x, decimal y)
        {
            return x - y;
        }
    }
}
