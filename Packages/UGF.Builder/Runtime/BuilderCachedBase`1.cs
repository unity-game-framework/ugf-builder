using System.Collections.Generic;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// The abstract generic implementation of the builder with the cached and explicit build result.
    /// </summary>
    public abstract class BuilderCachedBase<TResult> : BuilderBase<TResult>, IBuilderCached<TResult>
    {
        public TResult Cache { get; protected set; }
        public bool HasCache { get { return !EqualityComparer<TResult>.Default.Equals(Cache, default(TResult)); } }
        
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