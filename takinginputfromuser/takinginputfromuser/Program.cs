using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takinginputfromuser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("you are " + number + "years old");
        }
    }
}
