using System;

namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Empty ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();
            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Small ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();

            FirstChildNextSiblingNode<string> d = new FirstChildNextSiblingNode<string> ("d");
            FirstChildNextSiblingNode<string> c = new FirstChildNextSiblingNode<string> ("c");
            FirstChildNextSiblingNode<string> b = new FirstChildNextSiblingNode<string> ("b", d, c);
            FirstChildNextSiblingNode<string> a = new FirstChildNextSiblingNode<string> ("a", b, null);

            tree.root = a;

            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_18_3 ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string>();
            FirstChildNextSiblingNode<string> g = new FirstChildNextSiblingNode<string>("g");
            FirstChildNextSiblingNode<string> k = new FirstChildNextSiblingNode<string>("k");
            FirstChildNextSiblingNode<string> j = new FirstChildNextSiblingNode<string>("j", k, null);
            FirstChildNextSiblingNode<string> i = new FirstChildNextSiblingNode<string>("i", null, j);
            FirstChildNextSiblingNode<string> e = new FirstChildNextSiblingNode<string>("e", i, null);
            FirstChildNextSiblingNode<string> h = new FirstChildNextSiblingNode<string>("h");
            FirstChildNextSiblingNode<string> d = new FirstChildNextSiblingNode<string>("d", h, e);
            FirstChildNextSiblingNode<string> c = new FirstChildNextSiblingNode<string>("c", null, d);
            FirstChildNextSiblingNode<string> f = new FirstChildNextSiblingNode<string>("f", null, g);
            FirstChildNextSiblingNode<string> b = new FirstChildNextSiblingNode<string>("b", f, c);
            FirstChildNextSiblingNode<string> a = new FirstChildNextSiblingNode<string>("a", b, null);
            tree.root = a;
            return tree;

        }
    }
}