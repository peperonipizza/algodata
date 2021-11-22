using System;

namespace AD
{
    public partial class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FirstChildNextSiblingNode<T> root;

        public IFirstChildNextSiblingNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            if (root == null)
                return 0;
            return 1 + Size(root);
        }
        public int Size(FirstChildNextSiblingNode<T> node)
        {
            if (node.firstChild != null && node.nextSibling != null)
                return 2 + Size(node.firstChild) + Size(node.nextSibling);
            if (node.firstChild != null && node.nextSibling == null)
                return 1 + Size(node.firstChild);
            if (node.nextSibling != null && node.firstChild == null)
                return 1 + Size(node.nextSibling);
            else return 0;
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(root);
        }
        public void PrintPreOrder(FirstChildNextSiblingNode<T> node)
        {
            Console.WriteLine(node.data);
            if (node.firstChild != null)
                PrintPreOrder(node.firstChild);

            if (node.nextSibling != null)
                PrintPreOrder(node.nextSibling);
        }

        public override string ToString()
        {
            if (root == null)
                return "NIL";
            return $"{root.data}{ToString(root)}";
        }
        public string ToString(FirstChildNextSiblingNode<T> node)
        {
            if (node.firstChild != null && node.nextSibling != null)
                return $",FC({node.firstChild.data}{ToString(node.firstChild)}),NS({node.nextSibling.data}{ToString(node.nextSibling)})";
            if (node.firstChild != null && node.nextSibling == null)
                return $",FC({node.firstChild.data}{ToString(node.firstChild)})";
            if (node.nextSibling != null)
                return $",NS({node.nextSibling.data}{ToString(node.nextSibling)})";
            else return "";
        }
    }
}