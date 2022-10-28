using System;
using System.Threading; // 추가
class Thread_Sleep
{
    static Thread th_a = new Thread(FuncA);
    static Thread th_b = new Thread(FuncB);

    static void FuncA()
    {
        for (int i = 0; i < 10; i++)
        {                                                // A 출력시 3초 지연됨 
            System.Threading.Thread.Sleep(3000);  // 1000 이 1초 
            Console.WriteLine("A : Count = " + i);
        }
    }
    static void FuncB()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);  // B 출력시 1초 지연됨
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
