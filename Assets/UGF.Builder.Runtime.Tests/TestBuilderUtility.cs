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
            var method = BuilderUtility.FindBuildMethod(typeof(Builder));
            
            Assert.NotNull(method);
            Assert.AreEqual("Build", method.Name);
            Assert.AreEqual(3, method.GetParameters().Length);
        }

        [Test]
        public void FindBuildMethod2()
        {
            var method = BuilderUtility.FindBuildMethod(typeof(Builder2));
            
            Assert.NotNull(method);
            Assert.AreEqual("Build", method.Name);
            Assert.AreEqual(0, method.GetParameters().Length);
        }

        [Test]
        public void FindBuildMethod3()
        {
            var method = BuilderUtility.FindBuildMethod(typeof(Builder3));
            
            Assert.Null(method);
        }

        [Test]
        public void FindBuildMethod4()
        {
            var method = BuilderUtility.FindBuildMethod(typeof(Builder4));
            
            Assert.Null(method);
        }
    }
}