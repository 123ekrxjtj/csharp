using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9예외처리
{
    public class 예외처리
    {
        public static void Main(string[] args)
        {
            int i = 3;
            int j = 0;
            int k = 0;

            try
            {
                //  에러 발생하지만 try 절에 들어가면 정상 종료
                k = i / j;  
            }
            catch(Exception ex)
            {
                Console.WriteLine("에러 발생");
                Console.WriteLine(ex.Message);
                //  시스템이 알려주는 메세지
                //  throw 제거
                //  이후 k에 여전히 0 저장되어 있음
            }

            //  k = 3 / 0;  //  컴파일 에러 발생
            //  k = i / j;  //  런타임 에러 발생, 실행해야 알 수 있다
            Console.WriteLine(k); 
        }
    }
}
