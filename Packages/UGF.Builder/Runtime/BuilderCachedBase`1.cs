using System.Collections.Generic;

namespace UGF.Builder.Runtime
{
    public abstract class BuilderCachedBase<TResult> : BuilderBase<TResult>, IBuilderCached<TResult>
    {
        public TResult Cache { get; protected set; }
        public bool HasCache { get { return !EqualityComparer<TResult>.Default.Equals(Cache, default(TResult)); } }
        
        protected abstract TResult BuildCache();
        
        public override TResult Build()
        {
            if (!HasCache)
            {
                Cache = BuildCache();
            }

            return Cache;
        }

        public override object Build(object[] arguments)
        {
            if (!HasCache)
            {
                Cache = (TResult)base.Build(arguments);
            }

            return Cache;
        }
    }
}