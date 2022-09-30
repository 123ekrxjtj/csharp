using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch04_배열과_Collection
{
    public class Sort
    {
        public static void Main(string[] args)
        {
            int[] a = new int[4] { 1, 3, 2, 4 };
            Console.WriteLine("정렬 전 데이터");

            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    int tmp;
                    if(a[i] < a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];    
                        a[j] = tmp; 
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
