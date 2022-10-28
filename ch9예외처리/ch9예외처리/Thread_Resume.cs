using System;
using System.Threading; // 추가
class Thread_Resume
{
    static Thread th_a1 = new Thread(FuncA);
    static Thread th_b1 = new Thread(FuncB);
    static void FuncA()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(3000);  // 3초 잠재우고 
            Console.WriteLine("A : Count = " + i);
            th_a1.Suspend(); // 한번 실행하고 나서 얼음이 됨
            // 얼음이 된 녀석은 누군가가 와서 깨워 주어야 다시 동작함
            // 그러므로 1 출력하고 나서 얼음이므로 정지됨.
        }
    }

    static void FuncB()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);  // 1초마다 동작
            Console.WriteLine("B : Count = " + i);
        }
        th_a1.Resume();  // B  다 출력하고 나서 A 깨워줌
    }
    static void Main(string[] args)
    {
        th_a1 = new Thread(FuncA);
        th_b1 = new Thread(FuncB);
        th_a1.Start();
        th_b1.Start();
    }
}

