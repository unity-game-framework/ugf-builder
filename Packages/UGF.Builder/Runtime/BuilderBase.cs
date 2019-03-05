using System;
using System.Reflection;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// The abstract builder base class.
    /// <para>
    /// This builder will find the default "Build" method implementation to support default "Build" method.
    /// </para>
    /// </summary>
    public abstract class BuilderBase : IBuilder
    {
        private MethodInfo m_buildMethod;
     
        /// <summary>
        /// Gets the default build method.
        /// <para>
        /// Tries to find the default method builder with most parameters.
        /// </para>
        /// </summary>
        public MethodInfo GetDefaultBuildMethod()
        {
            if (m_buildMethod == null)
            {
                if (BuilderUtility.TryFindBuilderMethod(GetType(), out MethodInfo methodInfo))
                {
                    m_buildMethod = methodInfo;
                }
                else
                {
                    throw new NullReferenceException("Build method not found.");
                }    
            }

            return m_buildMethod;
        }
        
        public virtual object Build(object[] arguments)
        {
            return GetDefaultBuildMethod().Invoke(this, arguments);
        }
    }
}