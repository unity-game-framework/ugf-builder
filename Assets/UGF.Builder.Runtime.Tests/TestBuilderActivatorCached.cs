using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderActivatorCached
    {
        private class Target
        {
        }

        [Test]
        public void Build()
        {
            var builder = new BuilderActivatorCached(typeof(Target));
            
            Assert.False(builder.HasCache);
            
            object result1 = builder.Build(null);
            object result2 = builder.Build(null);
            
            Assert.True(builder.HasCache);
            Assert.NotNull(result1);
            Assert.NotNull(result2);
            Assert.IsAssignableFrom(typeof(Target), result1);
            Assert.AreSame(result1, result2);
        }
    }
}