using System;

    public class TotalFor
    {
        public static void Main(string[] args)
        {
            int num = 0, count = -1;
            int hol = 0, holSum = 0;
            int jap = -1, japSum = 0;

            do
            {
                count++;
                if (num % 2 == 0)
                {
                    jap++;
                    japSum += num;
                }
                else
                {
                    hol++;
                    holSum += num;
                }


                Console.Write("하나의 정수 입력 : ");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num!=-1);

            Console.WriteLine("입력 데이터 갯수 : {0}",count);
            Console.WriteLine("입력 짝수의 갯수 : {0}",jap);
            Console.WriteLine("입력 짝수의 합은 : {0}", japSum);
            Console.WriteLine("입력 홀수의 갯수 : {0}", hol);
            Console.WriteLine("입력 홀수의 합은 : {0}", holSum);
        }
    }