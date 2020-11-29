namespace UGF.Builder.Runtime.Assets
{
    public abstract class BuilderAsset<TResult> : BuilderAssetBase, IBuilder<TResult>
    {
        public T Build<T>() where T : TResult
        {
            return (T)Build();
        }

        public TResult Build()
        {
            return OnBuild();
        }

        protected abstract TResult OnBuild();

        protected override object OnBuild(object[] arguments)
        {
            return OnBuild();
        }
    }
}
