using System;

namespace UGF.Builder.Runtime
{
    public class BuilderFunc<TResult> : BuilderDelegate, IBuilder<TResult>
    {
        public Func<TResult> Func { get; }

        public BuilderFunc(Func<TResult> func) : base(func)
        {
            Func = func ?? throw new ArgumentNullException(nameof(func));
        }

        public TResult Build()
        {
            return Func();
        }
    }
}