using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Library.Datastructures.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Root { get; private set; }

        public LinkedList() { }

        public LinkedList(T value)
        {
            this.Root = new Node<T>(value);
        }

        public void AppendToHead(T value)
        {
            Root = new Node<T>(value);
        }

        public void AppendToHead(Node<T> node)
        {
            Root = node;
        }

        // public void AppendToTail() { }
    }
}
