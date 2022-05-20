using System;
using System.Text.RegularExpressions;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeConversion("07:05:45PM"));
        }

        public static string TimeConversion(string s)
        {
            string tweentyFourFormat = "";

            Regex ex = new Regex(@"(1[012]|[1-9]):[0-5][0-9]:[0-5][0-9](?i)(AM|PM)");
            Match match = ex.Match(s);

            if (match.Success)
            {
                var newHour = Format(s.Substring(0, 2), s.Substring(8));
                var remaining = s.Substring(2, 6);

                tweentyFourFormat = newHour + remaining;
            }

            return tweentyFourFormat;
        }

        private static string Format(string hour, string time)
        {
            string result = "";

            if (time.Equals("AM"))
            {
                if (hour.Equals("12"))
                {
                    result = "00";
                }
                else
                {
                    result = hour;
                }
            }
            else
            {
                if (hour.Equals("12"))
                {
                    result = "12";
                }
                else if (hour.Equals("01"))
                {
                    result = "13";
                }                
                else if (hour.Equals("02"))
                {
                    result = "14";
                }                
                else if (hour.Equals("03"))
                {
                    result = "15";
                }                
                else if (hour.Equals("04"))
                {
                    result = "16";
                }               
                else if (hour.Equals("05"))
                {
                    result = "17";
                }               
                else if (hour.Equals("06"))
                {
                    result = "18";
                }               
                else if (hour.Equals("07"))
                {
                    result = "19";
                }                
                else if (hour.Equals("08"))
                {
                    result = "20";
                }
                else if (hour.Equals("09"))
                {
                    result = "21";
                }
                else if (hour.Equals("10"))
                {
                    result = "22";
                }
                else if (hour.Equals("11"))
                {
                    result = "23";
                }
            }

            return result;
        }
    }
}
