using System;
using LinkedList.Interfaces;

namespace LinkedList.Implementation
{
    public class LinkedListNode<T> : ILinkedListNode<T> 
    {
        public T Value { get; set; }
        public ILinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}