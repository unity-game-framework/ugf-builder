namespace UGF.Builder.Runtime
{
    public abstract class BuilderComponent<TResult> : BuilderComponentBase, IBuilder<TResult>
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
