namespace UGF.Builder.Runtime
{
    public abstract class BuilderBase<TResult> : BuilderBase, IBuilder<TResult>
    {
        public abstract TResult Build();
    }
}