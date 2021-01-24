using System;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public DoublyLinkedList() { }
        
        public DoublyLinkedList(T value)
        {
            InitDoublyLinkedList(value);
        }

        private void InitDoublyLinkedList(T value)
        {
            var newNode = new Node<T>(value);
            First = newNode;
            Last = newNode;
            Count = 1;
        }

        public void AddFirst(T value)
        {
            if (IsEmpty)
            {
                InitDoublyLinkedList(value);
                return;
            }
            
            var newNode = new Node<T>(value);
            First.Previous = newNode;
            newNode.Next = First;
            First = newNode;
            Count++;
        }

        public void AddLast(T value)
        {
            if (IsEmpty)
            {
                InitDoublyLinkedList(value);
                return;
            }
            
            var newNode = new Node<T>(value);
            Last.Next = newNode;
            newNode.Previous = Last;
            Last = newNode;
            Count++;
        }

        
        public bool Remove(T value)
        {
            if (IsEmpty)
            {
                return false;
            }

            if (First.Value.Equals(value) && Count == 1)
            {
                First = null;
                Last = null;
                Count = 0;
                return true;
            }

            var current = First;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current.Previous == null)
                    {
                        First = First.Next;
                        First.Previous = null;
                    }
                    else if (current.Next == null)
                    {
                        Last = Last.Previous;
                        Last.Next = null;
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    
                    Count--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            if (IsEmpty)
            {
                return false;
            }

            var current = First;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public Node<T> Find(T value)
        {
            if (IsEmpty)
            {
                return null;
            }

            var current = First;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        public DoublyLinkedList<T> Reverse()
        {
            var newList = new DoublyLinkedList<T>();
            var current = Last;
            
            while (current != null)
            {
                newList.AddLast(current.Value);
                current = current.Previous;
            }

            return newList;
        }
    }
}