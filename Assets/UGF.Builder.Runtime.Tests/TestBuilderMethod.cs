using System.Reflection;
using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderMethodInfo
    {
        private class Target
        {
            public string BuildMethod()
            {
                return "result";
            }

            public static string BuildMethodStatic()
            {
                return "result_static";
            }
        }
        
        [Test]
        public void Build()
        {
            var target = new Target();
            MethodInfo method = typeof(Target).GetMethod("BuildMethod");
            
            Assert.NotNull(method);
            
            var builder = new BuilderMethodInfo(target, method);
            object result = builder.Build(null);
            
            Assert.AreEqual(result, "result");
        }

        [Test]
        public void BuildStatic()
        {
            MethodInfo method = typeof(Target).GetMethod("BuildMethodStatic");
            
            Assert.NotNull(method);
            
            var builder = new BuilderMethodInfo(method);
            object result = builder.Build(null);
            
            Assert.AreEqual(result, "result_static");
        }
    }
}