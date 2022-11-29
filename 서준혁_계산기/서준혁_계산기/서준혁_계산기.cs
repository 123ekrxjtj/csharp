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
        //  계산기 연산 시 쓸 스택과 리스트
        //  buff_List는 = 누를 때 까지 누른 숫자, 연산자를 후위식으로 저장할 리스트
        //  2 + 3 = 누르면 ["2", "3", "+"] 와 같이 후위식으로 저장되게 함
        List<String> buff_List;

        //  숫자 넣을 스택,후위식 계산시 사용함
        Stack<double> calc_Num_Stack;
        //  연산자 넣을 스택, 중위식 -> 후위식 변환과 후위식 계산시 사용함
        Stack<String> calc_Oper_Stack;   
        
        // 계산기에서 쓸 전역 변수
        string buff = "";         // 연산자나 = 누르기 전까지 입력된 숫자 저장할 변수
        string output = "";      // textbox에 출력되는 문자열 저장

        public 서준혁_계산기()
        {
            InitializeComponent();

            //  스택, 리스트 할당
            buff_List = new List<String>();
            calc_Num_Stack = new Stack<double>();
            calc_Oper_Stack = new Stack<String>();
        }

        //  연산자나 숫자를 인수로 받아 우선순위를 반환함
        //  0   숫자를 입력한 경우
        //  1   + - 
        //  2   * / %
        //  3   ^
        //  4   √ ! ( 단항 연산자 )
        //  숫자가 높으면 우선순위 높음
        private int check_Priority(String oper)
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
                case "√'":
                case "!":
                    priority = 4;
                    break;
            }
            return priority;
        }

        //  팩토리얼 계산 함수
        private int factorial(int n)
        {
            //  n부터 1까지 곱해서 반환
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        #region : 숫자 버튼 클릭시 동작
        private void Bt_num_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            buff += btn.Text;   //  버튼의 숫자를 buff에 추가
            output += btn.Text; //  textbox에 출력할 변수에 버튼 숫자 추가
            tx_Result.Text = output;    //  textbox에 누른 output 갱신
        }
        #endregion

        #region : 클리어 클릭시 동작
        private void Bt_clear_Click(object sender, MouseEventArgs e)
        {
            //  textbox와 현재까지 입력된 숫자 모두 초기화
            tx_Result.Text = "";    
            buff = "";
            output = "";

            //  스택, 리스트 초기화
            buff_List.Clear();
            calc_Num_Stack.Clear();
            calc_Oper_Stack.Clear();
        }
        #endregion

        #region : 연산자 ( + - * / % 등 ) 클릭 시 동작
        private void Bt_oper_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            String btnOper = btn.Text;  //  클릭한 연산자 문자

            //  연산자 누르기 전까지 입력한 숫자 후위식 리스트에 추가
            buff_List.Add(buff);

            //  연산자 스택이 비어있으면 바로 클릭한 연산자 추가
            if (calc_Oper_Stack.Count == 0)
            {
                calc_Oper_Stack.Push(btnOper);
            }
            //  연산자 스택이 비어있지 않으면
            else
            {
                //  클릭한 연산자의 우선순위
                int cur_pri = check_Priority(btnOper);
                //  연산자 스택 Peek한 것의 우선순위
                int stack_pri = check_Priority(calc_Oper_Stack.Peek());   

                //  클릭한 연산자의 우선순위 <= 연산자 스택 Peek한 것의 우선순위일 때
                if (cur_pri <= stack_pri)
                {
                    //  연산자 스택에서 Pop 한 연산자를 후위식 리스트에 추가
                    buff_List.Add(calc_Oper_Stack.Pop());
                }
                calc_Oper_Stack.Push(btnOper);  //  클릭한 연산자를 연산자 스택에 추가
            }

            buff = "";  //  임시 숫자 초기화
            output += btn.Text; //  textbox에 출력할 변수에 버튼 숫자 추가
            tx_Result.Text = output;    //  textbox에 누른 output 갱신
        }
        #endregion

        #region : = 클릭 시 동작
        private void Bt_calc_Click(object sender, MouseEventArgs e)
        {
            //  buff에 숫자가 있다면
            if (buff!="")
            {
                //  후위식 리스트에 숫자 추가
                buff_List.Add(buff);
            }

            //  연산자 스택에 아직 연산자가 남아있는 동안
            //  팝해서 후위식 리스트에 추가
            while (calc_Oper_Stack.Count > 0)
            {
                String popOper = calc_Oper_Stack.Pop();
                buff_List.Add(popOper);
            }

            //  후위식 리스트의 요소 개수만큼 루프
            for (int i = 0; i < buff_List.Count; i++)
            {
                //  가져온 요소의 연산자 우선순위
                int tmpPriority = check_Priority(buff_List[i]);

                //  가져온 요소가 숫자면
                if (tmpPriority==0)
                {
                    //  double 로 변환 후 숫자 스택에 push
                    double tmpNum = Convert.ToDouble(buff_List[i]);
                    calc_Num_Stack.Push(tmpNum);
                }
                //  가져온 요소가 연산자면
                else
                {
                    //  숫자 스택에서 pop해서 임시 저장
                    double num2 = calc_Num_Stack.Pop();
                    

                    //  가져온 요소가 단항 연산자면
                    if (tmpPriority == 4)
                    {
                        switch (buff_List[i])
                        {
                            case "√'":   //  루트 후 숫자 스택에 푸시
                                calc_Num_Stack.Push(Math.Sqrt(num2));
                                break;
                            case "!":   //  팩토리얼 후 숫자 스택에 푸시
                                calc_Num_Stack.Push(factorial(Convert.ToInt32(num2)));
                                break;
                        }
                        continue;   //  아래 코드 건너뜀
                    }

                    //  이 아래는 모두 이항 연산자이므로
                    //  숫자 하나 더 pop해서 저장
                    double num1 = calc_Num_Stack.Pop();

                    //  가져온 요소가 ^ (제곱 연산)이면
                    if (tmpPriority == 3)
                    {
                        //  제곱 연산 후 숫자 스택에 push
                        double tmpNum = Math.Pow(num1, num2);
                        calc_Num_Stack.Push(tmpNum);
                    }
                    //  가져온 요소가  * / % + - 면
                    else
                    {
                        double tmpNum;  //  임시 변수
                        switch (buff_List[i])
                        {
                            case "*":   //  곱셈
                                tmpNum = num1 * num2;
                                break;
                            case "/":   //  나눗셈
                                //  0 나눔 예외처리
                                if (num2 == 0)
                                {
                                    tx_Result.Text = "0으로 나눌수 없음";
                                    return;
                                }
                                tmpNum = num1 / num2;
                                break;
                            case "%":   //  나머지 연산
                                tmpNum = num1 % num2;
                                break;
                            case "+":   //  더하기
                                tmpNum = num1 + num2;
                                break;
                            default:   //  뺄셈 (default로 해둠)
                                tmpNum = num1 - num2;
                                break;
                        }
                        //  연산 결과 숫자 스택에 push
                        calc_Num_Stack.Push(tmpNum);
                    }
                }
            }

            //  숫자 스택에 마지막으로 남아 있는 것이 최종 결과값
            double res = calc_Num_Stack.Pop();

            output += "=" + res.ToString();   //  textbox에 쓸 output에 =와 결과값 추가

            tx_Result.Text = output;

            buff = res.ToString();  //  임시 변수에 최종 값 저장

            //  후위식 리스트 초기화
            buff_List.Clear();
        }
        #endregion
    }
}