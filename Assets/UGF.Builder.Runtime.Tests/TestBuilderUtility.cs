using System.Reflection;
using NUnit.Framework;

namespace UGF.Builder.Runtime.Tests
{
    public class TestBuilderUtility
    {
        private class Builder
        {
            public object Build()
            {
                return null;
            }

            public object Build(int arg0)
            {
                return null;
            }
            
            public object Build(int arg0, int arg1)
            {
                return null;
            }
            
            public object Build(int arg0, int arg1, int arg2)
            {
                return null;
            }
            
            public object NotBuild(int arg0, int arg1, int arg2)
            {
                return null;
            }
        }
        
        private class Builder2
        {
            public object Build()
            {
                return null;
            }

            public object Build(object[] arguments)
            {
                return null;
            }
        }
        
        private class Builder3
        {
        }
        
        private class Builder4
        {
            public object Build(object[] arguments)
            {
                return null;
            }
        }
        
        [Test]
        public void FindBuildMethod()
        {
            BuilderUtility.TryFindBuilderMethod(typeof(Builder), out MethodInfo method);
            
            Assert.NotNull(method);
            Assert.AreEqual("Build", method.Name);
            Assert.AreEqual(3, method.GetParameters().Length);
        }

        [Test]
        public void FindBuildMethod2()
        {
            BuilderUtility.TryFindBuilderMethod(typeof(Builder2), out MethodInfo method);
            
            Assert.NotNull(method);
            Assert.AreEqual("Build", method.Name);
            Assert.AreEqual(0, method.GetParameters().Length);
        }

        [Test]
        public void FindBuildMethod3()
        {
            BuilderUtility.TryFindBuilderMethod(typeof(Builder3), out MethodInfo method);
            
            Assert.Null(method);
        }

        [Test]
        public void FindBuildMethod4()
        {
            BuilderUtility.TryFindBuilderMethod(typeof(Builder4), out MethodInfo method);
            
            Assert.Null(method);
        }
    }
}