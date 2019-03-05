using System;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder with cached build result and that use activator to build an object.
    /// </summary>
    public class BuilderActivatorCached : BuilderActivator, IBuilderCached
    {
        public object Cache { get; protected set; }
        public bool HasCache { get { return Cache != null; } }

        /// <summary>
        /// Creates builder with the specified type of the build object.
        /// </summary>
        /// <param name="type">The type of the build object.</param>
        public BuilderActivatorCached(Type type) : base(type)
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