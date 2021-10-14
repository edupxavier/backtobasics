using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public static class Gates
    {
        /// <summary>
        /// https://en.wikipedia.org/wiki/NOT_gate
        /// </summary>
        public static Bit Not(this Bit input)
        {
            if (input == Bit.bFalse)
                return Bit.bTrue;
            else if (input == Bit.bTrue)
                return Bit.bFalse;
            else
                throw new InvalidOperationException("NotGate input is not in truth table.");
        }


        /// <summary>
        /// https://en.wikipedia.org/wiki/AND_gate
        /// </summary>
        public static Bit And(this Bit inputA, Bit inputB)
        {
            if ((inputA == Bit.bFalse) && (inputB == Bit.bFalse))
                return Bit.bFalse;
            else if ((inputA == Bit.bTrue) && (inputB == Bit.bFalse))
                return Bit.bFalse;
            else if ((inputA == Bit.bFalse) && (inputB == Bit.bTrue))
                return Bit.bFalse;
            else if ((inputA == Bit.bTrue) && (inputB == Bit.bTrue))
                return Bit.bTrue;
            else
                throw new InvalidOperationException("AndGate input´s are not in truth table.");
        }



        /// <summary>
        /// https://en.wikipedia.org/wiki/OR_gate
        /// </summary>
        public static Bit Or(this Bit inputA, Bit inputB)
        {
            if ((inputA == Bit.bFalse) && (inputB == Bit.bFalse))
                return Bit.bFalse;
            else if ((inputA == Bit.bTrue) && (inputB == Bit.bFalse))
                return Bit.bTrue;
            else if ((inputA == Bit.bFalse) && (inputB == Bit.bTrue))
                return Bit.bTrue;
            else if ((inputA == Bit.bTrue) && (inputB == Bit.bTrue))
                return Bit.bTrue;
            else
                throw new InvalidOperationException("OrGate input´s are not in truth table.");
        }
    }
}
