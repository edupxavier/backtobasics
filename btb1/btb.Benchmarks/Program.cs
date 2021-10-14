using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using core;
using System;

namespace btb.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BitVersusBoolean>();
        }
    }

    public class BitVersusBoolean
    {
        [GlobalSetup]
        public void Setup()
        {
        }

        public bool BooleanAssign(bool inputA, bool inputB)
        {
            return inputA == inputB;
        }

        public bool BitAssign(Bit inputA, Bit inputB)
        {
            return inputA == inputB;
        }

        [Params(false, true, false, true)]
        public bool A { get; set; }

        [Params(false, false, true, true)]
        public bool B { get; set; }

        [Benchmark]
        public void bBool() => BooleanAssign(A, B);

        [Benchmark]
        public void bBit() => BitAssign(new Bit(A), new Bit(B));

    }

}
