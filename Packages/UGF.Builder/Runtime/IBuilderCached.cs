namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents abstract builder with cache.
    /// </summary>
    public interface IBuilderCached : IBuilder
    {
        /// <summary>
        /// Gets the cached build result.
        /// </summary>
        object Cache { get; }
        
        /// <summary>
        /// Gets the value determines whether builder has cached build result.
        /// </summary>
        bool HasCache { get; }
    }
}