// Class1.cs
using System;
namespace ch7_속성
{
    class 부모
    {
        public void Say()
        {
            Console.WriteLine("부모가 말하다.");
        }

        public virtual void Run()
        {
            Console.WriteLine("부모가 달리다.");
        }

        public void Hi()
        {
            Console.WriteLine("부모가 인사하다.");
        }
    }

    class 자식 : 부모   // 부모 클래스를 자식이 상속 받음
    {
        public new void Say()
        {
            Console.WriteLine("자식이 말하다.");
        }

        public void Hi()
        {
            Console.WriteLine("자식이 인사하다");
        }

        public override void  Run()
        {
            Console.WriteLine("자식이 달리다.");
        }
    }
}