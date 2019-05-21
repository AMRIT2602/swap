using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            
            Console.Write("\nInput the First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + a);
            Console.Write("\nSecond Number : " + b);
            Console.Read();
        }
    }
}
