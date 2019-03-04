namespace UGF.Builder.Runtime
{
    public abstract class BuilderCachedBase : BuilderBase, IBuilderCached
    {
        public object Cache { get; protected set; }
        public bool HasCache { get { return Cache != null; } }

        public override object Build(object[] arguments)
        {
            if (!HasCache)
            {
                Cache = base.Build(arguments);
            }
            
            return Cache;
        }
    }
}