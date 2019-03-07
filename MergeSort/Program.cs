using System;
using System.Collections.Generic;

namespace MergeSort
{
    class MergeSorting
    {
        public static void MergeSort<T>(T[] array, int left, int right) where T : IComparable
        {
            if(left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        public static void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable
        {
            int LeftLength = middle - left - 1;
            int RightLength = right - middle;

            var LeftArray = new T[LeftLength];
            var RightArray = new T[RightLength];


            for (int i = 0; i < LeftLength; i++)
            {
                LeftArray[i] = array[left + i];   
            }


            for (int j = 0; j < RightLength; j++)
            {
                RightArray[j] = array[middle + j + 1];
            }

            int i2 = 0;
            int j2 = 0;
            int k = left;



            while(i2 < LeftLength && j2 < RightLength)
            {
                if(LeftArray[i2].CompareTo(RightArray[j2])<= 0)
                {
                    array[k] = LeftArray[i2];
                    i2 = i2 + 1;
                    k = k + 1;
                }
                else
                {
                    array[k] = RightArray[j2];
                    j2 = j2 + 1;
                    k = k + 1;
                }
            }

            while(i2 < LeftLength)
            {
                array[k] = LeftArray[i2];
                i2 = i2 + 1;
                k = k + 1;
            }

            while(j2 < RightLength)
            {
                array[k] = RightArray[j2];
                j2 = j2 + 1;
                k = k + 1;
            }
        }
    }
}
