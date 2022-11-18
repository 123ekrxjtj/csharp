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
    public partial class Form1 : Form
    {
        private Point p, Red, Yellow, Blue;    //  포인터 객체
        private int score = 0;  //  점수

                private Random ran = new Random();  //  랜덤 클래스 ran
        static bool gameOver = false;   // 기본값 false 로 지정

        public Form1()
        {
            InitializeComponent();
            p.X = 15; p.Y = 400; //  플레이어 초기 좌표 할당

            Red.X = ran.Next(0,260); Red.Y = 0;
            Yellow.X = ran.Next(0, 260); Yellow.Y = 0;
            Blue.X = ran.Next(0, 260); Blue.Y = 0;

            Run();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    p.X -= 20;
                    if (p.X < 0) p.X = 300;
                    //  Invalidate();
                    break;
                case Keys.Right:
                    p.X += 20;
                    if (p.X > 300) p.X = 0;
                    //  Invalidate();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black, p.X, p.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Red, Red.X, Red.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Yellow, Yellow.X, Yellow.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Blue, Blue.X, Blue.Y, 40, 40);
        }

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

        private void SafeCalcRed()
        {
            while (score < 5)
            {
                Red.Y += ran.Next(1, 15);
                //  충돌했으면 X, Y좌표 초기화 후 점수 상승
                if (isCollision(Red))
                {
                    Red.X = ran.Next(0, 260);
                    Red.Y = 0;
                    score++;    //  점수 증가
                    lb_score.Text = Convert.ToString("점수 : " + score);
                }
                if (Red.Y > 500)
                {
                    Red.Y = 0;
                    Red.X = ran.Next(0, 260);
                }
                Invalidate();
                Thread.Sleep(50);           //Thread가 일시적으로 중지되는 것인데, 이는 공의 속도와 관련되있어진다. 스레드 삭제시에도 필요함. Thread(밀리초) 
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



        private void SafeCalcYellow()
        {
            while (score < 5)
            {
                Yellow.Y += ran.Next(1, 15);
                //  충돌했으면 X, Y좌표 초기화 후 점수 상승
                if (isCollision(Yellow))
                {
                    Yellow.X = ran.Next(0, 260);
                    Yellow.Y = 0;
                    score++;    //  점수 증가
                    lb_score.Text = Convert.ToString("점수 : " + score);
                }
                if (Yellow.Y > 500)
                {
                    Yellow.Y = 0;
                    Yellow.X = ran.Next(0, 260);
                }
                    Invalidate();
                Thread.Sleep(50);           //Thread가 일시적으로 중지되는 것인데, 이는 공의 속도와 관련되있어진다. 스레드 삭제시에도 필요함. Thread(밀리초) 
            }
            GameOver();

        }

        private void SafeCalcBlue()
        {
            while (score < 5)
            {
                Blue.Y += ran.Next(1, 15);
                //  충돌했으면 X, Y좌표 초기화 후 점수 상승
                if (isCollision(Blue))
                {
                    Blue.X = ran.Next(0, 300);
                    Blue.Y = 0;
                    score++;    //  점수 증가
                    lb_score.Text = Convert.ToString("점수 : " + score);
                }
                if (Blue.Y > 500)
                {
                    Blue.Y = 0;
                    Blue.X = ran.Next(0, 300);
                }
                Invalidate();
                Thread.Sleep(50);           //Thread가 일시적으로 중지되는 것인데, 이는 공의 속도와 관련되있어진다. 스레드 삭제시에도 필요함. Thread(밀리초)
            }
            GameOver();

        }

        private void KillTheThread()          //현재 실행중인 스레드를 지우기 위한 함수 
        {
            Thread.CurrentThread.Abort();      // 가장 최근의 스레드를 지워줌. 이는 함수내에 실행되는 스레드 삭제 .
        }
    }
}
