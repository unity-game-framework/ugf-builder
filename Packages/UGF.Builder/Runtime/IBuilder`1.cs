namespace UGF.Builder.Runtime
{
    public interface IBuilder<out TResult> : IBuilder
    {
        TResult Build();
    }
}