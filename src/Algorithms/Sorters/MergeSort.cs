using System.Collections.Generic;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            /*int left = list[0];
            int right = list[list.Count];
            int center = list[list.Count / 2];
            int n1 = center - left + 1;
            int n2 = right - center;

            List<int> L = list.GetRange(left, center);
            List<int> R = list.GetRange(center + 1, right);
            int i = 1, j = 1;

            foreach (int k in list)
            {
                if (L[i] <= R[j])
                {
                    list[k] = L[i];
                    i++;
                }
                else
                {
                    list[k] = R[j];
                    j++;
                }
            }
            list.AddRange(L);
            list.AddRange(R);*/
        }
    }
}
