using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderFuncCached
    {
        [Test]
        public void Build()
        {
            var builder = new BuilderFuncCached<string>(() => "result");
            
            Assert.False(builder.HasCache);
            
            string result1 = builder.Build();
            object result2 = builder.Build(null);
            
            Assert.True(builder.HasCache);
            Assert.AreEqual("result", result1);
            Assert.AreEqual(result1, result2);
            Assert.AreSame(result1, result2);
        }
    }
}