using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch04_배열과_Collection
{
    internal class 빈도수_최빈값
    {
        public static void Main(string[] args)
        {
            int data = 0;
            int[] su = new int[10] { 0,0,0,0,0,0,0,0,0,0};
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("0부터 9 사이 10개 입력 : ");
                data = Convert.ToInt32(Console.ReadLine());
                su[data]++;
            }

            Console.WriteLine("입력값\t빈도수");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}\t{1}", i, su[i]);
            }
        }
    }
}
