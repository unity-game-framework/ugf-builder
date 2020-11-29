using System;

namespace UGF.Builder.Runtime.Assets
{
    public abstract class BuilderAsset<TArguments, TResult> : BuilderBase, IBuilder<TArguments, TResult>
    {
        private readonly Type m_type = typeof(TArguments);

        public T Build<T>(TArguments arguments) where T : TResult
        {
            return (T)Build(arguments);
        }

        public TResult Build(TArguments arguments)
        {
            if (m_type.IsClass && arguments == null) throw new ArgumentNullException(nameof(arguments));

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
