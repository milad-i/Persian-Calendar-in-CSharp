using System;
using System.Globalization;

namespace Coollacs.PublicClasses
{
    public class PCalendar
    {
        /// <summary>
        /// Return Persian Current Date
        /// </summary>
        public static string PersianDate()
        {
            PersianCalendar PCalendar = new PersianCalendar();
            DateTime CurrentDate = DateTime.Now;
            int Year = PCalendar.GetYear(CurrentDate);
            int Month = PCalendar.GetMonth(CurrentDate);
            int Day = PCalendar.GetDayOfMonth(CurrentDate);

            string NewDate = Year.ToString("0000/") + Month.ToString("00/") + Day.ToString("00");
            return NewDate;
        }
        //-----------------------------------------------------------------------------
        /// <summary>
        /// Return Persian Yesterday Date
        /// </summary>
        public static string PersianYesterday()
        {
            PersianCalendar PCalendar = new PersianCalendar();
            DateTime CurrentDate = DateTime.Now.AddDays(-1);
            int Year = PCalendar.GetYear(CurrentDate);
            int Month = PCalendar.GetMonth(CurrentDate);
            int Day = PCalendar.GetDayOfMonth(CurrentDate);

            string NewDate = Year.ToString("0000/") + Month.ToString("00/") + Day.ToString("00");
            return NewDate;
        }
        //-----------------------------------------------------------------------------
        /// <summary>
        /// Return Persian Current Month of Year
        /// </summary>
        public static int PersianMonthOfYear()
        {
            PersianCalendar PCalendar = new PersianCalendar();
            DateTime CurrentDate = DateTime.Now;
            int Month = PCalendar.GetMonth(CurrentDate);

            return Month;
        }
        //-----------------------------------------------------------------------------
        /// <summary>
        /// Convert Persian Date to Gregorian Date
        /// </summary>
        public static DateTime Persian2Gregorian(string PersianDate)
        {
            int Year, Month, Day, Hour, Min, Sec;
            PersianCalendar PCalendar = new PersianCalendar();
            Year = Convert.ToInt32(PersianDate.Substring(0, 4));
            Month = Convert.ToInt32(PersianDate.Substring(5, 2));
            Day = Convert.ToInt32(PersianDate.Substring(8, 2));

            //If PersianDate String has Time
            if (PersianDate.Length > 10)
            {
                Hour = Convert.ToInt32(PersianDate.Substring(11, 2));
                Min = Convert.ToInt32(PersianDate.Substring(14, 2));
                Sec = Convert.ToInt32(PersianDate.Substring(17, 2));
            }
            else
            {
                Hour = 00;
                Min = 00;
                Sec = 00;
            }
            
            DateTime greDate = new DateTime(Year, Month, Day, Hour, Min, Sec, PCalendar);
            return greDate;
        }

        /// <summary>
        /// Convert Gregorian Date to Persian Date
        /// </summary>
        public static DateTime Gregorian2Persian(DateTime GregorianDate)
        {
            PersianCalendar PCalendar = new PersianCalendar();
            int Year = PCalendar.GetYear(GregorianDate);
            int Month = PCalendar.GetMonth(GregorianDate);
            int Day = PCalendar.GetDayOfMonth(GregorianDate);
            int Hour = PCalendar.GetHour(GregorianDate);
            int Min = PCalendar.GetMinute(GregorianDate);
            int Sec = PCalendar.GetSecond(GregorianDate);

            DateTime prDate = new DateTime( Year, Month, Day, Hour, Min, Sec);
            return prDate;
        }
        //-----------------------------------------------------------------------------
        /// <summary>
        /// Return Current Time Only
        /// </summary>
        public static string Time()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }
}
