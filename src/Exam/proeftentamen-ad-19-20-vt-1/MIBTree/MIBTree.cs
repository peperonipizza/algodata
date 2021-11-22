namespace AD
{
    public class MIBTree : BinarySearchTree<MIBNode>
    {
        public MIBTree()
        {
            Insert(new MIBNode("1.3.6.1.4.1.9", "cisco"));
            Insert(new MIBNode("1.3.6.1.1.1.1", "system"));
            Insert(new MIBNode("1.3.6", "dod"));
            Insert(new MIBNode("1.3.6.1.1.1.4", "ip"));
            Insert(new MIBNode("1.3.6.1.3", "experimental"));
            Insert(new MIBNode("1.3.6.1.4.1", "enterprise"));
            Insert(new MIBNode("1.3.6.1.1.1.2", "interfaces"));
            Insert(new MIBNode("1.3.6.1.1", "directory"));
            Insert(new MIBNode("1.3", "org"));
            Insert(new MIBNode("1.3.6.1.4.1.2636", "juniperMIB"));
            Insert(new MIBNode("1.3.6.1.4.1.311", "microsoft"));
            Insert(new MIBNode("1.3.6.1", "internet"));
            Insert(new MIBNode("1", "iso"));
            Insert(new MIBNode("1.3.6.1.4", "private"));
            Insert(new MIBNode("1.3.6.1.1.1", "mib-2"));
            Insert(new MIBNode("1.3.6.1.2", "mgmt"));
        }

        public MIBNode FindNode(string oid)
        {
            if (root.data.oid == oid)
                return root.data;
            if (root.left != null)
                return FindNode(root.left.data.oid);
            if (root.right != null)
                return FindNode(root.right.data.oid);
            else return null;
        }

        public bool AllNodesAvailable(string oid)
        {
            int available = this.AllNodesAvailable(oid, this.GetRoot());
            int requested = oid.Split('.').Length;
            return available == requested;
        }

        public int AllNodesAvailable(string oid, BinaryNode<MIBNode> node)
        {
            return 1;
        }
    }
}
