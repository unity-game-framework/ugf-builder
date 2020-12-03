using System.Threading.Tasks;

namespace UGF.Builder.Runtime
{
    public interface IBuilderAsync<TResult> : IBuilderAsync
    {
        Task<T> BuildAsync<T>() where T : TResult;
        Task<TResult> BuildAsync();
    }
}
