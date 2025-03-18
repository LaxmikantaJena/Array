using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMMINGPART
{
    //Find the second Highest Number in Array
    internal class SecondHtNumberArray
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 26, 45, 10, 15, 18, 78 };
            int max = int.MinValue;
            int secondmax = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                {
                    secondmax = max;
                    max = num;
                }
                else if (num > secondmax && num != secondmax)
                {
                    secondmax = num;
                }
                Console.WriteLine("Second highest one" + secondmax);
                Console.WriteLine("Highest Number one" + max);
            }
            Console.WriteLine("Second Max Number  :" + secondmax);
            Console.WriteLine("Highest Number  :" + max);
        }
    }
}
