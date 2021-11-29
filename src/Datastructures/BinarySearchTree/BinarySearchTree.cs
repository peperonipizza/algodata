using System;

namespace AD
{
    public partial class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : IComparable<T>
    {

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x)
        {
            root = Insert(x, root);
        }

        public BinaryNode<T> Insert(T x, BinaryNode<T> t)
        {
            if (t == null)
            {
                t = new BinaryNode<T>(x);
            }
            else if (x.CompareTo(t.data) < 0)
            {
                t.left = Insert(x, t.left);
            }
            else if (x.CompareTo(t.data) > 0)
            {
                t.right = Insert(x, t.right);
            }
            else
            {
                throw new BinarySearchTreeDoubleKeyException();
            }
            return t;
        }

        public T elementAt(BinaryNode<T> t)
        {
            return t.data;
        }
        public T FindMin()
        {
            if (root != null)
                return elementAt(FindMin(root));
            else throw new BinarySearchTreeEmptyException();
        }
        public BinaryNode<T> FindMin(BinaryNode<T> t)
        {
            if (t != null)
                while (t.left != null)
                    t = t.left;
            return t;
        }

        public void RemoveMin()
        {
            if (root != null)
                root = RemoveMin(root);
            else throw new BinarySearchTreeEmptyException();
        }
        public BinaryNode<T> RemoveMin(BinaryNode<T> t)
        {
            if (t == null)
                throw new BinarySearchTreeElementNotFoundException();
            else if (t.left != null)
            {
                t.left = RemoveMin(t.left);
                return t;
            }
            else return t.right;
        }

        public void Remove(T x)
        {
            root = Remove(x, root);
        }
        public BinaryNode<T> Remove(T x, BinaryNode<T> t)
        {
            if (t == null)
                throw new BinarySearchTreeElementNotFoundException();

            if (x.CompareTo(t.data) < 0)
            {
                t.left = Remove(x, t.left);
            }

            if (x.CompareTo(t.data) > 0)
            {
                t.right = Remove(x, t.right);
            }

            else if (t.left != null && t.right != null)
            {
                t.data = FindMin(t.right).data;
                t.right = RemoveMin(t.right);
            }
            else t = (t.left != null) ? t.left : t.right;
            return t;
        }

        public override string ToString()
        {
            if (root == null)
                return "";
            else return ToString(root);
        }

        public string ToString(BinaryNode<T> node)
        {
            if (node.left != null)
                return ToString(node.left) + node.left.data;
            if (node.right != null)
                return ToString(node.right) + node.right.data;
            else return "";
        }
        public string InOrder()
        {
            throw new System.NotImplementedException();
        }

        // Tentamen 2013 eennakleinste element
        public BinaryNode<T> geefEenNaKleinsteElement()
        {
            BinaryNode<T> node = new BinaryNode<T>();
            if (root != null)
            {
                node = root.left;
                while (node != null)
                {
                    node = node.left;
                }
            }
            return node;
        }
    }
}
