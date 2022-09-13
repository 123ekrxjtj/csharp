using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    //  internal == public
    public class Class1
    {
        static void Main(string[] args)
        {
            int n =1000;
            double sum = 0;
            double res;
            for (int i = 1; i < n; i++)
            {
                res = 1 / i;
                sum += res;
            }
            Console.WriteLine(sum);
        }
    }
}
