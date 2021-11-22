namespace AD
{
    public partial class MyStack<T> : IMyStack<T>
    {
        private T[] data;
        int top, defaultcap = 10;
        public MyStack()
        {
            data = new T[defaultcap];
            top = -1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new MyStackEmptyException();
            return data[top--];
        }

        public void Push(T d)
        {
            data[++top] = d;
        }

        public T Top()
        {
            if (IsEmpty())
                throw new MyStackEmptyException();
            return data[top];
        }
    }
}
