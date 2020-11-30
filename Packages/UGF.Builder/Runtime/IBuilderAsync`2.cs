using System.Threading.Tasks;

namespace UGF.Builder.Runtime
{
    public interface IBuilderAsync<in TArguments, TResult> : IBuilderAsync
    {
        Task<T> BuildAsync<T>(TArguments arguments) where T : TResult;
        Task<TResult> BuildAsync(TArguments arguments);
    }
}
