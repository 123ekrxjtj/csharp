using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;  // 자료구조 관련 클래스 추가


namespace 서준혁_계산기
{
    public partial class 서준혁_계산기 : Form
    {
        //  계산기 연산 시 쓸 스택들
        Stack num_Stack;    //  숫자 집어넣을 스택
        Stack oper_Stack;   //  연산자 집어넣을 스택

        // 계산기에서 사용할  전역 변수 선언
        double num1, num2; // 두 수 저장할 변수  
        string buff = "";         // 임시 보관 할 변수
        string output = "";      // 임시 출력 할 변수
        char oper;               // 연산자 저장할 변수 + , - , * , /
        double result;          // 결과 값 저장할 변수 
        int checkNum = 0;   //  연속 계산 위한 체크 변수
        int isDanhang = 0;  //  단항인지 이항 연산인지 체크 변수

        public 서준혁_계산기()
        {
            InitializeComponent();

            num_Stack = new Stack();
            oper_Stack = new Stack();
        }


        private void 서준혁_계산기_Load(object sender, EventArgs e)
        {
            tx_Result.Text = output;
        }

        #region : 숫자 버튼 클릭시 동작
        private void Bt_num_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            // 숫자 키 중 어느 것이 눌러졌는지를 저장
            buff += btn.Text;           // 3    // 8
            output += btn.Text;       // 3    // 3 + 8
            tx_Result.Text = output;  // 3    // 3 + 8
                                     //  buff=3, output=3, textbox1=3
                                     //  뒤에서 buff=0, output=3+, textbox1=3+  로 되어 있는 상태에서 8 입력하면
                                     //  buff=8, output=3+8, textbox1=3+8 이고 = 입력하면 [3] 으로 감

        }
        #endregion

        #region : 클리어 클릭시 동작
        private void Bt_clear_Click(object sender, MouseEventArgs e)
        {
            checkNum = 0;
            tx_Result.Text = "";
            num1 = 0;
            num2 = 0;
            buff = "";
            output = "";
            result = 0.0;
            oper = ' '; 
        }
        #endregion

        #region : + - * / % 클릭 시 동작
        private void Bt_oper_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;



            //  처음 계산 시
            if (checkNum == 0)
            {
                num1 = Convert.ToSingle(buff); // 3
            }
            
            buff = "";                     // 0
            output += btn.Text;            // 3 + 
            tx_Result.Text = output;        // 3 + 
            oper = btn.Text[0];            // +  
            // buff=3, num1=3, buff=0, output=3+, textbox1=3+, oper = +
            //다음에 8을 입력하면 다시[1] 앞 페이지 로 감
        }
        #endregion

        #region : 종료 버튼 클릭 시 동작
        private void Bt_Exit_Click(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region : = 클릭 시 동작
        private void Bt_calc_Click(object sender, MouseEventArgs e)
        {
            // num1=3, oper = +, buff=8,
            // output += btn.Text;      // 3    // 3 + 8
            // textBox1.Text = output;  // 3    // 3 + 8
            // 인 상태에서 = 이 입렫되면 btn에는 = 가 저장됨
            //  Button btn = (Button)sender;      // btn에는 = 가 저장됨
            num2 = Convert.ToInt32(buff);    // num2 =  8  buff(8)

            switch (oper)  // +
            {
                case '+': result = num1 + num2; break;  // result=11
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 == 0)
                    {
                        tx_Result.Text = "0으로 나눌수 없음";
                        return;
                    }
                    result = num1 / num2; break;
            }
            num1 = Convert.ToDouble(result);
            checkNum = 1;
            //  btn에는 = 가 저장됨
            output += "=" + result.ToString();   //  =  결과값 
                
            tx_Result.Text = output;
            // num2=8이고 result=3+8 btn(=)11,  
            // output=3+8 btn(=)11,Textbox1=3+8=11
        }
        #endregion
    }
}

//  TODO
/*
연산자 중복 클릭 시 오류
단 항 계산과 이 항 계산 구분 (단항인지 이항인지 체크 변수 필요)
연속 계산시 현재 결과 값 어딘가에 임시 보 관 후 다시 num1로 대입 ( 5 )
MSDN 에서  Math 클래스의 메소드 종류 확인할 것

*/