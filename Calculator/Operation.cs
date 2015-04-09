using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum OperationType
    {
        Add,
        Substract,
        Multiply,
        Divide
    }

    public abstract class Operation
    {
        protected Operation Next;
        protected abstract OperationType OperationType { get; }

        protected abstract decimal Calculate(decimal x, decimal y);

        public Operation SetNext(Operation operation)
        {
            Next = operation;
            return operation;
        }

        public decimal MakeCalculation(decimal x, decimal y, OperationType type)
        {
            if (type == OperationType)
            {
                return Calculate(x,y);
            }

            if (Next != null)
            {
                return Next.MakeCalculation(x, y, type);
            }

            throw new Exception("Calculation not possible.");
        }

    }
}
