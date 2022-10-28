using System;
delegate int MyDelegate(int a, int b); // [2]델리게이트 선언 – 클래스 밖에 선언 
                                       //  반환 형식, 매개변수 목록 이 같이야 함.
class Calc
{
    public int Plus(int a, int b)   // [1]인스턴스 메소드 선언
    {
        return a + b;
    }

    public static int Minus(int a, int b)  // [1]정적 메소드 선언
    {
        return a - b;
    }
}

class Test_Delegate
{
    static void Main()
    {
        Calc C1 = new Calc();   //[3,4] Calc 클래스의 인스턴스 C1 생성

        //[3,4] P1 델리게이트 인스턴스 P1 생성 
        MyDelegate P1 = new MyDelegate(C1.Plus);

        Console.WriteLine("30 + 4 = " + P1(30, 4)); //  P1[5] 인스턴스 메소드 호출

        //[3,4] P2 델리게이트 인스턴스 P2 생성
        MyDelegate P2 = new MyDelegate(Calc.Minus);
        // 정적 객체이므로  클래스 이름  Calc 바로 사용함
        Console.WriteLine("70 - 5 = " + P2(70, 5));   // [5] P2 정적  메소드 호출
    }
}
