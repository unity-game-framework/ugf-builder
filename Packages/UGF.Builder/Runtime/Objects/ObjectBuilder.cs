using System;
using Object = UnityEngine.Object;

namespace UGF.Builder.Runtime.Objects
{
    public class ObjectBuilder<TResult> : BuilderBase, IBuilder<TResult> where TResult : Object
    {
        public TResult Source { get; }

        public ObjectBuilder(TResult source)
        {
            Source = source ? source : throw new ArgumentNullException(nameof(source));
        }

        public TResult Build()
        {
            return Object.Instantiate(Source);
        }
    }
}