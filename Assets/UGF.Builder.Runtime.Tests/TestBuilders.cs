using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilders
    {
        private class TestTupleBuilder : Builder<(int size, bool boolean), int[]>
        {
            protected override int[] OnBuild((int size, bool boolean) arguments)
            {
                return new int[arguments.size];
            }
        }

        private class TestCustomBuilder : Builder<(int size, bool boolean), int[]>, ITestCustomBuilder
        {
            public int[] Build(int size, bool boolean)
            {
                return OnBuild((size, boolean));
            }

            protected override int[] OnBuild((int size, bool boolean) arguments)
            {
                return new int[arguments.size];
            }
        }

        private class TestArgumentsBuilder : Builder<TestBuildArguments, int[]>
        {
            protected override int[] OnBuild(TestBuildArguments arguments)
            {
                return new int[arguments.Size];
            }
        }

        private interface ITestCustomBuilder : IBuilder
        {
            int[] Build(int size, bool boolean);
        }

        private readonly struct TestBuildArguments
        {
            public int Size { get; }
            public bool Boolean { get; }

            public TestBuildArguments(int size, bool boolean)
            {
                Size = size;
                Boolean = boolean;
            }
        }

        [Test]
        public void Test()
        {
            var builder0 = new TestTupleBuilder();
            var builder1 = new TestCustomBuilder();
            var builder2 = new TestArgumentsBuilder();

            int[] result0 = builder0.Build((size: 10, boolean: false));
            int[] result1 = builder1.Build(10, false);
            int[] result2 = builder2.Build(new TestBuildArguments(10, false));

            Assert.NotNull(result0);
            Assert.NotNull(result1);
            Assert.NotNull(result2);
            Assert.AreEqual(10, result0.Length);
            Assert.AreEqual(10, result1.Length);
            Assert.AreEqual(10, result2.Length);
        }
    }
}
