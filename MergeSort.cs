using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class MergeSort
    {
        public static void Merge(int[] input, int left1,int mid,int right1)
        {
            //input = new int[] { 1, 2, 5,8, 3, 4, 6 };
            //left1 = 0;
            //right1 = input.Length-1;
            //mid = (right1-left1) / 2;

            int i, j;
            var n1 = mid - left1 + 1;
            var n2 = right1 - mid;

            var left = new int[n1];
            var right = new int[n2];

            for ( i = 0; i < n1; i++)
            {
                left[i] = input[left1 + i];
            }
            for(j=0;j<n2;j++)
            {
                right[j] = input[mid + j + 1];
            }

            i = j = 0;
            var k = left1;

            while(i<n1 && j<n2)
            {
                if (left[i]<=right[j])
                {
                    input[k] = left[i];
                    i++;
                }
                else
                {
                    input[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                input[k] = left[i];
                i++;
                k++;
            }
            while (j<n2)
            {
                input[k] = right[j];
                j++;
                k++;
            }
        }

        public static void SortMerge(int[] input, int l,int r)
        {
            if(l<r)
            {
                int m = l + (r - l) / 2;
                SortMerge(input, l, m);
                SortMerge(input, m + 1, r);
                Merge(input, l, m, r);
            }
        }
    }
}
