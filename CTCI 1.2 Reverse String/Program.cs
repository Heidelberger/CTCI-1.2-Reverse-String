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
            string string1 = "0123456789";

            reverse(ref string1);

            Console.WriteLine(string1);

            Console.ReadLine();
        }

        private static void reverse(ref string string1)
        {
            string1 = "blah.";
        }
    }
}
