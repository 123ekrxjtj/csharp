using System;
public interface ISO  // 인터 페이스 설계
{
    void Area();
}         
public abstract class KS     // 추상 클래스 
{
    public abstract void Back();
}
public class Hundai : KS     //  KS를 Hundai 로 상속
{
    public override void Back()
    {
        Console.WriteLine("후진");
        /*
            사각형 면적 - 인터페이스
            둘레 - 추상 클래스 구현
         */
    }
}
public class Car : Hundai, ISO   // Car 로 Hundai, ISO  상속
{
    // 인터페이스 상속 받은 Run() 은 반드시 구현해야 함.
   public void Run()
    {
        Console.WriteLine("전진");
    }
}
class 인터페이스
{
    public static void Main()
    {
        Car sonata = new Car();
        sonata.Run();
        sonata.Back();
    }
}
