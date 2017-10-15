using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrarySearch
{
    public class StringMatcher
    {
        public static void Search(string txt, string pattern)
        {
            int txtL = txt.Length;
            int patL = pattern.Length;

            string stages = "";
            bool isFound = false;

            for (int txtIndex = 0; txtIndex <= txtL - patL; txtIndex++)
            {
                int patIndex;
                for (patIndex = 0; patIndex < patL; patIndex++)
                {
                    if (txt[txtIndex + patIndex] != pattern[patIndex])
                        break;
                }
                if (patIndex == patL)
                {
                    stages += txtIndex.ToString() + " ";
                    isFound = true;
                }
            }
            if (isFound)
                Console.WriteLine("The pattern occurs with shift {0}", stages);
            else
                Console.WriteLine("The pattern NOT-FOUND");
        }
    }
}
