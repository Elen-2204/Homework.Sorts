using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Sorts
{
    public static class SelectionSort
    {
        public static void SelectionSortRecursive(int[] array)
        {
            SelectionSortRecursiveHelper(array, 0, array.Length);
        }

        // Recursive helper function
        private static void SelectionSortRecursiveHelper(int[] array, int index, int n)
        {
            if (index >= n - 1)
                return;

            int minIndex = index;
            for (int j = index + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != index)
            {
                int temp = array[minIndex];
                array[minIndex] = array[index];
                array[index] = temp;
            }

            SelectionSortRecursiveHelper(array, index + 1, n);
        }
    }
}
