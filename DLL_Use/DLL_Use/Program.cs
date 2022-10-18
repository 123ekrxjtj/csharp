using System;
using DLL_Create;
namespace DLL_USE
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath a = new MyMath();
            int sum1 = a.Sum(100);
            int sum2 = a.Sum(2, 10);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
