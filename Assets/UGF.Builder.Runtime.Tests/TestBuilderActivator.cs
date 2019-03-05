using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderActivator
    {
        private class Target
        {
        }
        
        [Test]
        public void Build()
        {
            var builder = new BuilderActivator(typeof(Target));
            object result = builder.Build(null);
            
            Assert.NotNull(result);
            Assert.IsAssignableFrom(typeof(Target), result);
        }
    }
}