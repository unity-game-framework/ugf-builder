using System.Threading.Tasks;

namespace UGF.Builder.Runtime
{
    public interface IBuilderAsync
    {
        Task<T> BuildAsync<T>(object[] arguments);
        Task<object> BuildAsync(object[] arguments);
    }
}
