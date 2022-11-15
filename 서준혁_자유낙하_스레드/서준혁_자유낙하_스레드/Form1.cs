using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 서준혁_자유낙하_스레드
{
    public partial class Form1 : Form
    {
        public partial class FrmKeyDown : Form
        {
            private Point p, Red, Yellow, Blue;    //  포인터 객체
            private int score = 0;  //  점수

            private Random ran = new Random();  //  랜덤 클래스 ran
            static bool gameOver = false;   // 기본값 false 로 지정

            public FrmKeyDown()
            {
                InitializeComponent();
                p.X = 15; p.Y = 400; //  플레이어 초기 좌표 할당

                Red.X = 0; Red.Y = 0;
                Yellow.X = 0; Yellow.Y = 0;
                Blue.X = 0; Blue.Y = 0;
            }

            private void FrmK됴애주_Paint(object sender, PaintEventArgs e)
            {
                e.Graphics.FillRectangle(Brushes.Red, Red.X, Red.Y, 40, 40);
                e.Graphics.FillRectangle(Brushes.Yellow, Yellow.X, Yellow.Y, 40, 40);
                e.Graphics.FillRectangle(Brushes.Blue, Blue.X, Blue.Y, 40, 40);
                e.Graphics.FillRectangle(Brushes.Black, p.X, p.Y, 40, 40);
            }

            private void FrmK됴애주_KeyDown(object sender, KeyEventArgs e)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        p.X -= 20;
                        if (p.X < 0) p.X = 300;
                        Red.Y += 30;
                        if (Red.Y > 500) Red.Y = 0;
                        Invalidate();
                        break;
                    case Keys.Right:
                        p.X += 20;
                        if (p.X > 300) p.X = 0;
                        Red.Y += 30;
                        if (Red.Y > 500) Red.Y = 0;
                        Invalidate();
                        break;
                    default:
                        break;
                }
                int difX = (p.X - Red.X) * (p.X - Red.X);
                int difY = (p.Y - Red.Y) * (p.Y - Red.Y);
                if (difX + difY <= 40 * 40)
                {
                    Red.Y = 0;
                    score++;
                    label1.Text = Convert.ToString(score);
                    if (score == 5)
                    {
                        MessageBox.Show("게임종료");
                        Application.Exit();
                    }
                }
            }

            public void Run()
            {
                new Thread(SafeCalcRed).Start();          //총 3개의 스레드가 생성됨.  Red색 공을 움직이기위한 Thread 생성 
                new Thread(SafeCalcBlue).Start();         //Blue 색 공을 움직이기위한 Thread 생성 
                new Thread(SafeCalcYellow).Start();        //Yellow 색 공을 움직이기위한 Thread 생성
            }

            private void SafeCalcRed()
            {
                while (score < 5)
                {
                    int randomnum = ran.Next(1, 15);        // 매 순간마다 다른 값을 주기위해 randnum 생성 
                    Red.X += randomnum; Invalidate();
                    Red.Y += 20;
                    Thread.Sleep(50);           //Thread가 일시적으로 중지되는 것인데, 이는 공의 속도와 관련되있어진다. 스레드 삭제시에도 필요함. Thread(밀리초) 
                }

                GameOver();

            }



            // 점수 5 도달 시 호출
            static void GameOver()
            {
                MessageBox.Show("게임 종료함");
                Application.Exit();
            }



            private void SafeCalcYellow()
            {
                while (score < 5)
                {
                    int randomnum = ran.Next(1, 15);        // 매 순간마다 다른 값을 주기위해 randnum 생성 
                    Yellow.X += randomnum; Invalidate();
                    Yellow.Y += 20;
                    Thread.Sleep(50);           //Thread가 일시적으로 중지되는 것인데, 이는 공의 속도와 관련되있어진다. 스레드 삭제시에도 필요함. Thread(밀리초) 
                }
                GameOver();

            }

            private void SafeCalcBlue()
            {
                while (score < 5)
                {
                    int randomnum = ran.Next(1, 15);        // 매 순간마다 다른 값을 주기위해 randnum 생성 
                    Blue.X += randomnum; Invalidate();
                    Blue.Y += 20;

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
}
