using core;
using System;
using Xunit;

namespace btb1.tests
{
    public class BitUnitTests
    {
        [Fact]
        public void Bit_can_instantiate()
        {
            var b = new Bit();
            Assert.NotNull(b);
        }

        [Fact]
        public void Bit_starts_with_value_false()
        {
            var b = new Bit();
            Assert.False(b.Value);
        }

        [Fact]
        public void Bit_can_change_value()
        {
            var b = new Bit();
            Assert.False(b.Value);
            b.Value = true;
            Assert.True(b.Value);
            b.Value = !b.Value;
            Assert.False(b.Value);
        }


        [Fact]
        public void Bit_compares_values_not_instances()
        {
            var b1 = new Bit();
            b1.Value = true;
            var b2 = new Bit();
            b2.Value = false;
            var b3 = new Bit();
            b3.Value = true;

            Assert.Equal(b1, b3);
            Assert.NotEqual(b1, b2);
            Assert.NotEqual(b3, b2);

            Assert.True(b1 == b3);
            Assert.True(b1 != b2);
            Assert.True(b3 != b2);

            var b1ref = b1;
            var b2ref = b2;
            var b3ref = b3;

            Assert.Equal(b1ref, b3ref);
            Assert.NotEqual(b1ref, b2ref);
            Assert.NotEqual(b3ref, b2ref);

            Assert.True(b1ref == b3);
            Assert.True(b1ref != b2);
            Assert.True(b3ref != b2);
        }


        [Fact]
        public void ToString_of_false_value_is_0__and_of_true_is_1()
        {
            var bFalse = new Bit();
            var bTrue = new Bit() { Value = true };

            Assert.Equal("0", bFalse.ToString());
            Assert.Equal("1", bTrue.ToString());
        }
    }
}
