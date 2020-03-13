using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace findaverage
{
    class Demo
    {
        static void Main()
        {
            var arr = new int[] { 10, 17, 25, 30, 40, 55, 60, 70 };
            double avg = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("Average = " + avg);
        }
    }
}
