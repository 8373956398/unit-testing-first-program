using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrograms
{
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            BasicOperations basicOperations = new BasicOperations();
            Console.WriteLine("4+5 is {0}", basicOperations.Add(4, 5));
            Console.WriteLine("7*2 is {0}", basicOperations.Mul(7, 2));
            Console.WriteLine("15/5 is {0}", basicOperations.Div(15, 5));
            Console.WriteLine("7-5 is {0}", basicOperations.Sub(7, 5));

            ClassicPrograms classicPrograms = new ClassicPrograms();
            Console.WriteLine("Is 4 Prime? {0}", classicPrograms.IsPrime(9));
            Console.WriteLine("Is 7 Odd? {0}", classicPrograms.IsOdd(7));
            Console.WriteLine("Is 3 Even? {0}", classicPrograms.IsEven(3));
            Console.ReadLine();
        }
    }
}
