using System;
using MyLibrarySearch;

namespace CSharpClientSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            UserLinkedList<int> list = new UserLinkedList<int>();

            list.Add(20);
            list.Add(12);
            list.Add(15);

            Console.Write("List: ");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int[] array = new int[list.Count];

            list.UserCopyTo(array, 0);
            Array.Sort(array);

            Console.Write("Sorted array: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            bool linearSearch = LinearSearch<int>.Search(list, 11);
            bool binarySearch = BinarySearch<int>.Search(array, 12);

            Console.WriteLine("Work of LinearSearch: {0}", linearSearch);
            Console.WriteLine("Work of BinarySearch: {0}", binarySearch);

            Console.Write("Work of StringSearch: ");

            StringMatcher.Search("aleaxa","eax");

            Console.ReadKey();
        }
    }
}
