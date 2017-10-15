using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrarySearch
{
    public class LinearSearch<T>
    {
        public static bool Search(IEnumerable<T> list, T value)
        {
            foreach (var item in list)
            {
                if (item.Equals(value))
                    return true;
            }
            return false;
        }
    }
}
