namespace DLL_Create
{
    public class MyMath
    {
        public int Sum(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                s += i;
            return s;
        }

        public int Sum(int a, int b)
        {
            int s = 0;
            for (int i = a; i <= b; i++)
                s += i;
            return s;
        }
    }
}
