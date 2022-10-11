using System;

class Triangle_1
{
    //  7단계 코드
    //private int _Width;
    //private int _Height;
    //private int _Area;

    //public int Width
    //{
    //    get { return _Width; }
    //    set { _Width = value; }
    //}

    //public int Height
    //{
    //    get { return _Height; }
    //    set { _Height = value; }
    //}

    //public int Area
    //{
    //    get { return (Width * Height) / 2; }
    //}

    public int Width
    {
        get; set;
    }

    public int Height
    {
        get;set;
    }

    public int Area
    {
        get { return (Width * Height) / 2; }
    }
}

class Property_Test
{
    static void Main(string[] args)
    {
        Triangle_1 t1 = new Triangle_1();
        Console.Write("삼각형 밑변 : ");
        int a  = Convert.ToInt32(Console.ReadLine());
        Console.Write("삼각형 높이 : ");
        int b = Convert.ToInt32(Console.ReadLine());
        t1.Width = a;
        t1.Height = b;
        Console.WriteLine("삼각형 밑변 {0}과 높이 {1} 면적 {2} ",
            t1.Width,t1.Height,t1.Area);
    }
}