using System.Collections.Generic;

namespace AD
{
    public partial class MyQueue<T> : IMyQueue<T>
    {
        private T[] queue;
        // Ints to keep track of the size, the front and the back
        private int size, front, back;
        // Defaultcap can be changed to circumstances
        private int defaultcap = 10;

        // function for increment
        private int increment(int x)
        {
            if (++x == queue.Length)
            {
                x = 0;
            }
            return x;
        }
        public MyQueue()
        {
            // queue = new array with the size of the defaultcap
            queue = new T[defaultcap];
            Clear();
        }
        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(T data)
        {
            // Keep track of back and place data on index back
            back = increment(back);
            queue[back] = data;
            size++;
        }

        public T GetFront()
        {
            if (IsEmpty())
                throw new MyQueueEmptyException();
            return queue[front];
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new MyQueueEmptyException();
            size--;
            T returnv = queue[front];
            front = increment(front);
            return returnv;
        }

        public void Clear()
        {
            size = 0;
            front = 0;
            back = -1;
        }


    }
}