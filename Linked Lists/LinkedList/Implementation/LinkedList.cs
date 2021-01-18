using System;
using System.Collections.Generic;
using LinkedList.Interfaces;

namespace LinkedList.Implementation
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public int Count { get; private set; }
        public ILinkedListNode<T> First { get; private set; }
        public bool IsEmpty => Count == 0;

        public LinkedList() {}

        public LinkedList(T value)
        {
            First = new LinkedListNode<T>(value);
            Count = 1;
        }

        public void Add(T value)
        {
            var newNode = new LinkedListNode<T>(value);

            if (IsEmpty)
            {
                First = newNode;
            }
            else
            {
                var currentNode = First;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }

            Count++;
        }

        public bool Remove(T value)
        {
            if (IsEmpty)
            {
                return false;
            }

            if (First.Value.Equals(value))
            {
                First = First.Next;
                Count--;
                return true;
            }
            
            var previousNode = First;
            var currentNode = First.Next;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    previousNode.Next = currentNode.Next;
                    Count--;
                    return true;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            if (IsEmpty)
            {
                return false;
            }

            var currentNode = First;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public ILinkedListNode<T> Find(T value)
        {
            var currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return null;
        }

        public void Reverse()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Linked list is empty");
            }

            var currentNode = First;
            Stack<ILinkedListNode<T>> stack = new Stack<ILinkedListNode<T>>();

            while (currentNode != null)
            {
                stack.Push(currentNode);
                currentNode = currentNode.Next;
            }

            First = stack.Pop();
            currentNode = First;
            while (stack.Count > 0)
            {
                currentNode.Next = stack.Pop();
                currentNode = currentNode.Next;
            }
        }
    }
}