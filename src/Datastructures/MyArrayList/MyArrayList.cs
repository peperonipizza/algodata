namespace AD
{
    public partial class MyArrayList : IMyArrayList
    {
        private int[] data;
        private int size;

        public MyArrayList(int capacity)
        {
            // Write implementation here
            data = new int[capacity];
            size = 0;
        }

        public void Add(int n)
        {
            if (size >= Capacity())
                throw new MyArrayListFullException();
            else
            {
                data[size] = n;
                size++;
            }
        }

        public int Get(int index)
        {
            // Write implementation here
            if (index < 0 || index >= size || size == 0)
                throw new MyArrayListIndexOutOfRangeException();
            else return data[index];
        }

        public void Set(int index, int n)
        {
            // Write implementation here
            if (index < 0 || index >= size || size == 0)
                throw new MyArrayListIndexOutOfRangeException();
            if (index < size)
                data[index] = n;
        }

        public int Capacity()
        {
            // Write implementation here
            return data.Length;
        }

        public int Size()
        {
            // Write implementation here
            return size;
        }

        public void Clear()
        {
            // Write implementation here
            size = 0;
        }

        public int CountOccurences(int n)
        {
            // Write implementation here
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (data[i] == n)
                {
                    count++;
                }
            }
            return count;
        }

        override public string ToString()
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
        }
    }
}
