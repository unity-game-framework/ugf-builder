namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder without arguments and explicit build result.
    /// </summary>
    public interface IBuilder<out TResult> : IBuilder
    {
        /// <summary>
        /// Builds the object.
        /// </summary>
        TResult Build();
    }
}