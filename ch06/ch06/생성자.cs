using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sbs    // 클래스 이름  sbs
{
    private static string name = "홍서방";       // 3 감추어진 필드에 접근 
    private static int age = 19;

    public static void Print()     //   2 공개된  public 한 메소드를 통해서만 가능 
    {
        Console.WriteLine(" 이름은: {0},   나이는 {1} ", sbs.name, sbs.age);
    }
}
class 생성자
{
    static void Main(string[] args)
    {
        sbs.Print();    // 1  외부에서 private 한 필드를 접근하려면
    }  // 여기서 sbs.name과 sbs.age를 바로 사용할 수 없다
}
