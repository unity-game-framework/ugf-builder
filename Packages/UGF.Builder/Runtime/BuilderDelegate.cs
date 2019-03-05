using System;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder that use delegate to build an object.
    /// </summary>
    public class BuilderDelegate : IBuilder
    {
        /// <summary>
        /// Gets the delegate used to build an object.
        /// </summary>
        public Delegate Delegate { get; }

        /// <summary>
        /// Creates builder with the specified delegate.
        /// </summary>
        /// <param name="delegate">The delegate used to build an object.</param>
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