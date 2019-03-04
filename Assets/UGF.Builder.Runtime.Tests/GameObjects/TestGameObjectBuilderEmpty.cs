using NUnit.Framework;
using UGF.Builder.Runtime.GameObjects;
using UnityEngine;

namespace UGF.Builder.Runtime.Tests.GameObjects
{
    public class TestGameObjectBuilderEmpty
    {
        [Test]
        public void BuildParent()
        {
            var parent = new GameObject();
            var builder1 = new GameObjectBuilder(new GameObject());
            var builder2 = new GameObjectBuilderEmpty();
            
            GameObject gameObject1 = builder1.Build(parent.transform);
            GameObject gameObject2 = builder2.Build(parent.transform);
            
            Assert.AreEqual(gameObject1.transform.parent, gameObject2.transform.parent);
            Assert.AreEqual(gameObject1.transform.position, gameObject2.transform.position);
            Assert.AreEqual(gameObject1.transform.rotation, gameObject2.transform.rotation);
        }

        [Test]
        public void BuildParentWorldPositionStaysTrue()
        {
            var parent = new GameObject();
            var builder1 = new GameObjectBuilder(new GameObject());
            var builder2 = new GameObjectBuilderEmpty();
            
            GameObject gameObject1 = builder1.Build(parent.transform, true);
            GameObject gameObject2 = builder2.Build(parent.transform, true);
            
            Assert.AreEqual(gameObject1.transform.parent, gameObject2.transform.parent);
            Assert.AreEqual(gameObject1.transform.position, gameObject2.transform.position);
            Assert.AreEqual(gameObject1.transform.rotation, gameObject2.transform.rotation);
        }

        [Test]
        public void BuildParentWorldPositionStaysFalse()
        {
            var parent = new GameObject();
            var builder1 = new GameObjectBuilder(new GameObject());
            var builder2 = new GameObjectBuilderEmpty();
            
            GameObject gameObject1 = builder1.Build(parent.transform, false);
            GameObject gameObject2 = builder2.Build(parent.transform, false);
            
            Assert.AreEqual(gameObject1.transform.parent, gameObject2.transform.parent);
            Assert.AreEqual(gameObject1.transform.position, gameObject2.transform.position);
            Assert.AreEqual(gameObject1.transform.rotation, gameObject2.transform.rotation);
        }

        [Test]
        public void BuildPositionRotationParent()
        {
            var parent = new GameObject();
            var builder1 = new GameObjectBuilder(new GameObject());
            var builder2 = new GameObjectBuilderEmpty();
            
            GameObject gameObject1 = builder1.Build(Vector3.one, Quaternion.Euler(Vector3.forward), parent.transform);
            GameObject gameObject2 = builder2.Build(Vector3.one, Quaternion.Euler(Vector3.forward), parent.transform);
            
            Assert.AreEqual(gameObject1.transform.parent, gameObject2.transform.parent);
            Assert.AreEqual(gameObject1.transform.position, gameObject2.transform.position);
            Assert.AreEqual(gameObject1.transform.rotation, gameObject2.transform.rotation);
        }
    }
}