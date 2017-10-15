using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrarySearch
{
    public class BinarySearch<T>
    {
        public static bool Search(T[] array, T value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if ((array[mid] as IComparable<T>).CompareTo(value) == 0)
                    return true;
                else if ((array[mid] as IComparable<T>).CompareTo(value) > 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return false;
        }
    }
}
