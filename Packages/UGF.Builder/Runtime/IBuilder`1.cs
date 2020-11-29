namespace UGF.Builder.Runtime
{
    public interface IBuilder<TResult> : IBuilder
    {
        T Build<T>() where T : TResult;
        TResult Build();
    }
}
