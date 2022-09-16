using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02
{
    internal class 성적입력
    {
        public static void Main(string[] args)
        {
            Console.Write("학번 입력 >> ");
            int stuNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("이름 입력 >> ");
            string? name = Console.ReadLine();

            Console.Write("국어 입력 >> ");
            int kor = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("영어 입력 >> ");

            int eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 입력 >> ");
            int math = Convert.ToInt32(Console.ReadLine());

            int sum = kor + eng + math;
            double avg = sum / (double)3;

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6:F2}",stuNum,name,kor,eng,math,sum,avg);
                

        }
    }
}
