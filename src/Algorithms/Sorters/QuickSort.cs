using System.Collections.Generic;


namespace AD
{
    public partial class QuickSort : Sorter
    {
        private static int CUTOFF = 3;

        public override void Sort(List<int> list)
        {
            // Should be implemented in lecture 4!
            QuickSort2(list, 0, list.Count - 1);
        }

        public void QuickSort2(List<int> list, int low, int high)
        {
            
        }
    }
}
