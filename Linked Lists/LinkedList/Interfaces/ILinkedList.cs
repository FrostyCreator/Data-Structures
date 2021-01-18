using System;

namespace LinkedList.Interfaces
{
    public interface ILinkedList<T>
    {
        ILinkedListNode<T> First { get; }
        int Count { get; }
        bool IsEmpty { get; }
        
        void Add(T value);
        bool Remove(T value);
        bool Contains(T value);
        ILinkedListNode<T> Find(T value);
        void Reverse();
    }
}