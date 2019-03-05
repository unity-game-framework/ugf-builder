using System;
using Object = UnityEngine.Object;

namespace UGF.Builder.Runtime.Objects
{
    /// <summary>
    /// Represents builder for the Unity Object instantiation.
    /// </summary>
    public class ObjectBuilder<TResult> : BuilderBase, IBuilder<TResult> where TResult : Object
    {
        /// <summary>
        /// Gets the source object.
        /// </summary>
        public TResult Source { get; }

        /// <summary>
        /// Creates builder with the specified source object to instantiate.
        /// </summary>
        /// <param name="source">The source object to instantiate.</param>
        public ObjectBuilder(TResult source)
        {
            Source = source ? source : throw new ArgumentNullException(nameof(source));
        }

        public TResult Build()
        {
            return Object.Instantiate(Source);
        }
    }
}