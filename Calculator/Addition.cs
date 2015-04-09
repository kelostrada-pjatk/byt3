using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition : Operation
    {
        protected override OperationType OperationType
        {
            get { return OperationType.Add; }
        }

        protected override decimal Calculate(decimal x, decimal y)
        {
            return x + y;
        }
    }
}
