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

        private void btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();
        }

        private void Timer_View_Result_Tick(object sender, EventArgs e)
        {
            int size = 20;
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
        private void updateResult(string result, int my_num, int com_num)
        {
            if (result == "이김") User_count++;
            else if (result == "비김") Draw_count++;
            else if (result == "짐") Com_count++;

            lb_Me_Score.Text = Convert.ToString(User_count);
            lb_Com_Score.Text = Convert.ToString(Com_count);
            lbResult.Text = result;
        }

        private void gawei_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int my_num = 1;
            int com_num = rand.Next(1, 4);  //  1 ~ 3 랜덤 숫자
            pbMe.ImageLocation = "Images/gawei.jpg";
            if (com_num == 1) pbCom.ImageLocation = "Images/gawei.jpg";
            else if (com_num == 2) pbCom.ImageLocation = "Images/bawei.jpg";
            else if (com_num == 3) pbCom.ImageLocation = "Images/bo.jpg";

            //  이김, 비김, 짐 셋 중 하나 문자열 반환
            string result = Gawibawibo.Game(my_num, com_num);
            updateResult(result, my_num, com_num);
        }

        private void bawei_Click(object sender, EventArgs e)
        {
            int my_num = 2;
            pbMe.ImageLocation = "Images/bawei.jpg";
        }

        private void bo_Click(object sender, EventArgs e)
        {
            int my_num = 3;
            pbMe.ImageLocation = "Images/bo.jpg";
        }
    }
}
