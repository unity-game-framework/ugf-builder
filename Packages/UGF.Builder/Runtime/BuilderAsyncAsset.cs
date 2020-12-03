using System.Threading.Tasks;

namespace UGF.Builder.Runtime
{
    public abstract class BuilderAsyncAsset<TResult> : BuilderAsyncAssetBase, IBuilderAsync<TResult>
    {
        public async Task<T> BuildAsync<T>() where T : TResult
        {
            return (T)await BuildAsync();
        }

        public Task<TResult> BuildAsync()
        {
            return OnBuildAsync();
        }

        protected abstract Task<TResult> OnBuildAsync();

        protected override async Task<object> OnBuildAsync(object[] arguments)
        {
            return await OnBuildAsync();
        }
    }
}
