using System;
using System.Collections.Generic;

namespace UGF.Builder.Runtime
{
    public class BuilderFuncCached<TResult> : BuilderFunc<TResult>, IBuilderCached<TResult>
    {
        public TResult Cache { get; private set; }
        public bool HasCache { get { return !EqualityComparer<TResult>.Default.Equals(Cache, default(TResult)); } }

        public BuilderFuncCached(Func<TResult> func) : base(func)
        {
        }

        public override TResult Build()
        {
            if (!HasCache)
            {
                Cache = base.Build();
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