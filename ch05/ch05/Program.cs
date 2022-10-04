using System;

class Method
{
    public static void Main(string[] args)
    {
        Start();
        Hi("매개변수 있는 메소드");
        int value = Plus(3, 4);

        Print_out("다른 타입 매개변수", 4);
    }

    private static void Print_out(string v1, int v2)
    {
        for (int i = 0; i < v2; i++)
        {
            Console.WriteLine("{0} {1}",i,v1);
        }
    }

    private static int Plus(int v1, int v2)
    {
        int c =v1 + v2;
        return c;
    }

    private static void Hi(string a)
    {
        Console.WriteLine("Hi {0}",a);
    }

    private static void Start()
    {
        Console.WriteLine("2124124");
    }
}