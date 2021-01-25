namespace CircularLinkedList
{
    public class CircularLinkedList<T>
    {
        public Node<T> First { get; private set; }
        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public CircularLinkedList() {}

        public CircularLinkedList(T value)
        {
            Init(value);
        }

        private void Init(T value)
        {
            var newNode = new Node<T>(value);
            First = newNode;
            First.Next = newNode;
            Count = 1;
        }
        
        public void AddLast(T value)
        {
            if (IsEmpty)
            {
                Init(value);
                return;
            }
            
            var newNode = new Node<T>(value);
            var temp = First;
            
            while (temp.Next != First)
            {
                temp = temp.Next;
            }

            Count++;
            temp.Next = newNode;
            newNode.Next = First;
        }

        public void AddFirst(T value)
        {
            if (IsEmpty)
            {
                Init(value);
                return;
            }
            
            var newNode = new Node<T>(value);
            var temp = First;
            
            while (temp.Next != First)
            {
                temp = temp.Next;
            }

            Count++;
            newNode.Next = First;
            temp.Next = newNode;
            First = newNode;
        }

        public bool Contains(T value)
        {
            if (IsEmpty)
            {
                return false;
            }

            var temp = First;
            while (temp.Next != First)
            {
                if (temp.Value.Equals(value))
                {
                    return true;
                }
                temp = temp.Next;
            }

            if (temp.Value.Equals(value))
            {
                return true;
            }

            return false;
        }

        public Node<T> Find(T value)
        {
            if (IsEmpty)
            {
                return null;
            }
            
            var temp = First;
            while (temp.Next != First)
            {
                if (temp.Value.Equals(value))
                {
                    return temp;
                }
                temp = temp.Next;
            }

            if (temp.Value.Equals(value))
            {
                return temp;
            }

            return null;
        }

        public CircularLinkedList<T> Reverse()
        {
            var newList =  new CircularLinkedList<T>();
            
            if (IsEmpty)
            {
                return newList;
            }
            
            var temp = First;
            while (temp.Next != First)
            {
                newList.AddFirst(temp.Value);
                temp = temp.Next;
            }
            newList.AddFirst(temp.Value);
            
            return newList;
        }
    }
}