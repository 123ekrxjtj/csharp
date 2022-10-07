using Sachick;
using System;

namespace ch5_Method
{
    class 네임스페이스연습
    {
        //public class Hap_test
        //{
        //    public int a;
        //    public int b;
        //    public int Hap()
        //    {
        //        return a + b;
        //    }
        //} // Hap_test 끝
          // 같은 네임스페이스 내 일 때
        static void Main(string[] args)
        {
            Hap_test h_t = new Hap_test();
            h_t.a = 6;
            h_t.b = 4;
            int aa = h_t.Hap();
            Console.WriteLine("a+b={0}", aa);
        }
    } // 클래스 끝
}  // 네임스페이스 끝
