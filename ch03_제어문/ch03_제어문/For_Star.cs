using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03_제어문
{
    internal class For_Star
    {
        public static void iStar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
            }
        }

        public static void jStar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('*');
            }
        }

        public static void ijStar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void pStar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            iStar(5);
            jStar(5);
            ijStar(5);
            pStar(5);
        }
    }
}
