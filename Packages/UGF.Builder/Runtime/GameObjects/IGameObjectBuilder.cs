using UnityEngine;

namespace UGF.Builder.Runtime.GameObjects
{
    /// <summary>
    /// Represents builder for creating GameObjects.
    /// </summary>
    public interface IGameObjectBuilder : IBuilder<GameObject>
    {
        /// <summary>
        /// Builds gameobject with the specified name.
        /// </summary>
        /// <param name="name">The name of the gameobject.</param>
        GameObject Build(string name);
        
        /// <summary>
        /// Builds gameobject with the specified parent.
        /// </summary>
        /// <param name="parent">The transform parent to attach.</param>
        GameObject Build(Transform parent);
        
        /// <summary>
        /// Builds gameobject with the specified parent.
        /// </summary>
        /// <param name="parent">The transform parent to attach.</param>
        /// <param name="worldPositionStays">The value determines whether to transform local positions to world space before attach to parent.</param>
        GameObject Build(Transform parent, bool worldPositionStays);
        
        /// <summary>
        /// Builds gameobject with the specified position and rotation.
        /// </summary>
        /// <param name="position">The position of the gameobject.</param>
        /// <param name="rotation">The rotation of the gameobject.</param>
        GameObject Build(Vector3 position, Quaternion rotation);
        
        /// <summary>
        /// Builds gameobject with the specified position, rotation and parent.
        /// </summary>
        /// <param name="position">The position of the gameobject.</param>
        /// <param name="rotation">The rotation of the gameobject.</param>
        /// <param name="parent">The transform parent to attach.</param>
        GameObject Build(Vector3 position, Quaternion rotation, Transform parent);
    }
}