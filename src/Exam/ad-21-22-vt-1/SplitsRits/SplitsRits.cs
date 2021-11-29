
namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public (MyLinkedList<T>, MyLinkedList<T>) Splits()
        {
            MyLinkedList<T> l1 = new MyLinkedList<T>();
            MyLinkedList<T> l2 = new MyLinkedList<T>();

            int count = 0;
            for (var node = first; node != null; node = node.next)
                (count++ % 2 == 0 ? l1 : l2).AddFirst(node.data);

            return (l1, l2);
        }

        public void Rits(MyLinkedList<T> list1, MyLinkedList<T> list2)
        {
            var node1 = list1.first;
            var node2 = list2.first;
            while ((node1 ?? node2) != null)
            {
                if (node1 != null)
                {
                    AddLast(node1.data);
                    node1 = node1.next;
                }

                if (node2 != null)
                {
                    AddLast(node2.data);
                    node2 = node2.next;
                }
            }
        }
    }
}
