using System;
using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderDelegate
    {
        [Test]
        public void Build()
        {
            var builder = new BuilderDelegate((Func<string>)(() => "result"));
            object result = builder.Build(null);

            Assert.AreEqual("result", result);
        }
    }
}