namespace AD
{
    public partial class BinaryNode<T>
    {
        public T data;
        public BinaryNode<T> left;
        public BinaryNode<T> right;

        public BinaryNode() : this(default(T), default(BinaryNode<T>), default(BinaryNode<T>)) { }

        public BinaryNode(T data)
        {
            this.data = data;
            left = right = null;
        }

        public BinaryNode(T data, BinaryNode<T> left, BinaryNode<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public int size(BinaryNode<T> t)
        {
            if (t == null)
            {
                return 0;
            }
            else
            {
                return 1 + size(t.left) + size(t.right);
            }
        }
    }
}