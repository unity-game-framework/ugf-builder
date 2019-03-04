using System;
using System.Reflection;

namespace UGF.Builder.Runtime
{
    public abstract class BuilderBase : IBuilder
    {
        private MethodInfo m_buildMethod;
     
        public MethodInfo GetBuildMethod()
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
            return GetBuildMethod().Invoke(this, arguments);
        }
    }
}