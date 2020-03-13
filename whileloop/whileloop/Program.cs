using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target");
            int target = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= target)
            {
                Console.Write
                    (start + " ");
                start = start + 2;
            }


        }
    }
}
