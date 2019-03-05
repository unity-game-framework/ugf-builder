using JetBrains.Annotations;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents abstract builder with default build method.
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// Builds object using the specified arguments, if requires.
        /// <para>
        /// Arguments can be null.
        /// </para>
        /// </summary>
        /// <param name="arguments">The arguments to builder object.</param>
        object Build([CanBeNull] object[] arguments);
    }
}