namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyLinkedListNode<T> first;
        private int size;

        public MyLinkedList()
        {
            // Write implementation here
            first = new MyLinkedListNode<T>(null);
            size = 0;
        }

        public void AddFirst(T data)
        {
            // Write implementation here
            MyLinkedListNode<T> newfirst = new MyLinkedListNode<T>(data, first);
            first = newfirst;
            size++;

        }

        public T GetFirst()
        {
            // Write implementation here
            if (size == 0)
                throw new MyLinkedListEmptyException();
            if (first == null)
                throw new MyLinkedListEmptyException();
            else return first.data;
        }

        public void RemoveFirst()
        {
            // Write implementation here
            if (size == 0)
                throw new MyLinkedListEmptyException();
            first = first.next;
            size--;
        }

        public int Size()
        {
            return size;
            // Write implementation here
            /*if (first.next != null)
            {
                return 1 + Size(first.next);
            }
            else return 0;*/
        }
        
        /*public int Size(MyLinkedListNode<T> node)
        {
            if (node.next != null)
                return 1 + Size(node.next);
            else return 0;
        }*/

        public void Clear()
        {
            // Write implementation here
            size = 0;
        }

        public void Insert(int index, T data)
        {
            // Write implementation here
            if (index < 0 || index > size)
                throw new MyLinkedListIndexOutOfRangeException();
            /*if (size == 0)
                throw new MyLinkedListEmptyException();*/
            if (index == 0)
                AddFirst(data);
            else
            {
                int count = 0;
                MyLinkedListNode<T> ptr = new MyLinkedListNode<T>(first.data, first.next);
                while (count < index)
                {
                    count++;
                    if (ptr.next != null)
                        ptr = ptr.next;
                }
                MyLinkedListNode<T> x = new MyLinkedListNode<T>(data, ptr.next);
                x.next = ptr.next;
                ptr.next = x;
                size++;
            }
        }

        public override string ToString()
        {
            // Write implementation here
            if (size == 0)
                return "NIL";
            else if (size == 1)
                return $"[{first.data}]";
            else
                return $"[{ToString(first)}]";
        }

        public string ToString(MyLinkedListNode<T> node)
        {
            if (node.next != null && node.next.next != null)
                return $"{ToString(node.next)},{node.data}";
            else 
                return $"{node.data}";
        }
    }
}