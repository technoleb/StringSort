using System;
using System.Text.RegularExpressions;

namespace StringSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a String To Sort: ");
            // Get String inut
            string str = Console.ReadLine();
            // Remove any Special Characters,  Just contains Numbers and alphabets, will convert the whole string to lower case
            string strToSort = Regex.Replace(str, @"[^0-9a-zA-Z]+", "").ToLower();
            
            int lenStr = strToSort.Length;

            // convert input string to an array
            char[] arrStr = strToSort.ToCharArray(0, lenStr);
            char ch;

            // Sort an Array
            for (int i = 1; i < lenStr; i++)
            {
                for (int j = 0; j < lenStr - i; j++)
                {
                    if (arrStr[j] > arrStr[j + 1]) 
                    {
                        ch = arrStr[j];
                        arrStr[j] = arrStr[j + 1];
                        arrStr[j + 1] = ch;
                    }
                }
            }

            // Connect sorted array to string
            Console.Write("\nSorted Srting : \n");
            foreach (char c in arrStr)
            {
                ch = c;
                Console.Write("{0}", ch);
            }
            Console.WriteLine("\n");

            Console.Write("Original String : \n");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
