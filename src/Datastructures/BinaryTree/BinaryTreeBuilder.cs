namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IBinaryTree<int> CreateBinaryTreeEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            return tree;
        }

        //
        //         5
        //       /   \
        //     2       6
        //    / \    /  \
        //   8   7  9    10
        //  
        //
        public static IBinaryTree<int> CreateBinaryTreeInt()
        {
            BinaryTree<int> leaf1 = new BinaryTree<int>(8);
            BinaryTree<int> leaf2 = new BinaryTree<int>(7);
            BinaryTree<int> leaf3 = new BinaryTree<int>(9);
            BinaryTree<int> leaf4 = new BinaryTree<int>(10);
            BinaryTree<int> leftroot = new BinaryTree<int>();
            BinaryTree<int> rightroot = new BinaryTree<int>();
            BinaryTree<int> root = new BinaryTree<int>();
            leftroot.Merge(2, leaf1, leaf2);
            rightroot.Merge(6, leaf3, leaf4);
            root.Merge(5, leftroot, rightroot);
            return root;
        }

        //
        //         t
        //       /   \
        //     w       a
        //    / \     / \
        //   q   g   o   p
        public static IBinaryTree<string> CreateBinaryTreeString()
        {
            BinaryTree<string> tq = new BinaryTree<string>("q");
            BinaryTree<string> tg = new BinaryTree<string>("g");
            BinaryTree<string> to = new BinaryTree<string>("o");
            BinaryTree<string> tp = new BinaryTree<string>("p");
            BinaryTree<string> tw = new BinaryTree<string>();
            BinaryTree<string> tt = new BinaryTree<string>();
            BinaryTree<string> ta = new BinaryTree<string>();

            tw.Merge("w", tq, tg);
            ta.Merge("a", to, tp);
            tt.Merge("t", tw, ta);

            return tt;
        }
    }
}