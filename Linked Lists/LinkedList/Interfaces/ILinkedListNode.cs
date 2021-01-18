using System;

namespace LinkedList.Interfaces
{
    public interface ILinkedListNode<T> 
    {
        T Value { get; set; }
        ILinkedListNode<T> Next { get; set; }
    }
}