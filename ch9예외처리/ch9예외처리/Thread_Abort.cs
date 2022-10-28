using System;
using System.Threading;     // 추가
class Thread_Abort
{
    static Thread th_x = new Thread(FuncA);  // 스레드 객체 생성
    static Thread th_y = new Thread(FuncB); // 스레드 객체 생성
    static void FuncA()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i >= 3)  // A는 0,1,2까지만 출력함
            {
                th_x.Abort();  // 해당 스레드 종료 함
            }
            Console.WriteLine("A : Count = " + i);
        }
    }

    static void FuncB()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("B : Count = " + i);
        }
    }

    static void Main(string[] args)
    {
        th_x = new Thread(FuncA); //  델리게이트를 이용하여 스레드 객체를 생성
        th_y = new Thread(FuncB); //  델리게이트를 이용하여 스레드 객체를 생성
        th_x.Start();
        th_y.Start();
    }
}

