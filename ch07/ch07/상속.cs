using System;
class 아빠
{
    protected string name = "김아빠";
    protected int age = 60;
    protected int money = 10000;
    protected string addr = "송도동 111번지 아빠 주소";
}   //현재 클래스와 상속된 클래스에서만 사용 .

class 아들 : 아빠  //  아빠 에서 아들 로 상속
{
    public 아들()  // 생성자 
    {
        this.name = "김아들";   // 생성자에서 값 초기화
        this.age = 17;
    }
    public void PrintInfo()
    {
        Console.WriteLine("저는 {0}입니다.", this.name);
        Console.WriteLine("제 나이는 {0}입니다.", this.age);
        Console.WriteLine("상속된 돈{0}원입니다.", this.money);
        Console.WriteLine("상속된 주소는 {0}입니다.", this.addr);
    }
}

class 상속
{
    static void Main(string[] args)
    {
        아들 철수 = new 아들();  // 아들 클래스를 이용하여 철수 인스턴스 객체 생성
        철수.PrintInfo();
    }
}