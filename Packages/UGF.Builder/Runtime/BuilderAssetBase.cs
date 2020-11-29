using System;
using UnityEngine;

namespace UGF.Builder.Runtime
{
    public abstract class BuilderAssetBase : ScriptableObject, IBuilder
    {
        public T Build<T>(object[] arguments)
        {
            return (T)Build(arguments);
        }

        public object Build(object[] arguments)
        {
            if (arguments == null) throw new ArgumentNullException(nameof(arguments));

            return OnBuild(arguments);
        }

        protected abstract object OnBuild(object[] arguments);
    }
}
