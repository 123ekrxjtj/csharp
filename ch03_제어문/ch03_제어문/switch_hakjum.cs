using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03_제어문
{
    public class switch_hakjum
    {
        public static string Hakjum_gyesan(int jumsu)
        {
            int checkHakjum = jumsu / 10;
            string res = "";
            switch (checkHakjum)
            {
                case 10:
                    res = "A";
                    break;
                case 9:
                    res = "A";
                    break;
                case 8:
                    res = "B";
                    break;
                case 7:
                    res = "C";
                    break;
                case 6:
                    res = "D";
                    break;
                default:
                    res = "F";
                    break;
            }
            return res;
        }

        public static void Main(string[] args)
        {
            int jumsu = 0;
            string hakjum;

            while (true)
            {
                Console.Write("점수 입력 : ");
                jumsu = Convert.ToInt32(Console.ReadLine());
                if (jumsu == -999) break;
                else if (jumsu < 0 || jumsu > 100)
                {
                    Console.WriteLine("점수 범위 초과됨");
                    continue;
                }

                hakjum = Hakjum_gyesan(jumsu);
                Console.WriteLine("학점 {0}",hakjum);
            }

        }
    }
}
