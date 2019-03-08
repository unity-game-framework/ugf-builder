using NUnit.Framework;
using UGF.Builder.Runtime.GameObjects;
using UnityEngine;

namespace UGF.Builder.Runtime.Tests.GameObjects
{
    public class TestGameObjectBuilderComponent
    {
        [Test]
        public void Build()
        {
            var component = new GameObject("prefab").AddComponent<MeshFilter>();
            var builder = new GameObjectBuilder<MeshFilter>(component);

            MeshFilter component1 = builder.Build();
            
            Assert.NotNull(component1);
            Assert.AreNotSame(component, component1);
            Assert.AreNotSame(component.gameObject, component1.gameObject);
            Assert.AreEqual("prefab(Clone)", component1.gameObject.name);
        }
    }
}