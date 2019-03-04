using System;
using System.Reflection;

namespace UGF.Builder.Runtime
{
    public static class BuilderUtility
    {
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