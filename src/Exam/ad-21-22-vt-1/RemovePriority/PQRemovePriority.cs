using System;

namespace AD
{
    public partial class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable<T>
    {
        public int[] RemovePriority(T t)
        {
            int[] indices = new int[size];
            int count = 0;
            int replace = 1;
            for (var i = 1; i <= size; i++)
            {
                if (t.Equals(array[i]))
                {
                    indices[count++] = i;
                    continue;
                }

                array[replace++] = array[i];
            }

            size -= count;
            BuildHeap();

            int[] r = new int[count];
            for (int i = 0; i < count; i++) r[i] = indices[i];

            return r;
        }
    }
}
