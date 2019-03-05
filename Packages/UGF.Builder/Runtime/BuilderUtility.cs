using System;
using System.Reflection;

namespace UGF.Builder.Runtime
{
    /// <summary>
    /// Provides utilities for working with builders.
    /// </summary>
    public static class BuilderUtility
    {
        /// <summary>
        /// Tries to find default builder method from the specified type.
        /// <para>
        /// Returns true if method was found, otherwise false.
        /// </para>
        /// <para>
        /// The default builder method is:
        /// <para> - Method with public non static access.</para>
        /// <para> - Method named as "Build"; </para>
        /// <para> - Method containing the most parameters; </para>
        /// <para> - Method does not has one parameter with "Object Array" return type; </para>
        /// </para>
        /// </summary>
        /// <param name="type">The type to find build method.</param>
        /// <param name="methodInfo">The found method.</param>
        public static bool TryFindBuilderMethod(Type type, out MethodInfo methodInfo)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            methodInfo = null;
            int count = -1;

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo method = methods[i];

                if (method.Name == "Build")
                {
                    ParameterInfo[] parameters = method.GetParameters();

                    if (parameters.Length > count)
                    {
                        bool isBaseBuild = parameters.Length == 1 && parameters[0].ParameterType == typeof(object[]);

                        if (!isBaseBuild)
                        {
                            methodInfo = method;
                            count = parameters.Length;   
                        }
                    }    
                }
            }

            return methodInfo != null;
        }
    }
}