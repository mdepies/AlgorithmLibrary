using System;
using System.Collections;
using System.Collections.Generic;

namespace CsAlgorithmLibrary
{
    public static class SortCategory
    {
        public static void InsertionSort(int[] itemArray)
        {
            if (itemArray is null || itemArray.Length < 2)
            {
                return;
            }
            for (int j = 1; j < itemArray.Length; j++)
            {
                int key = itemArray[j], i = j - 1;
                while (i >= 0 && itemArray[i] > key)
                {
                    itemArray[i + 1] = itemArray[i];
                    i--;
                }
                itemArray[i + 1] = key;
            }
        }
        public static void InsertionSort<T>(T[] itemArray) where T : IComparable<T>
        {
            if ((typeof(T).IsClass) && itemArray is null)
            {
                return;
            }
            for (int j = 1; j < itemArray.Length; j++)
            {
                T key = itemArray[j];
                int i = j - 1;
                while (i >= 0 && key.CompareTo(itemArray[i]) > 0)
                {
                    itemArray[i + 1] = itemArray[i];
                    i--;
                }
                itemArray[i + 1] = key;
            }
        }
    }
}