using System;

namespace AD
{
    public partial class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>(rootItem, null, null);
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            return root;
        }


        public int Size()
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return 1 + Size(root.left) + Size(root.right);
            }
        }

        public int Size(BinaryNode<T> t)
        {
            if (t == null)
            {
                return 0;
            }
            else
            {
                return 1 + Size(t.left) + Size(t.right);
            }
        }

        public int Height()
        {
            if (root == null)
            {
                return -1;
            }
            else
            {
                return 1 + Math.Max(Height(root.left), Height(root.left));
            }
        }

        public int Height(BinaryNode<T> t)
        {
            if (t == null)
            {
                return -1;
            }
            else
            {
                return 1 + Math.Max(Height(t.left), Height(t.right));
            }
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            if (t1.root == t2.root && t1.root != null)
            {
                throw new Exception();
            }

            root = new BinaryNode<T>(rootItem, t1.root, t2.root);

            if (this != t1)
            {
                t1.root = null;
            }
            if (this != t2)
            {
                t2.root = null;
            }
        }

        public string ToPrefixString()
        {
            if (root != null)
            {
                return ToPrefixString(root);
            }
            else return "NIL";
        }

        public string ToPrefixString(BinaryNode<T> node)
        {
            if (node != null)
                return $"[ {node.data} {ToPrefixString(node.left)} {ToPrefixString(node.right)} ]";
            else return "NIL";
        }
        public string ToInfixString()
        {
            if (root != null)
            {
                return ToInfixString(root);
            }
            else return "NIL";
        }
        public string ToInfixString(BinaryNode<T> node)
        {
            if (node != null)
                return $"[ {ToInfixString(node.left)} {node.data} {ToInfixString(node.right)} ]";
            else return "NIL";
        }

        public string ToPostfixString()
        {
            if (root != null)
            {
                return ToPostfixString(root);
            }
            else return "NIL";
        }
        public string ToPostfixString(BinaryNode<T> node)
        {
            if (node != null)
                return $"[ {ToPostfixString(node.left)} {ToPostfixString(node.right)} {node.data} ]";
            else return "NIL";
        }

        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------
        int number = 0;
        public int NumberOfLeaves()
        {
            if (root != null)
                return Number(root);
            else
                return 0;
        }

        public int Number(BinaryNode<T> node)
        {
            if (node.left != null)
                Number(node.left);
            if (node.right != null)
                Number(node.right);
            else
                number++;
            return number;
        }

        public int NumberOfNodesWithOneChild()
        {
            return NumberOfNodesWithOneChild(root);
        }
        public int NumberOfNodesWithOneChild(BinaryNode<T> bn)
        {
            if (bn == null)
                return 0;
            if (bn.left == null && bn.right != null)
                return 1 + NumberOfNodesWithOneChild(bn.right);
            if (bn.left != null && bn.right == null)
                return 1 + NumberOfNodesWithOneChild(bn.left);
            if (bn.left == null && bn.right == null)
                return 0;
            else return 0;
        }

        public int NumberOfNodesWithTwoChildren()
        {
            return NumberOfNodesWithTwoChildren(root);
        }
        public int NumberOfNodesWithTwoChildren(BinaryNode<T> bn)
        {
            if (bn == null)
                return 0;

            if (bn.left != null && bn.right != null)
                return 1 + NumberOfNodesWithTwoChildren(bn.left) + NumberOfNodesWithTwoChildren(bn.right);

            if (bn.left != null && bn.right == null)
                return 0 + NumberOfNodesWithTwoChildren(bn.left);

            if (bn.left == null && bn.right != null)
                return 0 + NumberOfNodesWithTwoChildren(bn.right);

            else return 0;
        }
    }
}