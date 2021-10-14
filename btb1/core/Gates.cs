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
            return new Bit(!input.Value);
        }


        /// <summary>
        /// https://en.wikipedia.org/wiki/AND_gate
        /// </summary>
        public static Bit And(this Bit inputA, Bit inputB)
        {
            var bFalse = new Bit(false);
            var bTrue = new Bit(true);

            if ((inputA == bFalse) && (inputB == bFalse))
                return bFalse;
            else if ((inputA == bTrue) && (inputB == bFalse))
                return bFalse;
            else if ((inputA == bFalse) && (inputB == bTrue))
                return bFalse;
            else if ((inputA == bTrue) && (inputB == bTrue))
                return bTrue;
            else
                throw new InvalidOperationException("AndGate input´s are not in truth table.");
        }



        /// <summary>
        /// https://en.wikipedia.org/wiki/OR_gate
        /// </summary>
        public static Bit Or(this Bit inputA, Bit inputB)
        {
            var bFalse = new Bit(false);
            var bTrue = new Bit(true);

            if ((inputA == bFalse) && (inputB == bFalse))
                return bFalse;
            else if ((inputA == bTrue) && (inputB == bFalse))
                return bTrue;
            else if ((inputA == bFalse) && (inputB == bTrue))
                return bTrue;
            else if ((inputA == bTrue) && (inputB == bTrue))
                return bTrue;
            else
                throw new InvalidOperationException("OrGate input´s are not in truth table.");
        }
    }
}
