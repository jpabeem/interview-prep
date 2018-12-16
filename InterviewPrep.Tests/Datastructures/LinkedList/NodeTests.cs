using InterviewPrep.Library.Datastructures.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests.Datastructures
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void NodeShouldContainValue_WhenANewNodeHasBeenCreatedWithAnIntegerValue()
        {
            // Arrange & Act
            Node<int> node = new Node<int>(10);

            // Assert
            Assert.AreEqual(10, node.Data);
        }

        [TestMethod]
        public void NodeShouldContainValue_WhenANewNodeHasBeenCreatedWithADoubleValue()
        {
            // Arrange & Act
            var node = new Node<double>(10.0);

            // Assert
            Assert.AreEqual(10.0, node.Data);
        }

        [TestMethod]
        public void NodeShouldContainValue_WhenANewNodeHasBeenCreatedWithAStringValue()
        {
            // Arrange & Act
            var node = new Node<string>("test");

            // Assert
            Assert.AreEqual("test", node.Data);
        }

        [TestMethod]
        public void NodeCanContainNullValue_WhenANewNodeHasBeenCreatedWithAStringValue()
        {
            // Arrange & Act
            var node = new Node<string>(null);

            // Assert
            Assert.AreEqual(null, node.Data);
        }

        [TestMethod]
        public void NodeHasEmptyNextPointer_WhenANewNodeHasBeenCreated()
        {
            // Arrange & Act
            var node = new Node<int>(1);

            // Assert
            Assert.AreEqual(null, node.Next);
        }

        [TestMethod]
        public void NodeHasAValidNextPointer_WhenNextPointerOfNodeHasBeenSet()
        {
            // Arrange
            var node = new Node<int>(1);

            // Act
            node.Next = new Node<int>(2);

            // Assert
            Assert.IsNotNull(node.Next);
            Assert.AreEqual(2, node.Next.Data);
        }

        [TestMethod]
        public void NodeHasTwoValidNextPointers_WhenTwoNextPointersHaveBeenSet()
        {
            // Arrange
            var node = new Node<int>(1);

            // Act
            node.Next = new Node<int>(2);
            node.Next.Next = new Node<int>(3);

            // Assert
            Assert.IsNotNull(node.Next);
            Assert.AreEqual(2, node.Next.Data);

            Assert.IsNotNull(node.Next.Next);
            Assert.AreEqual(3, node.Next.Next.Data);
        }
    }
}
