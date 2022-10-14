// 메소드오버라이드.cs
using ch7_속성;
using System;

namespace ch7_상속
{
    class 메소드오버라이드
    {
        static void Main(string[] args)
        {
            자식 Gildong = new 자식();
            Gildong.Say();  // 자식클래스의 객체 Gildong을 호출
            Gildong.Hi();
            Gildong.Run();
        }
    }
}
