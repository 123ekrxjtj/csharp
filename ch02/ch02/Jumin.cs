using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02
{
    internal class Jumin
    {
        static string Calc_gubun(int gubun)
        {
            string retGubun;

            if (gubun % 2 == 1) retGubun = "남성";
            else retGubun = "여성";

            return retGubun;
        }

        static int Calc_Year(int year,int gubun)
        {
            int retYear;

            if (gubun < 3) retYear = 1900+year;
            else retYear = retYear = 2000+year;
        
            return retYear;
        }

        static int Calc_Age(string curDate, string jumin,int this_year)
        {
            int curMonth = Convert.ToInt32(curDate.Substring(5, 2));
            int curDays = Convert.ToInt32(curDate.Substring(8, 2));
            int month = Convert.ToInt32(jumin.Substring(2, 2));
            int days = Convert.ToInt32(jumin.Substring(4, 2));


        }

        public static void Main(string[] args)
        {

            Console.Write("주민번호 13자리를 입력하세요 >> ");
            string jumin = Console.ReadLine();

            string curDate = Convert.ToString(DateTime.Now);
            Console.WriteLine(curDate);
            int curYear = DateTime.Now.Year;
            int this_year = Convert.ToInt32(jumin.Substring(2, 2));
            int month = Convert.ToInt32(jumin.Substring(2, 2));
            int days = Convert.ToInt32(jumin.Substring(4, 2));
            int jencode = Convert.ToInt32(jumin.Substring(6, 1));

            string jender=Calc_gubun(jencode);
            int year = Calc_Year(this_year,jencode);
            int age = Calc_Age(curDate, jumin,this_year);


            Console.WriteLine("년도 >> {0}",year);
            Console.WriteLine("월 >> {0}",month);
            Console.WriteLine("일 >> {0}",days);
            Console.WriteLine("나이 >> {0}",age);
            Console.WriteLine("성별 >> {0}",jender);
        }
    }
}
