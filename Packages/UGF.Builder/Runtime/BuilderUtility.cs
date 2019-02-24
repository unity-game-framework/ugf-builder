using System;
using System.Reflection;
using JetBrains.Annotations;

namespace UGF.Builder.Runtime
{
    public static class BuilderUtility
    {
        [CanBeNull]
        public static MethodInfo FindBuildMethod(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            
            MethodInfo result = null;
            int count = -1;

            for (int i = 0; i < methods.Length; i++)
            {
                var method = methods[i];

                if (method.Name == "Build")
                {
                    var parameters = method.GetParameters();

                    if (parameters.Length > count)
                    {
                        bool isBaseBuild = parameters.Length == 1 && parameters[0].ParameterType == typeof(object[]);

                        if (!isBaseBuild)
                        {
                            result = method;
                            count = parameters.Length;   
                        }
                    }    
                }
            }

            return result;
        }
    }
}