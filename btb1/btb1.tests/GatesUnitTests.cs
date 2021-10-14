using core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace btb1.tests
{
    public class GatesUnitTests
    {
        [Fact]
        public void NotGate_of_false_bit_is_true()
        {
            var bFalse = new Bit(false);
            var bTrue = new Bit(true);

            Assert.Equal(bTrue, Gates.Not(bFalse));
        }


        [Fact]
        public void NotGate_of_true_bit_is_false()
        {
            var bFalse = new Bit(false);
            var bTrue = new Bit(true);

            Assert.Equal(bFalse, Gates.Not(bTrue));
        }


        [Fact]
        public void AndGate_check_truth_table()
        {
            var bFalse = new Bit(false);
            var bTrue = new Bit(true);

            Assert.Equal(bFalse, bFalse.And(bFalse));
            Assert.Equal(bFalse, bTrue.And(bFalse));
            Assert.Equal(bFalse, bFalse.And(bTrue));
            Assert.Equal(bTrue, bTrue.And(bTrue));

        }

        [Fact]
        public void OrGate_check_truth_table()
        {
            var bFalse = new Bit(false);
            var bTrue = new Bit(true);

            Assert.Equal(bFalse, bFalse.Or(bFalse));
            Assert.Equal(bTrue, bTrue.Or(bFalse));
            Assert.Equal(bTrue, bFalse.Or(bTrue));
            Assert.Equal(bFalse, bFalse.Or(bFalse));
            Assert.Equal(bTrue, bTrue.Or(bTrue));
        }
    }
}
