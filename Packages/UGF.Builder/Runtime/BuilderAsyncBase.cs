using System;
using System.Threading.Tasks;

namespace UGF.Builder.Runtime
{
    public abstract class BuilderAsyncBase : IBuilderAsync
    {
        public async Task<T> BuildAsync<T>(object[] arguments)
        {
            return (T)await BuildAsync(arguments);
        }

        public Task<object> BuildAsync(object[] arguments)
        {
            if (arguments == null) throw new ArgumentNullException(nameof(arguments));

            return OnBuildAsync(arguments);
        }

        protected abstract Task<object> OnBuildAsync(object[] arguments);
    }
}
