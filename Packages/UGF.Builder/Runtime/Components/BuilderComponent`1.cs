﻿namespace UGF.Builder.Runtime.Components
{
    public abstract class BuilderComponent<TResult> : BuilderBase, IBuilder<TResult>
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
