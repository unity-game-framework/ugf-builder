namespace UGF.Builder.Runtime
{
    public interface IBuilderCached : IBuilder
    {
        object Cache { get; }
        bool HasCache { get; }
    }
}