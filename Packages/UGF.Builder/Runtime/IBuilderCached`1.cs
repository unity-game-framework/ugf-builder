namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder with cached explicit build result.
    /// </summary>
    public interface IBuilderCached<out TResult> : IBuilder<TResult>
    {
        /// <summary>
        /// Gets the cached build result.
        /// </summary>
        TResult Cache { get; }
        
        /// <summary>
        /// Gets the value determines whether builder has cached build result.
        /// </summary>
        bool HasCache { get; }
    }
}