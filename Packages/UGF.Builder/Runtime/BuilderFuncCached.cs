using System;
using System.Collections.Generic;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder with cached build result and func to build an object.
    /// </summary>
    public class BuilderFuncCached<TResult> : BuilderFunc<TResult>, IBuilderCached<TResult>
    {
        public TResult Cache { get; private set; }
        public bool HasCache { get { return !EqualityComparer<TResult>.Default.Equals(Cache, default(TResult)); } }

        /// <summary>
        /// Creates build with the specified func.
        /// </summary>
        /// <param name="func">The func used to build an object.</param>
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