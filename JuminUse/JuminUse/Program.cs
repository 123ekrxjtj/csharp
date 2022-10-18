using System;
using JuminDLL;

public class Jumin
{
    public static void Main(string[] args)
    {
        string jumin = "";
        jumin = Console.ReadLine();
        Console.WriteLine("년도 {0}", JuminDLL.Calculator.YEAR(jumin)); ;
        Console.WriteLine("월");
        Console.WriteLine("날");
        Console.WriteLine("나이");
        Console.WriteLine("성별");
    }

}

