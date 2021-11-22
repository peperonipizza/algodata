using System.Collections.Generic;


namespace AD
{
    public partial class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            int i, key, j;
            for (i = 1; i < list.Count; i++)
            {
                key = list[i];
                j = i - 1;
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }
        /*public override void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        public void Sort(List<int> list, int lo, int hi)
        {
            throw new System.NotImplementedException();
        }*/

    }
}
