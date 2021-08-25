using System.Collections.Generic;
using System.Linq;

namespace mergesort
{
    public static class ListExtensions
    {

        public static List<int> MergeSort(this List<int> list)
        {
            if (list.Count <= 1)
            {
                // the fuck shall i sort?
                return list;
            }

            var median = list.Count / 2;

            var left = new List<int>();
            for (int index = 0; index < median; index++)
            {
                left.Add(list[index]);
            }

            var right = new List<int>();
            for (int index = median; index < list.Count; index++)
            {
                right.Add(list[index]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            var result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());                        
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Any())
                {
                    // right side is empty dump all
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Any())
                {
                    // left side is empty dump all
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
