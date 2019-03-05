using System;
using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderDelegateCached
    {
        [Test]
        public void Build()
        {
            var builder = new BuilderDelegateCached((Func<string>)(() => "result"));
            
            Assert.False(builder.HasCache);
            
            object result1 = builder.Build(null);
            object result2 = builder.Build(null);

            Assert.True(builder.HasCache);
            Assert.AreEqual("result", result1);
            Assert.AreEqual("result", result2);
            Assert.AreSame(result1, result2);
        }
    }
}