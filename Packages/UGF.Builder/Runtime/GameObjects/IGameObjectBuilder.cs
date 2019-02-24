using UnityEngine;

namespace UGF.Builder.Runtime.GameObjects
{
    public interface IGameObjectBuilder : IBuilder<GameObject>
    {
        GameObject Build(string name);
        GameObject Build(Transform parent);
        GameObject Build(Transform parent, bool worldPositionStays);
        GameObject Build(Vector3 position, Quaternion rotation);
        GameObject Build(Vector3 position, Quaternion rotation, Transform parent);
    }
}