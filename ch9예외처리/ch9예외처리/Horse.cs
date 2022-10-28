using System;
using System.Threading;  // 추가
class HorseRacing
{
    static int sel;  // 내가 선택한 말을 저장할 변수
    static Thread[] horse = new Thread[3];
    // 말  3  마리의 스레드를 배열로 선언
    static int posA = 0, posB = 0, posC = 0;  // 각 말의 위치 지정
    static Random rnd = new Random(DateTime.Now.Millisecond);
    // 랜덤 시간 생성
    static bool gameOver = false;   // 기본값 false 로 지정
                                    // 3번말이 제일 먼저 결승점에 도착해서 우승이라고 표시한 후
                                    // 2번말이 결승점에 2등으로 도착하면 또 우승이라고 표시됨
                                    // 이것을 막기 위해 flag = false  사용함. 
                                    // GameOver(int index)는 말이 결승점에 도착했을 때 호출되며, 
                                    // 도착한 말의 번호가 매개변수로 전달 됨.
    static void GameOver(int index)   // 제일 처음으로 도달한 번호에서 한번만 실행됨
    {
        if (gameOver == true)
        {
            return; // 처음만 통과, 밑에서 true 로 지정하므로 두번째 부터는 수행하지 않음
        }
        Console.SetCursorPosition(0, 4);   // y 좌표 값 지정 4번째 줄에 출력
        Console.WriteLine(index.ToString() + "번 말이 우승했습니다. ");
        Console.SetCursorPosition(0, 5);  // y 좌표 값 지정 5번째 줄에 출력
        if (sel == index)  // sel 은 내가 선택한 말의 번호
            Console.WriteLine("당신이 선택한 " + sel + " 번 말이 승리했습니다. ");
        else
            Console.WriteLine("당신이 선택한 " + sel + " 번 말이 패배했습니다. ");
        gameOver = true;   // 처음 한번은 GameOver 메소드 처음부터 끝까지 수행하고
                           // 마지막에 true 로 세팅하므로 두 번째부터는 return 문으로 흐름을 되돌려준다.
    }
    static void Horse1()  // 1번 말 달리게 하는 메소드 선언
    {
        while (posA < 70) // y 좌표 70 이 결승점임, PosA의 초기값은 0
        {
            System.Threading.Thread.Sleep(50);
            //  매개변수 시간 만큼 정지했다가 다시 자동으로 시작함(밀리초)
            Console.SetCursorPosition(posA, 9);  //  y 값 9번째 줄에 출력
            Console.Write("->1"); // 출력
            posA += rnd.Next(0, 3);
            // 0,1,2 의 정수 값을 랜덤하게 발생시켜 말의 위치를 이동시킴
        }
        GameOver(1);  // 매개변수로 말의 번호가 전달됨.
    }
    static void Horse2()
    {
        while (posB < 70)
        {
            System.Threading.Thread.Sleep(50);
            Console.SetCursorPosition(posB, 12);  //  y 값 12번째 줄에 출력
            Console.Write("->2");
            posB += rnd.Next(0, 3);
            // 0,1,2 의 정수 값을 랜덤하게 발생시켜 말의 위치를 이동시킴
        }
        GameOver(2);
    }
    static void Horse3()
    {
        while (posC < 70)
        {
            System.Threading.Thread.Sleep(50);
            Console.SetCursorPosition(posC, 15);  // y 값 15번째 줄에 출력
            Console.Write("->3");
            posC += rnd.Next(0, 3);
            // 0,1,2 의 정수 값을 랜덤하게 발생시켜 말의 위치를 이동시킴
        }
        GameOver(3);
    }
    static void Main(string[] args)
    {
        horse[0] = new Thread(Horse1);
        // Thread 클래스의 horse[0] 인스턴스를 Horse1()의 메소드를 대리자로 사용
        horse[1] = new Thread(Horse2);  // Horse2()의 메소드
        horse[2] = new Thread(Horse3);  // Horse3()의 메소드 
        Console.Write("당신의 말을 선택하세요 (1-3) : ");
        sel = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("당신이 선택한 말은 " + sel + "번 말입니다..");

        horse[0].Start();
        horse[1].Start();
        horse[2].Start();
    }
}

