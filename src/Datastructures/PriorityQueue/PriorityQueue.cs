using System;
using System.Collections.Generic;
using System.Linq;

namespace AD
{
    public partial class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int size;   // Number of elements in heap
        public T[] array;  // The heap array
        public IComparer<T> cmp;

        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------
        public PriorityQueue()
        {
            array = new T[DEFAULT_CAPACITY];
            size = 0;
        }

        public PriorityQueue(IComparer<T> c)
        {
            size = 0;
            cmp = c;
            array = new T[DEFAULT_CAPACITY];
        }
        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            size = 0;
        }

        public void Add(T x)
        {
            if (size + 1 > array.Length)
                throw new Exception();
                int hole = size++;
                array[0] = x;
                for (; compare(x, array[hole / 2]) < 0; hole /= 2)
                    array[hole] = array[hole / 2];
                array[hole] = x;
            //size++;
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            //TODO: remove
            if (size == 0)
                throw new PriorityQueueEmptyException();
            T minItem = array[0];
            array[0] = array[size--];
            percolateDown(1);
            return minItem;
        }

        public void percolateDown(int hole)
        {
            int child;
            T tmp = array[hole];
            for (; hole * 2 <= size; hole = child)
            {
                child = hole * 2;
                if (child != size && compare(array[child + 1], array[child]) < 0)
                    child++;
                if (compare(array[child], tmp) < 0)
                    array[hole] = array[child];
                else
                    break;
            }
            array[hole] = tmp;
        }
        public int compare(T lhs, T rhs)
        {
            if (cmp == null)
                return ((IComparable)lhs).CompareTo(rhs);
            else
                return cmp.Compare(lhs, rhs);
        }

        public override string ToString()
        {
            string s = "";
            if (size == 0)
                return "";
            else
            {
                for (int i = 1; i < array.Length; i++)
                {
                    T a = array[i];
                    s += $"{a}";
                    if (i + 1 < array.Length)
                        s += " ";
                }
                return s;
            }
        }
        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            throw new System.NotImplementedException();
        }

        public void BuildHeap()
        {
            for (int a = size / 2; a > 0; a--)
                percolateDown(a); 
        }

    }
}
