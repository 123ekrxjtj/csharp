using System;

public class LottoNumCreator
{
    public static void sort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                int tmp;
                if (a[i] < a[j])
                {
                    tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] nums = new int[6];
        Console.WriteLine("로또 번호 생성기");
        int tmpN;
            
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                tmpN = 0;
                int k = 0;

                while (k < 6)
                {
                    if (tmpN != nums[k]) k++;
                    else
                    {
                        tmpN = random.Next();
                        tmpN = 1 + tmpN % 45;
                        k = 0;
                    }
                }
                nums[j] = tmpN;
            }

            sort(nums);

            for (int m = 0; m < 6; m++)
            {
                Console.Write("{0}\t", nums[m]);
                nums[m] = 0;
            }
            Console.WriteLine();
        }
    }        
}