using System;
using Shape;

public class ch5_2_Method
{
    public static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        Console.Write("사각형의 가로의 길이를 입력하세요 : ");
        rect.width = Convert.ToInt32(Console.ReadLine());
        Console.Write("사각형의 세로의 길이를 입력하세요 : ");
        rect.height = Convert.ToInt32(Console.ReadLine());

        int round = rect.round();
        double areaHalf = rect.areaHalf();

        Console.WriteLine("사각형의 둘레의 길이는 {0}이고",round);
        Console.WriteLine("사각형의 면적의 반은 {0}이고",areaHalf);

        if (rect.isSquare()) Console.WriteLine("정사각형이다");
        else Console.WriteLine("직각사각형이다");
    }
}