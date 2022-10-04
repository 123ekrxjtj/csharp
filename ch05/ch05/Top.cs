using System;
namespace ch5_Method
{
    public class Top
    {
        public int a;
        public int b;

        class Method_Class
        {
            static void Main(string[] args)
            {
                Top su = new Top();    // 인스턴스                         
                su.hap(5, 7);  // 매개변수 있다.
            }  // 여기서 값 전달 
        }


        public void hap(int a, int b)
        {
            Console.WriteLine(a + b);
        }  //  여기서 출력 해 버림
    }    // 이렇게 하지 말자.
}