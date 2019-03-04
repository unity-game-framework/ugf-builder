using System;
using UnityEngine;

namespace UGF.Builder.Runtime.GameObjects
{
    public class GameObjectBuilderEmpty : BuilderBase, IGameObjectBuilder
    {
        public GameObject Build()
        {
            return new GameObject();
        }

        public GameObject Build(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            
            return new GameObject(name);
        }

        public GameObject Build(Transform parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            var gameObject = new GameObject();

            gameObject.transform.SetParent(parent);
            
            return gameObject;
        }

        public GameObject Build(Transform parent, bool worldPositionStays)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            var gameObject = new GameObject();

            gameObject.transform.SetParent(parent, worldPositionStays);
            
            return gameObject;
        }

        public GameObject Build(Vector3 position, Quaternion rotation)
        {
            var gameObject = new GameObject();

            gameObject.transform.SetPositionAndRotation(position, rotation);
            
            return gameObject;
        }

        public GameObject Build(Vector3 position, Quaternion rotation, Transform parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            var gameObject = new GameObject();
            Transform transform = gameObject.transform;

            transform.SetPositionAndRotation(position, rotation);
            transform.SetParent(parent);
            
            return gameObject;
        }
    }
}