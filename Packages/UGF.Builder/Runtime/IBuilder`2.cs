namespace UGF.Builder.Runtime
{
    public interface IBuilder<in TArguments, TResult> : IBuilder
    {
        T Build<T>(TArguments arguments) where T : TResult;
        TResult Build(TArguments arguments);
    }
}
