using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderMethod
    {
        [Test]
        public void Build()
        {
            var method = GetType().GetMethod("BuildMethod");
            
            Assert.NotNull(method);
            
            var builder = new BuilderMethod(this, method);
            var result = builder.Build(null);
            
            Assert.AreEqual(result, "result");
        }

        public string BuildMethod()
        {
            return "result";
        }
    }
}