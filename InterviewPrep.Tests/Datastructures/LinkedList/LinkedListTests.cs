using InterviewPrep.Library.Datastructures.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests.Datastructures
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedListShouldContainEmptyHeadNode_WhenANewLinkedListHasBeenMadeWithoutInitialValue()
        {
            // Arrange & Act
            var linkedList = new Library.Datastructures.LinkedList.LinkedList<int>();

            // Assert
            Assert.AreEqual(null, linkedList.Root);
        }

        [TestMethod]
        public void LinkedListShouldContainHeadNode_WhenANewLinkedListHasBeenMadeWithInitialValue()
        {
            // Arrange & Act
            var linkedList = new Library.Datastructures.LinkedList.LinkedList<int>(10);

            // Assert
            Assert.IsNotNull(linkedList.Root);
            Assert.AreEqual(10, linkedList.Root.Data);
        }

        [TestMethod]
        public void AppendToHeadShouldCreateAndInsertNodeAtHeadPosition_WhenANewValueIsAppendedToHead()
        {
            // Arrange
            var linkedList = new Library.Datastructures.LinkedList.LinkedList<int>();

            // Act
            linkedList.AppendToHead(10);

            // Assert
            Assert.AreEqual(10, linkedList.Root.Data);
        }

        [TestMethod]
        public void AppendToHeadShouldInsertNodeAtHeadPosition_WhenANodeIsAppendedToHead()
        {
            // Arrange
            var linkedList = new Library.Datastructures.LinkedList.LinkedList<int>();
            var node = new Node<int>(10);

            // Act
            linkedList.AppendToHead(node);

            // Assert
            Assert.AreEqual(10, linkedList.Root.Data);
        }
    }
}
