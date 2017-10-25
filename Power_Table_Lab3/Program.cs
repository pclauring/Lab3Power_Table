using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Table_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");

            string input = Console.ReadLine();
            int.TryParse(input, out int numberTable);

            Console.WriteLine("Number Squared Cubed");
            Console.WriteLine("====== ======= =====");
            for (int i = 1; i < (numberTable+1); i++)
            {
                {
                    Console.WriteLine(i + "        " + (i * i) + "       " + Math.Pow(i, 3));
                }
            }
        }
    }
}
