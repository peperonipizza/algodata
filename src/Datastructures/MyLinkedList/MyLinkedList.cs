namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyLinkedListNode<T> first;
        private int size;

        public MyLinkedList()
        {
            // Write implementation here
            //first = new MyLinkedListNode<T>(null);
            size = 0;
        }

        public void AddFirst(T data)
        {
            // Write implementation here
            first = new MyLinkedListNode<T>(data, first);
            /*MyLinkedListNode<T> newfirst = new MyLinkedListNode<T>(data, first);
            first = newfirst;*/
            size++;

        }

        public void AddLast(T data)
        {
            if(first == null)
                AddFirst(data);
            else
            {
                MyLinkedListNode<T> tmp = first;
                while (tmp.next != null)
                    tmp = tmp.next;
                tmp.next = new MyLinkedListNode<T> (data, null);
            }
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
            MyLinkedListNode<T> node = new MyLinkedListNode<T>();
            node.data = data;
            node.next = null;
            if (index < 0 || index > size)
                throw new MyLinkedListIndexOutOfRangeException();
            else if (index == 0)
                AddFirst(data);
            else if (this.first == null)
            {
                //if head is null and position is zero then exit.
                if (index != 0)
                    return;
                else //node set to the head.
                    this.first = node;
            }

            if (first != null && index == 0)
            {
                node.next = this.first;
                this.first = node;
                return;
            }
            MyLinkedListNode<T> current = this.first;
            MyLinkedListNode<T> previous = null;
            int i = 0;
            while (i < index)
            {
                previous = current;
                current = current.next;
                if (current == null)
                    break;
                i++;
            }
            node.next = current;
            previous.next = node;
            size++;
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
            if (node.next == null)
                return $"{node.data}";
            else if (node.next != null && node.next.next != null)
                return $"{node.data},{ToString(node.next)}";
            else if (node.next != null && node.next.next == null)
                return $"{node.data},{node.next.data}";
            else return "";
           /* if (node.next != null && node.next.next != null)
                return $"{ToString(node.next)},{node.data}";
            else
                return $"{node.data}";*/
        }

       /* public override string ToString()
        {
            string print = "";
            if (size == 0)
            {
                return "NIL";
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (size > 1)
                    {
                        print += data[i].ToString();
                        if ((i < size - 1))
                        {
                            print += ",";
                        }
                    }
                    else
                    {
                        print = data[i].ToString();
                    }
                }
                return "[" + print + "]";
            }
        }*/
    }
}