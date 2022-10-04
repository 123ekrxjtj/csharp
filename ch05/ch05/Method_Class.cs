using System;
public class Top
{
    public static int a;
    public static int b;

    public static int hap()
    {
        return a + b;
    }
}

class Method_Class
{
    static void Main()
    {
        Top su = new Top();
        Top.a = 13;
        Top.b = 16;
        int sum = Top.hap();
        Console.WriteLine("{0} + {1} = {2}",
                                   Top.a, Top.b, sum);
    }
}
