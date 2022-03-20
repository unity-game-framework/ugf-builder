using System;
using System.Threading.Tasks;

namespace UGF.Builder.Runtime
{
    public abstract class BuilderAsyncAsset<TArguments, TResult> : BuilderAsyncAssetBase, IBuilderAsync<TArguments, TResult>
    {
        private readonly Type m_type = typeof(TArguments);

        public async Task<T> BuildAsync<T>(TArguments arguments) where T : TResult
        {
            return (T)await BuildAsync(arguments);
        }

        public Task<TResult> BuildAsync(TArguments arguments)
        {
            if (m_type.IsClass && arguments == null) throw new ArgumentNullException(nameof(arguments));

            return OnBuildAsync(arguments);
        }

        protected abstract Task<TResult> OnBuildAsync(TArguments arguments);

        protected override async Task<object> OnBuildAsync(object[] arguments)
        {
            if (arguments.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(arguments));
            if (arguments[0] == null) throw new ArgumentNullException(nameof(arguments));

            return await OnBuildAsync((TArguments)arguments[0]);
        }
    }
}
