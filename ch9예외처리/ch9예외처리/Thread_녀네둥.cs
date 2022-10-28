using System;
using System.Threading; // 추가
class Thread_Suspend
{
    static Thread th_a = new Thread(FuncA);
    static Thread th_b = new Thread(FuncB);

    static void FuncA()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(3000);  // 1000 이 1초 
            Console.WriteLine("A : Count = " + i);
            if (i == 5)
                th_a.Suspend();  // 5 출력 후 얼음이 됨
            // 얼음이 된 녀석은 누군가가 와서 깨워 주어야 다시 동작함
        }
    }

    static void FuncB()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("B : Count = " + i);
        }
    }
    static void Main(string[] args)
    {
        th_a = new Thread(FuncA);
        th_b = new Thread(FuncB);
        th_a.Start();
        th_b.Start();
    }
}

