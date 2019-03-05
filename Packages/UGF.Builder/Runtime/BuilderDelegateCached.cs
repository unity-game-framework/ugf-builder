using System;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder with cached build result and delegate used to build an object.
    /// </summary>
    public class BuilderDelegateCached : BuilderDelegate, IBuilderCached
    {
        public object Cache { get; private set; }
        public bool HasCache { get { return Cache != null; } }

        /// <summary>
        /// Creates builder with the specified delegate.
        /// </summary>
        /// <param name="delegate">The delegate used to build an object.</param>
        public BuilderDelegateCached(Delegate @delegate) : base(@delegate)
        {
        }

        public override object Build(object[] arguments)
        {
            if (!HasCache)
            {
                Cache = base.Build(arguments);
            }
            
            return Cache;
        }
    }
}