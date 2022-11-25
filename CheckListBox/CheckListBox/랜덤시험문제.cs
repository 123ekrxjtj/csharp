using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class 랜덤시험문제 : Form
    {
        GroupBox[] GB = new GroupBox[5]; // 그룹 박스 -2문제
        RadioButton[,] Bogi = new RadioButton[5, 5];  // 보기 -5개
        Label[] Quiz = new Label[2];            // 2 문제
        Label lbScore = new Label();     // 점수 표시 Label  
        Button button = new Button();  // Button 
        int Score = 0;                          // 점수 변수

        public 랜덤시험문제()
        {
            InitializeComponent();

            //  랜덤 변수
            Random rand = new Random();

            int[] randQues = new int[3];    //  랜덤으로 3개 문제 숫자 저장할 동적 배열

            //  3번 반복하면서
            for (int i = 0; i < 3; i++)
            {
                int randNum = rand.Next(5);

            }

            string aa = "[문제 ";   // 1]  은 소스에서 추가 해야 함
            string[,] Question = new string[5, 7] {
               {"다음중 1+1 = ?","일","이","삼","사","이" ,"TT"},
               {"인천에 있는 산은 ?","한라산","백두산","계양산" ,"금강산","계양산", "TT"},
               { "인천대학은 어느 구에 있나?","연수구","남구","중구","계양산","연수구", "TT"},
               { "이 건축물의 이름은,image/b.jpg", "불국사","경복궁","첨성대","다보탑","첨성대", "IT"},
               { "다음 중 성질이 다른 것은","image/a.jpg","image/b.jpg","image/c.jpg","image/d.jpg","image/d.jpg", "TI"}
            };

            #region
            // 점수 표시할 label 동적으로 생성
            // lbScore = new Label();
            this.lbScore.Name = "lbScore";
            this.lbScore.Text = "Score : ";
            this.lbScore.Size = new Size(90, 30);
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(180, 10+ (5*150));
            this.Controls.Add(lbScore);
            #endregion

            #region
            this.button.Name = "btnSubmit";
            this.button.Text = "채점하기";
            this.button.Size = new Size(90, 30);
            this.button.AutoSize = true;
            this.button.Location = new System.Drawing.Point(30, (5 * 150));
            this.button.Click += new EventHandler(button_Click);
            // 다음에 메소드 만들어 줘야 함.
            this.Controls.Add(button);
            #endregion

            #region    문제 랜덤 선택 , 보기 랜덤  선택
            // 문제 랜덤 선택 및 표시
            for (int n = 0; n < GB.Length; n++)
            {
                GB[n] = new GroupBox();
                this.GB[n].AutoSize = true;
                this.GB[n].Location = new System.Drawing.Point(10, 10 + (n * 150));
                this.GB[n].Size = new System.Drawing.Size(300, 120);
                this.GB[n].TabIndex = 0;
                this.GB[n].TabStop = false;
                this.GB[n].Text = aa + (n + 1) + "]  " + Question[n, 0];
                // [문제 1] 에서 뒷 ] 추가
                this.Controls.Add(GB[n]);
                for (int i = 0; i < 4; i++)  // 보기 (4개) 수만큼 반복
                {
                    Bogi[n, i] = new RadioButton();
                    this.Bogi[n, i].Location = new System.Drawing.Point(30, 30 + (i * 20));
                    this.Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                    this.Bogi[n, i].Text = Question[n, i + 1];

                    if (i == 4)
                        Bogi[n, 4].Visible = false;

                    this.Controls.Add(Bogi[n, i]);
                    this.GB[n].Controls.Add(this.Bogi[n, i]);
                }
            #endregion

            }

            void button_Click(object sender, EventArgs e)
            {
                Button button = sender as Button;   // button 객체 생성
                Score = 0;                                    // 이곳에서 점수 초기화 후
                for (int I = 0; I < 5; I++)  // 문제수  2
                {
                    for (int j = 0; j < 4; j++)    // 보기수 4
                    {
                        if (Bogi[I, j].Checked && Bogi[I,j].Text == Question[I,5]) {
                            Score++;
                        }
                    }
                }
                lbScore.Text = "Score : " + Convert.ToString(Score);
            }
        }
    }
}
