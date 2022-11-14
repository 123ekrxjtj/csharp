using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gawi; //  dll 불러옴

namespace ch10_2_가위바위보
{
    public partial class 서준혁_가위바위보 : Form
    {
        public 서준혁_가위바위보()
        {
            InitializeComponent();
        }
        bool result_view;   //  결과 보기 플래그
        int User_count = 0, Com_count = 0, Draw_count = 0;
        // 내가 승,              컴승                비김 수 
        int User_S = 0, User_R = 0, User_P = 0;  // 나의 가위 바위 보 수
        int Com_S = 0, Com_R = 0, Com_P = 0; // 컴의 가위 바위 보 수

        //  결과 보기 / 접기 클릭 시 실행하는 함수
        private void btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();
        }

        //  결과 보기 / 접기 시 실행하는 함수
        private void Timer_View_Result_Tick(object sender, EventArgs e)
        {
            int size = 20;
            //  result_view가 참이 아니면 최대 뷰 사이즈까지 늘어남
            if (!result_view)
            {
                if (Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기 ◀";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            //  result_view가 참이면 최소 뷰 사이즈까지 축소
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기 ▶";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width -= size;
                }
            }
        }
        //  게임 결과와 내 숫자, 컴 숫자를 인수로 받아
        //  컴 이미지 갱신하고
        //  양쪽 가위, 바위, 보 숫자와 이김, 짐, 비김 갱신
        private void updateResult(string result, int my_num, int com_num)
        {
            //  게임 결과에 따라 이김, 비김, 짐 횟수 갱신
            if (result == "이김") User_count++;
            else if (result == "비김") Draw_count++;
            else if (result == "짐") Com_count++;

            //  총 게임 횟수 구하기
            int total_count = User_count + Draw_count + Com_count;

            //  내 숫자에 따라 컴 가위, 바위, 보 횟수 추가
            switch (my_num)
            {
                case 1: //  가위
                    User_S++;    //  내 가위 횟수 증가
                    break;
                case 2: //  바위
                    User_R++;    //  내 바위 횟수 증가
                    break;
                case 3: //  보
                    User_P++;    //  내 보 횟수 증가
                    break;
            }

            //  컴의 숫자에 따라 이미지 갱신하고 컴 가위, 바위, 보 횟수 추가
            switch (com_num)
            {
                case 1: //  가위
                    pbCom.ImageLocation = "Images/gawei.jpg";
                    Com_S++;    //  컴 가위 횟수 증가
                    break;
                case 2: //  바위
                    pbCom.ImageLocation = "Images/bawei.jpg";
                    Com_R++;    //  컴 바위 횟수 증가
                    break;
                case 3: //  보
                    pbCom.ImageLocation = "Images/bo.jpg";
                    Com_P++;    //  컴 보 횟수 증가
                    break;
            }
            //  이긴 횟수, 컴 이긴 횟수, 비긴 횟수, 총 게임 횟수 갱신
            lb_Me_Score.Text = Convert.ToString("내가 이긴 횟수 : " + User_count + "번");
            lb_Com_Score.Text = Convert.ToString("컴이 이긴 횟수 : " + Com_count + "번");
            lb_Draw_Score.Text = Convert.ToString("비긴 횟수 : " + Draw_count + "번");
            lb_Total_Count.Text = Convert.ToString("총 게임 횟수 : " + total_count + "번");

            //  컴 가위, 바위, 보 횟수 갱신
            lb_Com_S.Text = Convert.ToString("가위 횟수 : " + Com_S + "번");
            lb_Com_R.Text = Convert.ToString("바위 횟수 : " + Com_R + "번");
            lb_Com_P.Text = Convert.ToString("보 횟수 : " + Com_P + "번");

            //  내 가위, 바위, 보 횟수 갱신
            lb_Me_S.Text = Convert.ToString("가위 횟수 : " + User_S + "번");
            lb_Me_R.Text = Convert.ToString("바위 횟수 : " + User_R + "번");
            lb_Me_P.Text = Convert.ToString("보 횟수 : " + User_P + "번");
            lbResult.Text = result;
        }

        //  가위 클릭시 실행
        private void gawei_Click(object sender, EventArgs e)
        {
            //  랜덤 클래스
            Random rand = new Random();
            int my_num = 1; //  내 숫자 1 (가위)
            int com_num = rand.Next(1, 4);  //  컴 1 ~ 3 랜덤 숫자
            pbMe.ImageLocation = "Images/gawei.jpg";    //  내 이미지 가위로 변환
            
            //  dll 함수 Gawibawibo.Game
            //  내 숫자, 컴 숫자를 인수로 받아 결과로 이김, 비김, 짐 중 하나 return
            string result = Gawibawibo.Game(my_num, com_num);
            //  결과와 내 숫자, 컴 숫자를 이용해
            //  컴 이미지와 결과 창 갱신
            updateResult(result, my_num, com_num);
        }

        //  바위 클릭시 실행
        private void bawei_Click(object sender, EventArgs e)
        {
            //  랜덤 클래스
            Random rand = new Random();
            int my_num = 2; //  내 숫자 2 (바위)
            int com_num = rand.Next(1, 4);  //  컴 1 ~ 3 랜덤 숫자
            pbMe.ImageLocation = "Images/bawei.jpg";    //  내 이미지 바위로 변환

            //  dll 함수 Gawibawibo.Game
            //  내 숫자, 컴 숫자를 인수로 받아 결과로 이김, 비김, 짐 중 하나 return
            string result = Gawibawibo.Game(my_num, com_num);
            //  결과와 내 숫자, 컴 숫자를 이용해
            //  컴 이미지와 결과 창 갱신
            updateResult(result, my_num, com_num);
        }

        //  보 클릭시 실행
        private void bo_Click(object sender, EventArgs e)
        {
            //  랜덤 클래스
            Random rand = new Random();
            int my_num = 3; //  내 숫자 3 (보)
            int com_num = rand.Next(1, 4);  //  컴 1 ~ 3 랜덤 숫자
            pbMe.ImageLocation = "Images/bo.jpg";    //  내 이미지 보로 변환

            //  dll 함수 Gawibawibo.Game
            //  내 숫자, 컴 숫자를 인수로 받아 결과로 이김, 비김, 짐 중 하나 return
            string result = Gawibawibo.Game(my_num, com_num);
            //  결과와 내 숫자, 컴 숫자를 이용해
            //  컴 이미지와 결과 창 갱신
            updateResult(result, my_num, com_num);
        }
    }
}
