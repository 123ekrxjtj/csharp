namespace JuminDLL
{
    public class Calculator
    {
        public static int NAI(string a) {
            string curDate = Convert.ToString(DateTime.Now);
            Console.WriteLine(curDate);
            int curYear = Convert.ToInt32(curDate.Substring(0, 4));
            int curMonth = Convert.ToInt32(curDate.Substring(5, 2));
            int curDays = Convert.ToInt32(curDate.Substring(8, 2));
            int month = MONTH(a);
            int days = DAY(a);
            int myYear = YEAR(a);

            int retAge = curYear - myYear;
            if (curMonth < month)
            {
                retAge -= 1;
            }
            else if (curMonth == month || curDays < days)
            {
                retAge -= 1;
            }
            return retAge;
        }

        public static string TYPE(string a) {
            string retGubun;

            int jencode = Convert.ToInt32(a.Substring(6, 1));
            
            if (jencode % 2 == 1) retGubun = "남성";
            else retGubun = "여성";

            return retGubun;
        }

        public static int YEAR(string a) {
            int retYear;
            int year = Convert.ToInt32(a.Substring(0, 2));
            int jencode = Convert.ToInt32(a.Substring(6, 1));

            if (jencode < 3) retYear = 1900 + year;
            else retYear = retYear = 2000 + year;

            return retYear;
        }

        public static int MONTH(string a) {
            int retMonth = Convert.ToInt32(a.Substring(5, 2));
            return retMonth;
        }

        public static int DAY(string a) {
            int retDay = Convert.ToInt32(a.Substring(4, 2));
            return retDay;
        }
    }
}
