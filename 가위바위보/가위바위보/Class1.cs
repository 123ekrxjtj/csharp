namespace Gawi
{
    public class Gawibawibo
    {
        public static string Game(int mySelect, int comSelect)
        {
            string res = "";

            if (mySelect == comSelect) res = "비김";
            else if (mySelect == 3 && comSelect == 1) res = "짐";
            else if (mySelect == 1 && comSelect == 3) res = "이김";
            else if (mySelect > comSelect) res = "이김";
            else if (mySelect < comSelect) res = "짐";

            return res;
        }
    }
}
