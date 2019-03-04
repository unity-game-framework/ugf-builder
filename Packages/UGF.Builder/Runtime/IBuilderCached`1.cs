namespace UGF.Builder.Runtime
{
    public interface IBuilderCached<out TResult> : IBuilder<TResult>
    {
        TResult Cache { get; }
        bool HasCache { get; }
    }
}