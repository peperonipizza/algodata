namespace AD
{
    public partial class MyLinkedListNode<T>
    {
        public T data;
        public MyLinkedListNode<T> next;

        public MyLinkedListNode()
        {
        }

        public MyLinkedListNode(MyLinkedListNode<T> next)
        {
            this.next = next;
        }
        public MyLinkedListNode(T data)
        {
            this.data = data;
        }
        public MyLinkedListNode(T data, MyLinkedListNode<T> next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
