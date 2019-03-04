using System;
using System.Reflection;

namespace UGF.Builder.Runtime
{
    public class BuilderMethod : IBuilder
    {
        public object Target { get; }
        public MethodInfo MethodInfo { get; }

        public BuilderMethod(object target, MethodInfo methodInfo)
        {
            Target = target ?? throw new ArgumentNullException(nameof(target));
            MethodInfo = methodInfo ?? throw new ArgumentNullException(nameof(methodInfo));
        }

        public virtual object Build(object[] arguments)
        {
            return MethodInfo.Invoke(Target, arguments);
        }
    }
}