using System;
using UGF.Builder.Runtime.Objects;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UGF.Builder.Runtime.GameObjects
{
    /// <summary>
    /// Represents builder that use component from the gameobject to instantiate it.
    /// </summary>
    public class GameObjectBuilder<TComponent> : ObjectBuilder<TComponent>, IGameObjectBuilder<TComponent> where TComponent : Component
    {
        /// <summary>
        /// Creates builder with the specified component from the target gameobject.
        /// </summary>
        /// <param name="source">The component source from the target gameobject.</param>
        public GameObjectBuilder(TComponent source) : base(source)
        {
        }

        public TComponent Build(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            TComponent component = Object.Instantiate(Source);

            component.gameObject.name = name;
            
            return component;
        }

        public TComponent Build(Transform parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            return Object.Instantiate(Source, parent);
        }

        public TComponent Build(Transform parent, bool worldPositionStays)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            return Object.Instantiate(Source, parent, worldPositionStays);
        }

        public TComponent Build(Vector3 position, Quaternion rotation)
        {
            return Object.Instantiate(Source, position, rotation);
        }

        public TComponent Build(Vector3 position, Quaternion rotation, Transform parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            
            return Object.Instantiate(Source, position, rotation, parent);
        }
    }
}