//  1단계 메소드로 처리
//using System;
//class 속성
//{
//    public static void Main(string[] args)
//    {
//        //[1] 절차 지향에서 고전적인 방법
//        string name = "절차지향방법";    // 지역변수 사용
//        int age = 20;
//        NewMethod(name, age);
//    }

//    private static void NewMethod(string name, int age)
//    {
//        Console.WriteLine("이름 : {0}, 나이 : {1}", name, age);
//    }
//}

using System;

//  2단계 : 구조체
//public struct saram  //구조체선언
//{
//    public string name;
//    public int age;
//    // 반드시 public 으로 선언되어야 함
//    public static void Print(string name, int age)
//    {
//        Console.WriteLine("이름은 {0}, 나이는 {1}",
//                name, age);
//    }
//}   //  객체 지향언어의 구조체는 메소드 포함

//class 속성
//{
//    public static void Main()
//    {
//        //[2] 구조체 사용
//        saram a; // 객체 a 생성
//        a.name = "구조체a";
//        a.age = 11;
//        saram.Print(a.name, a.age);

//        saram b;  // 객체 b 생성
//        b.name = "구조체b";
//        b.age = 33;
//        saram.Print(b.name, b.age);
//    }
//}

//  3단계 : 클래스
//public class saram  //구조체선언
//{
//    public string name;
//    public int age;
//    // 반드시 public 으로 선언되어야 함
//    public static void Print(string name, int age)
//    {
//        Console.WriteLine("이름은 {0}, 나이는 {1}",
//                name, age);
//    }
//}   //  객체 지향언어의 구조체는 메소드 포함

//class 속성
//{
//    public static void Main()
//    {
//        //[2] 구조체 사용
//        saram a = new saram(); // 객체 a 생성
//        a.name = "구조체a";
//        a.age = 11;
//        saram.Print(a.name, a.age);

//        saram b = new saram();  // 객체 b 생성
//        b.name = "구조체b";
//        b.age = 33;
//        saram.Print(b.name, b.age);
//    }
//}

//  4단계 : private로 수정
//public class saram  //구조체선언
//{
//    private string name;
//    private int age;
//    // 반드시 public 으로 선언되어야 함
//    public void Print(string name, int age)
//    {
//        Console.WriteLine("이름은 {0}, 나이는 {1}",
//                name, age);
//    }
//}   //  객체 지향언어의 구조체는 메소드 포함

//class 속성
//{
//    public static void Main()
//    {
//        //[2] 구조체 사용
//        saram a = new saram(); // 객체 a 생성
//        //a.name = "구조체a";
//        //a.age = 11;
//        a.Print("클래스 a",11);

//        saram b = new saram();  // 객체 b 생성
//        //b.name = "구조체b";
//        //b.age = 33;
//        b.Print("클래스 b",12);
//    }
//}


//  5단계 : 매개변수 있는 생성자
//public class saram  //구조체선언
//{
//    private string name;
//    private int age;

//    public saram(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    // 반드시 public 으로 선언되어야 함
//    public void Print()
//    {
//        Console.WriteLine("이름은 {0}, 나이는 {1}",
//                name, age);
//    }
//}   //  객체 지향언어의 구조체는 메소드 포함

//class 속성
//{
//    public static void Main()
//    {
//        //[2] 구조체 사용
//        saram a = new saram("강감찬",88); // 객체 a 생성
//        a.Print();
//    }
//}

//  6단계 : 매개변수 있는 생성자
//using System;
//public class saram
//{
//    private string name;
//    private int age;
//    public string GetName()
//    {
//        return this.name;
//    }      // public 한 메소드로 접근
//    public int GetAge()
//    {
//        return this.age;
//    }    // public 한 메소드로 접근
//    public void SetName(string value)
//    {
//        this.name = value; // 저장
//    }
//    public void SetAge(int value)
//    {
//        this.age = value; // 저장
//    }
//}

//class 속성
//{
//    static void Main(string[] args)
//    {
//        //saram c = new saram("강감찬", 888);
//        saram c = new saram();
//        c.SetName("강감이");
//        c.SetAge(888);
//        Print(c.GetName(), c.GetAge());
//    }

//    private static void Print(string name, int age)
//    {
//        Console.WriteLine("이름 {0},  나이 {1}",name, age);
//    }
//}

//  7단계 : 속성
//using System;
//public class saram
//{
//    private string _Name; // 첫자 대문자에 _  씀
//    private int _Age;     // 첫자 대문자에 _ 씀

//    public string Name   // 속성에 괄호 ()가 없다.          
//    {
//        get { return _Name; }   // get  -읽어올때
//        set { _Name = value; }  // set - 저장할때 
//    }                     //value 키워드

//    public int Age       //속성-- 괄호가 없다.
//    {
//        get { return _Age; }  //get - 읽어올 때
//        set { _Age = value; } //set - 저장할때
//    }
//}

//public class 속성
//{
//    public static void Main()
//    {
//        saram c = new saram();
//        c.Name = "강감찬이다";
//        c.Age = 889;
//        // 여기서 값을 지정함
//        Print(c.Name, c.Age);
//    }
//    private static void Print(string name, int age)
//    {

//        Console.WriteLine("이름은 {0}, 나이는 {1}  ",
//             name, age);
//    }
//}

//  8단계 : 매개변수 있는 생성자
using System;
public class saram
{
    //prop 탭하면 자동 생성
    //  public int _age;
    //  public string _name;
    //  속성으로 인식하도록 해줌
    public int Age { get; set; }
    public string Name { get; set; }
}

public class 속성
{
    public static void Main()
    {
        saram c = new saram();
        c.Name = "강감찬이다";
        c.Age = 889;
        // 여기서 값을 지정함
        Print(c.Name, c.Age);
    }
    private static void Print(string name, int age)
    {

        Console.WriteLine("이름은 {0}, 나이는 {1}  ",
             name, age);
    }
}