using System;
using System.Reflection;
using JetBrains.Annotations;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Represents builder that use method info to build an object.
    /// </summary>
    public class BuilderMethodInfo : IBuilder
    {
        /// <summary>
        /// Gets the target of the method info. (Can be Null)
        /// </summary>
        [CanBeNull]
        public object Target { get; }
        
        /// <summary>
        /// Gets the method info to invoke.
        /// </summary>
        public MethodInfo MethodInfo { get; }

        /// <summary>
        /// Creates builder from the specified method info that represents a static method.
        /// </summary>
        /// <param name="methodInfo">The method info to invoke that represents a static method.</param>
        public BuilderMethodInfo(MethodInfo methodInfo) : this(null, methodInfo)
        {
        }

        /// <summary>
        /// Creates builder from the specified target and method info.
        /// <para>
        /// The target can be null, if the specified method info represents a static method.
        /// </para>
        /// </summary>
        /// <param name="target">The target that contains the specified method.</param>
        /// <param name="methodInfo">The method info to invoke.</param>
        public BuilderMethodInfo(object target, MethodInfo methodInfo)
        {
            Target = target;
            MethodInfo = methodInfo ?? throw new ArgumentNullException(nameof(methodInfo));
        }

        public virtual object Build(object[] arguments)
        {
            return MethodInfo.Invoke(Target, arguments);
        }
    }
}