using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    internal class BSRecursive
    {
        public int binarySearchRecursive(int[] arr, int value, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return -1;
            }
            else
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                if (value == arr[middleIndex])
                    return arr[middleIndex];
                else if (value < arr[middleIndex])
                    return binarySearchRecursive(arr, value, leftIndex, middleIndex - 1);
                else if (value > arr[middleIndex])
                    return binarySearchRecursive(arr, value, middleIndex + 1, rightIndex);
            }
            return -1;
        }
    }
}
