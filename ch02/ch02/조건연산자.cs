using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02
{
    internal class 조건연산자
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            int max, min;

            if(a > b)
            {
                if (a > c) max = a;
                else max = c;

                if(b > c) min = c;
                else min = b;
            }
            else
            {
                if (b > c) max = b;
                else max = c;

                if(a>c) min = c;
                else min = a;
            }

            Console.WriteLine("The max : {0}, The min : {1}", max, min);

            max = a > b ? (a > c ? a : c) : (b > c ? b : c);
            min = a < b ? (a < c ? a : c) : (b < c ? b : c);

            Console.WriteLine("The max : {0}, The min : {1}", max, min);
        }
    }
}
