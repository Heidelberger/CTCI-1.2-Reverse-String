using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_1._2_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cracking the Coding Interview");
            Console.WriteLine("Chapter 1, Problem 1.2");
            Console.WriteLine("Reverse a null-terminated string");
            Console.WriteLine();

            string string1 = "0123456789";
            Console.WriteLine("Original:        " + string1);

            reverse_array(ref string1);
            Console.WriteLine(".NET array:      " + string1);

            reverse_linq(ref string1);
            Console.WriteLine(".NET LINQ:       " + string1);

            reverse_manual(ref string1);
            Console.WriteLine("Manual:          " + string1);

            char[] array1 = string1.ToCharArray();
            reverse_nullterm(ref array1);
            Console.WriteLine("Null-terminated: " + new string(array1));

            Console.ReadLine();
        }

        private static void reverse_nullterm(ref char[] passed_array)
        {
            passed_array = passed_array.Reverse().ToArray();
        }

        private static void reverse_linq(ref string string1)
        {
            string1 = new string(string1.ToCharArray().Reverse().ToArray());
        }

        private static void reverse_array(ref string string1)
        {
            char[] array1 = string1.ToCharArray();

            Array.Reverse(array1);

            string1 = new string(array1);            
        }

        private static void reverse_manual(ref string string1)
        {
            int count_start = 0;
            int count_end = string1.Length - 1;

            char temp_char;

            char[] array1 = string1.ToCharArray();

            //reverse in-place to save memory
            while (count_start < count_end)
            {
                temp_char = string1[count_start];
                array1[count_start] = array1[count_end];
                array1[count_end] = temp_char;

                ++count_start;
                --count_end;
            }

            string1 = new string(array1);
        }
    }
}
