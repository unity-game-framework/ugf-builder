using System;

namespace UGF.Builder.Runtime
{
    public class BuilderDelegate : IBuilder
    {
        public Delegate Delegate { get; }

        public BuilderDelegate(Delegate @delegate)
        {
            Delegate = @delegate ?? throw new ArgumentNullException(nameof(@delegate));
        }

        public virtual object Build(object[] arguments)
        {
            return Delegate.DynamicInvoke(arguments);
        }
    }
}