using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sorted_Array
{
    public static class Extension_String
    {
        public static int Count_Symbols(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c) counter++;
            }
            return counter;
        }
        public static string Reverse(this string str)
        {
            StringBuilder s = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s.Append(str[i]);
            }
            return s.ToString();
        }
    }
}
