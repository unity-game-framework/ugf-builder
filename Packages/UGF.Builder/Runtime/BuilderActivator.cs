using System;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder that use activator to build an object.
    /// </summary>
    public class BuilderActivator : IBuilder
    {
        /// <summary>
        /// Gets the type of the build object.
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Creates builder with the specified type of the build object.
        /// </summary>
        /// <param name="type">The type of the build object.</param>
        public BuilderActivator(Type type)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public virtual object Build(object[] arguments)
        {
            return arguments != null && arguments.Length > 0 ? Activator.CreateInstance(Type, arguments) : Activator.CreateInstance(Type);
        }
    }
}