using System;

namespace CircularLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; internal set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}