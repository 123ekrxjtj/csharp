using System;
using System.Threading;     // 추가 
class Thread_Start
{
    static void Func_A()   // [1]스레드 몸체 작성 - 메소드
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("A : Count = " + i);
        }
    }
    static void Func_B()   // [1]스레드 몸체 작성 - 메소드
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("B : Count = " + i);
        }
    }
    static void Func_C()   // [1]스레드 몸체 작성 -메소드
    {
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("C : Count = " + i);
        }
    }
    static void Main(string[] args)
    {
        // [2]작성된 메소드를 ThreadStart 델리게이트에 연결
        // [3] 델리게이트를 이용하여 스레드 객체를 생성
        Thread th_a = new Thread(Func_A);  // FuncA 는 델리게이트에 연결된 메소드
        Thread th_b = new Thread(Func_B);  //Thread는 클래스 이름
        Thread th_c = new Thread(Func_C);
        th_a.Start(); // [4] Thread 를 Start 시킴
        th_b.Start();  // 이 순서대로 동작하지 않음
        th_c.Start();
    }
}




