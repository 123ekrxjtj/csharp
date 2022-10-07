using System;
class kbs    // 클래스 이름 kbs
{
    public void PrintAge()   // public 이 아니면 다른 클래스에서 안보인다.
    {
        Console.WriteLine("PrintAge 메소드 호출");
    }

    public kbs()  // 매개변수 없는 Default 생성자는 생략 가능
    {
        Console.WriteLine("Default 생성자가 제일먼저  호출됨");
    }

}
class 디폴트생성자
{
    static void Main(string[] args)
    {                               //  new 순간 클래스를 메모리에 올리는 작업 
        kbs k1 = new kbs();  //  이 순간 default 생성자  kbs() 를 호출 - 매개변수 없음 
        k1.PrintAge();           // 마우스를 printAge() 위에 올려 볼 것       
    }
}

