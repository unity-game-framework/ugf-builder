using System;

namespace UGF.Builder.Runtime
{
    public class BuilderActivator : IBuilder
    {
        public Type Type { get; }

        public BuilderActivator(Type type)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public virtual object Build(object[] arguments)
        {
            return arguments != null && arguments.Length > 0 ? Activator.CreateInstance(Type, arguments) : Activator.CreateInstance(Type);
        }
    }
}