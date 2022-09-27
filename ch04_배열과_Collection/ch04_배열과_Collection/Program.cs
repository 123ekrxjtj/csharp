using System;

public class MyClass2
{
    public static void Main(string[] args)
    {
        int [,] Arr = new int[2, 4] { { 10,20,30,0 }, { 40,50,60 ,0} };

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Arr[i,3] += Arr[i,j];
                Console.Write("{0}\t", Arr[i, j]);    
            }
            Console.WriteLine("{0}\t", Arr[i, 3]);
        }
    }
}