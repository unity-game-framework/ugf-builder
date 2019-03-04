using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderBaseCached
    {
        private class Target
        {
        }
        
        private class Builder : BuilderCachedBase
        {
            public Target Build()
            {
                if (!HasCache)
                {
                    Cache = new Target();
                }
                
                return (Target)Cache;
            }
        }

        [Test]
        public void Build()
        {
            var builder = new Builder();
            
            Assert.False(builder.HasCache);
            
            Target result1 = builder.Build();
            object result2 = builder.Build(null);
            
            Assert.True(builder.HasCache);
            Assert.AreEqual(result1, result2);
            Assert.AreSame(result1, result2);
        }
    }
}