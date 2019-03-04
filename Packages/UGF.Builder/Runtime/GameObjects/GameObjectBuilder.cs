using System;
using UGF.Builder.Runtime.Objects;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UGF.Builder.Runtime.GameObjects
{
    public class GameObjectBuilder : ObjectBuilder<GameObject>, IGameObjectBuilder
    {
        public GameObjectBuilder(GameObject source) : base(source)
        {
        }

        public GameObject Build(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            
            GameObject gameObject = Object.Instantiate(Source);

            gameObject.name = name;
            
            return gameObject;
        }

        public GameObject Build(Transform parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            return Object.Instantiate(Source, parent);
        }

        public GameObject Build(Transform parent, bool worldPositionStays)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            return Object.Instantiate(Source, parent, worldPositionStays);
        }

        public GameObject Build(Vector3 position, Quaternion rotation)
        {
            return Object.Instantiate(Source, position, rotation);
        }

        public GameObject Build(Vector3 position, Quaternion rotation, Transform parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            return Object.Instantiate(Source, position, rotation, parent);
        }
    }
}