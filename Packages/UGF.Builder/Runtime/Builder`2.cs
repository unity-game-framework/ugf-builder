using System;

namespace UGF.Builder.Runtime
{
    public abstract class Builder<TArguments, TResult> : BuilderBase, IBuilder<TArguments, TResult>
    {
        public T Build<T>(TArguments arguments) where T : TResult
        {
            return (T)Build(arguments);
        }

        public TResult Build(TArguments arguments)
        {
            return OnBuild(arguments);
        }

        protected abstract TResult OnBuild(TArguments arguments);

        protected override object OnBuild(object[] arguments)
        {
            if (arguments.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(arguments));
            if (arguments[0] == null) throw new ArgumentNullException(nameof(arguments));

            return OnBuild((TArguments)arguments[0]);
        }
    }
}
