using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderBase
    {
        private class Builder : BuilderBase
        {
            public string Build()
            {
                return "result";
            }
        }

        private class Builder2 : BuilderBase
        {
            public string Build(int arg0)
            {
                return $"result-{arg0}";
            }
        }
        
        [Test]
        public void Build()
        {
            var builder = new Builder();
            string result1 = builder.Build();
            object result2 = builder.Build(null);
            
            Assert.AreEqual(result1, "result");
            Assert.AreEqual(result1, result2);
        }

        [Test]
        public void Build2()
        {
            var builder = new Builder2();
            string result1 = builder.Build(0);
            object result2 = builder.Build(new object[] { 0 });
            
            Assert.AreEqual(result1, "result-0");
            Assert.AreEqual(result1, result2);
        }
    }
}