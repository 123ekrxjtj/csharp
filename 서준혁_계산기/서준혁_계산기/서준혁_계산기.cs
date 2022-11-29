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
        //  = 누를 때 까지 누른 숫자, 연산자 모두 저장할 리스트
        //  2 + 3 = 누르면 buff_List에 ["2", "3", "+"] 중위식으로 저장되게 함
        List<String> buff_List;

        Stack<double> calc_Num_Stack;   //  숫자 넣을 스택,후위식 계산시 사용함
        Stack<String> calc_Oper_Stack;   //  연산자 넣을 스택, 중위식 -> 후위식 변환과 후위식 계산시 사용함
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

            buff_List = new List<String>();
            calc_Num_Stack = new Stack<double>();
            calc_Oper_Stack = new Stack<String>();
        }

        //  연산자를 인수로 받아 우선순위를 반환함
        //  0   숫자를 입력한 경우
        //  1   + - 
        //  2   * / %
        //  3   ^
        //  4   √ ! ( 단항 연산자 )
        //  숫자가 높으면 우선순위 높음
        private int pri_Oper(String oper)
        {
            //  기본값 0, 0이면 숫자를 입력받은 것임
            int priority = 0;
            switch (oper)
            {
                //  + - 우선순위 1
                case "+":
                case "-":
                    priority = 1;
                    break;
                //  * / % 우선순위 2
                case "*":
                case "/":
                case "%":
                    priority = 2;
                    break;
                //  ^ 우선순위 3
                case "^":
                    priority = 3;
                    break;
                //  √ ! 우선순위 4
                case "√":
                case "!":
                    priority = 4;
                    break;
            }
            return priority;
        }

        private int factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact*=i;
            }
            return fact;
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

            String btnOper = btn.Text;  //  클릭한 연산자 문자

            //  연산자 누르기 전까지 입력한 숫자 후위식 리스트에 추가
            buff_List.Add(buff);

            if (calc_Oper_Stack.Count == 0)
            {
                calc_Oper_Stack.Push(btnOper);
            }
            else
            {
                int cur_pri = pri_Oper(btnOper);   //  클릭한 연산자의 우선순위
                int stack_pri = pri_Oper(calc_Oper_Stack.Peek());   //  연산자 스택 Peek한 것의 우선순위

                //  클릭한 연산자의 우선순위가 연산자 스택 Peek한 것의 우선순위보다 작거나 같으면
                if (cur_pri <= stack_pri)
                {
                    //  연산자 스택에서 Pop 한 것 후위식 리스트에 저장
                    buff_List.Add(calc_Oper_Stack.Pop());
                }
                calc_Oper_Stack.Push(btnOper);  //  클릭한 연산자를 연산자 스택에 추가
            }

            buff = "";                     // 0
            output += btn.Text;            // 3 + 
            tx_Result.Text = output;        // 3 + 
            // buff=3, num1=3, buff=0, output=3+, textbox1=3+, oper = +
            //다음에 8을 입력하면 다시[1] 앞 페이지 로 감
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

            //  buff에 숫자가 있다면
            if (buff!="")
            {
                //  후위식 리스트에 숫자 추가
                buff_List.Add(buff);
            }

            //  후위식에 있는 숫자, 연산자 요소 개수만큼 루프
            for (int i = 0; i < buff_List.Count; i++)
            {
                //  가져온 요소의 연산자 우선순위
                int tmpPriority = pri_Oper(buff_List[i]);

                //  가져온 요소가 숫자면 (우선순위 0이면)
                if (tmpPriority==0)
                {
                    //  double 로 변환 후 숫자 스택에 push
                    double tmpNum = Convert.ToDouble(buff_List[i]);
                    calc_Num_Stack.Push(tmpNum);
                }
                //  가져온 요소가 연산자면
                else
                {
                    //  숫자 스택에서 pop한 것 저장
                    double num2 = calc_Num_Stack.Pop();

                    //  가져온 요소가 단항 연산자면
                    if (tmpPriority == 4)
                    {
                        switch (buff_List[i])
                        {
                            case "√":   //  루트 후 숫자 스택에 푸시
                                calc_Num_Stack.Push(Math.Sqrt(num2));
                                break;
                            case "!":   //  팩토리얼 후 숫자 스택에 푸시
                                calc_Num_Stack.Push(factorial(Convert.ToInt32(num2)));
                                break;
                        }
                        continue;
                    }
                    //  가져온 요소가 ^면
                    else if (tmpPriority == 3)
                    {
                        //  이항 연산자이므로 숫자 하나 더 pop
                        //  숫자 스택에서 pop한 것 저장
                        double num1 = calc_Num_Stack.Pop();

                        //  제곱 연산 후 숫자 스택에 push
                        double tmpNum = Math.Pow(num1, num2);
                        calc_Num_Stack.Push(tmpNum);
                    }
                    //  가져온 요소가  * / % + - 면
                    else
                    {
                        //  이항 연산자이므로 숫자 하나 더 pop
                        //  숫자 스택에서 pop한 것 저장
                        double num1 = calc_Num_Stack.Pop();

                        double tmpNum;  //  임시 변수
                        switch (buff_List[i])
                        {
                            case "*":   //  곱셈 후 숫자 스택에 푸시
                                tmpNum = num1 * num2;
                                break;
                            case "/":   //  나눈 후 숫자 스택에 푸시
                                if (num2 == 0)
                                {
                                    tx_Result.Text = "0으로 나눌수 없음";
                                    return;
                                }
                                tmpNum = num1 / num2;
                                break;
                            case "%":   //  나머지 연산 후 숫자 스택에 푸시
                                tmpNum = num1 % num2;
                                break;
                            case "+":   //  더하기 후 숫자 스택에 푸시
                                tmpNum = num1 + num2;
                                break;
                            default:   //  뺄셈 후 숫자 스택에 푸시
                                tmpNum = num1 - num2;
                                break;
                        }
                        calc_Num_Stack.Push(tmpNum);
                    }
                }
            }

            //  최종 값
            double res = calc_Num_Stack.Pop();

            output += "=" + res.ToString();   //  =  결과값 

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