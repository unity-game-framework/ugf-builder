using System;

namespace UGF.Builder.Runtime
{
    public class BuilderActivatorCached : BuilderActivator, IBuilderCached
    {
        public object Cache { get; protected set; }
        public bool HasCache { get { return Cache != null; } }

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