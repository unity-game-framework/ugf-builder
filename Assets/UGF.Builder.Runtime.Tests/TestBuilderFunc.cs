using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderFunc
    {
        [Test]
        public void Build()
        {
            var builder = new BuilderFunc<string>(() => "result");
            string result1 = builder.Build();
            object result2 = builder.Build(null);
            
            Assert.AreEqual("result", result1);
            Assert.AreEqual(result1, result2);
        }
    }
}