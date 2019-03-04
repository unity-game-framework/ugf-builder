using System;

namespace UGF.Builder.Runtime
{
    public class BuilderDelegateCached : BuilderDelegate, IBuilderCached
    {
        public object Cache { get; private set; }
        public bool HasCache { get { return Cache != null; } }

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