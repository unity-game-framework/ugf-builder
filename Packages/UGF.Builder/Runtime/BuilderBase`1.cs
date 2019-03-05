namespace UGF.Builder.Runtime
{
    /// <summary>
    /// The abstract builder implementation with the explicit build result.
    /// </summary>
    public abstract class BuilderBase<TResult> : BuilderBase, IBuilder<TResult>
    {
        public abstract TResult Build();
    }
}