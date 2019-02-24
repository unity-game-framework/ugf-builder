using UnityEngine;

namespace UGF.Builder.Runtime.GameObjects
{
    public abstract class GameObjectBuilderExternal : BuilderBase, IGameObjectBuilder
    {
        public IGameObjectBuilder Builder { get; }

        protected GameObjectBuilderExternal(IGameObjectBuilder builder)
        {
            Builder = builder;
        }

        protected abstract GameObject OnBuild(GameObject gameObject);
        
        public GameObject Build()
        {
            return OnBuild(Builder.Build());
        }

        public GameObject Build(string name)
        {
            return OnBuild(Builder.Build(name));
        }

        public GameObject Build(Transform parent)
        {
            return OnBuild(Builder.Build(parent));
        }

        public GameObject Build(Transform parent, bool worldPositionStays)
        {
            return OnBuild(Builder.Build(parent, worldPositionStays));
        }

        public GameObject Build(Vector3 position, Quaternion rotation)
        {
            return OnBuild(Builder.Build(position, rotation));
        }

        public GameObject Build(Vector3 position, Quaternion rotation, Transform parent)
        {
            return OnBuild(Builder.Build(position, rotation, parent));
        }
    }
}