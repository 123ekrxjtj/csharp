using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 서준혁_자유낙하스레드
{
    public partial class 서준혁_자유낙하 : Form
    {
        private Point p, Red, Yellow, Blue;    //  포인터 객체
        private int score = 0;  //  점수

        private Random ran = new Random();  //  랜덤 클래스 ran
        static bool gameOver = false;   // 기본값 false 로 지정

        public 서준혁_자유낙하()
        {
            InitializeComponent();
            p.X = 15; p.Y = 400; //  플레이어 초기 좌표 할당

            //  공들 초기 좌표 할당
            Red.X = ran.Next(0,260); Red.Y = 0;
            Yellow.X = ran.Next(0, 260); Yellow.Y = 0;
            Blue.X = ran.Next(0, 260); Blue.Y = 0;

            //  스레드 3개 시작
            Run();
        }

        //  키 눌리면 호출하는 함수
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //  왼쪽키면
                case Keys.Left:
                    p.X -= 20;
                    //  x 좌표가 0 미만이면 300으로 초기화
                    if (p.X < 0) p.X = 300;
                    //  Invalidate();
                    break;
                //  오른쪽키면
                case Keys.Right:
                    p.X += 20;
                    //  x 좌표가 300 초과이면 0으로 초기화
                    if (p.X > 300) p.X = 0;
                    //  Invalidate();
                    break;
                default:
                    break;
            }
        }

        //  공들 그리는 함수
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black, p.X, p.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Red, Red.X, Red.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Yellow, Yellow.X, Yellow.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Blue, Blue.X, Blue.Y, 40, 40);
        }

        //  스레드 시작하는 함수
        public void Run()
        {
            new Thread(SafeCalcRed).Start();          //총 3개의 스레드가 생성됨.  Red색 공을 움직이기위한 Thread 생성 
            new Thread(SafeCalcBlue).Start();         //Blue 색 공을 움직이기위한 Thread 생성 
            new Thread(SafeCalcYellow).Start();        //Yellow 색 공을 움직이기위한 Thread 생성
        }

        //  인수로 받은 객체와 플레이어가 충돌했는지 판단하여 참, 거짓 반환
        private Boolean isCollision(Point circle)
        {
            //  충돌했는지 반환하는 변수, 기본 false
            Boolean boolCollision = false;

            //  객체와 플레이어 X 좌표 차이 제곱
            int dif_X_Square = (circle.X - p.X) * (circle.X - p.X);
            //  객체와 플레이어 Y 좌표 차이 제곱
            int dif_Y_Square = (circle.Y - p.Y) * (circle.Y - p.Y);

            //  Y 차이 제곱 + X 차이 제곱이 40 제곱보다 작으면 충돌
            if(dif_X_Square + dif_Y_Square <= 40 * 40) {
                return true;
            }
            return boolCollision;
        }

        //  빨간 공 스레드 함수
        private void SafeCalcRed()
        {
            //  점수 5 아래일 때
            while (score < 5)
            {
                //  무작위 속도로 내려옴
                Red.Y += ran.Next(1, 15);
                //  충돌했으면 X, Y좌표 초기화 후 점수 상승
                if (isCollision(Red))
                {
                    Red.X = ran.Next(0, 260);
                    Red.Y = 0;
                    score++;    //  점수 증가
                    lb_score.Text = Convert.ToString("점수 : " + score);
                }
                //  공이 화면 아래로 내려갔으면 좌표 초기화
                if (Red.Y > 500)
                {
                    Red.Y = 0;
                    Red.X = ran.Next(0, 260);
                }
                Invalidate();
                Thread.Sleep(50); 
            }

            GameOver();

        }



        // 점수 5 도달 시 호출
        static void GameOver()
        {
            //  이미 게임 오버 되었으면 함수 바로 종료
            if (gameOver) return;

            gameOver = true;

            MessageBox.Show("게임 종료함");
            Application.Exit();
        }


        //  노란 공 스레드 함수
        private void SafeCalcYellow()
        {
            //  점수 5 아래일 때
            while (score < 5)
            {
                //  무작위 속도로 내려옴
                Yellow.Y += ran.Next(1, 15);
                //  충돌했으면 X, Y좌표 초기화 후 점수 상승
                if (isCollision(Yellow))
                {
                    Yellow.X = ran.Next(0, 260);
                    Yellow.Y = 0;
                    score++;    //  점수 증가
                    lb_score.Text = Convert.ToString("점수 : " + score);
                }
                //  공이 화면 아래로 내려갔으면 좌표 초기화
                if (Yellow.Y > 500)
                {
                    Yellow.Y = 0;
                    Yellow.X = ran.Next(0, 260);
                }
                    Invalidate();
                Thread.Sleep(50);          
            }
            GameOver();

        }

        //  파란 공 스레드 함수
        private void SafeCalcBlue()
        {
            //  점수 5 아래일 때
            while (score < 5)
            {
                //  무작위 속도로 내려옴
                Blue.Y += ran.Next(1, 15);
                //  충돌했으면 X, Y좌표 초기화 후 점수 상승
                if (isCollision(Blue))
                {
                    Blue.X = ran.Next(0, 300);
                    Blue.Y = 0;
                    score++;    //  점수 증가
                    lb_score.Text = Convert.ToString("점수 : " + score);
                }
                //  공이 화면 아래로 내려갔으면 좌표 초기화
                if (Blue.Y > 500)
                {
                    Blue.Y = 0;
                    Blue.X = ran.Next(0, 300);
                }
                Invalidate();
                Thread.Sleep(50);          
            }
            GameOver();

        }

        private void KillTheThread()          //현재 실행중인 스레드를 지우기 위한 함수 
        {
            Thread.CurrentThread.Abort();      // 가장 최근의 스레드를 지워줌. 이는 함수내에 실행되는 스레드 삭제 .
        }
    }
}
