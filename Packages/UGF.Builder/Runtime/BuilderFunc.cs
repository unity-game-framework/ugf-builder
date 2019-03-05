using System;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder that use func to build an object.
    /// </summary>
    public class BuilderFunc<TResult> : BuilderDelegate, IBuilder<TResult>
    {
        /// <summary>
        /// Gets the func used to build an object.
        /// </summary>
        public Func<TResult> Func { get; }

        /// <summary>
        /// Creates build with the specified func.
        /// </summary>
        /// <param name="func">The func used to build an object.</param>
        public BuilderFunc(Func<TResult> func) : base(func)
        {
            Func = func ?? throw new ArgumentNullException(nameof(func));
        }

        public virtual TResult Build()
        {
            return Func();
        }
    }
}