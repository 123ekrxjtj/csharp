using System;



class Control
{
    public static string Game(int mySel,int comSel)
    {
        string res="";

        if (mySel == comSel) res= "비김";
        else if (mySel == 3)
        {
            if (comSel == 1) res= "짐";
            else res= "이김";
        }
        else if (mySel > comSel) res= "이김";
        else if (mySel < comSel) res= "짐";

        return res;
    }

    public static void Main(string[] args)
    {
        Random rand = new Random();

        int count = 0;
        int win = 0;
        int lose = 0;
        int draw = 0;

        int mySel = 0;
        int comSel = 0;

        int comGawi = 0;
        int comBo = 0;
        int comBawi = 0;
        string comRes = "";

        while (true)
        {
            Console.Write("1, 2, 3 중 하나 입력 >> ");
            mySel = Convert.ToInt32(Console.ReadLine());

            if (mySel == -1) break;
            else if(mySel>3 || mySel < 1)
            {
                Console.WriteLine("다시 입력");
                continue;
            }

            comSel = Convert.ToInt32(rand.Next(1,4));
            
            
            string res = Game(mySel,comSel);
            Console.WriteLine(res);


            switch (res)
            {
                case "이김":
                    win += 1;
                    break;
                case "비김":
                    draw += 1;
                    break;
                case "짐":
                    lose += 1;
                    break;  
            }



            switch (comSel)
            {
                case 1:
                    comGawi += 1;
                    comRes = "가위";
                    break;
                case 2:
                    comBawi += 1;
                    comRes = "바위";
                    break;
                case 3:
                    comBo += 1;
                    comRes = "보";
                    break;
            }

            count++;
            Console.WriteLine("컴의 선택은 {0}",comRes);
            Console.WriteLine("---------------------------");
        }

        Console.WriteLine("총 게임 횟수 : {0}",count);
        Console.WriteLine("컴 가위 : {0} 컴 바위 : {1} 컴 보 : {2}", comGawi, comBawi, comBo);
        Console.WriteLine("서로 비김 : {0} 이김 : {1} 패배 : {2}",draw,win,lose);
    }
}