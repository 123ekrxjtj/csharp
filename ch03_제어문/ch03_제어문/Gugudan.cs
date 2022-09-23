using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03_제어문
{
    internal class Gugudan
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 9; i += 3)
            {
                for (int k = 1; k < 10; k++)
                {
                    for (int j = i; j < i + 3; j++)
                    {
                        Console.Write("{0} * {1} = {2:D2}\t", j,k,j*k);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
