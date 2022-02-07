using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " " );//printing 0
            for(i=1;i<number;i++)
            {
                n3 = n1 + n2;//formula i.e 
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine(); 
        }
    }
}
