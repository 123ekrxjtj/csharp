using System;
class OutExec
{
    public static void Exchange(int won, out float Doller, out float Yen)
    {       // 리턴값이 없으므로 void 사용
        Doller = won / 1300;  // return  사용 안함 – 주소에 데이터가 바뀌어 있음
        Yen = won / 10;  // 주소에 데이터가 바뀌어 있음     
    }
    static void Main(string[] args)
    {
        int won; float Doller; float Yen;
        Console.Write("환산할 금액을 입력하세요 : ");
        won = Convert.ToInt32(Console.ReadLine());
        Exchange(won, out Doller, out Yen);
        Console.WriteLine("달러로 환산한 금액은 {0}", Doller);
        Console.WriteLine("엔화로 환산한 금액은 {0}", Yen);
    }
}
