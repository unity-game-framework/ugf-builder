using System;
using System.Reflection;

namespace UGF.Builder.Runtime
{
    public abstract class BuilderBase : IBuilder
    {
        public MethodInfo BuildMethod { get; }
        
        protected BuilderBase()
        {
            BuildMethod = BuilderUtility.FindBuildMethod(GetType()) ?? throw new NullReferenceException("Build method not found.");
        }

        public object Build(object[] arguments)
        {
            return BuildMethod.Invoke(this, arguments);
        }
    }
}