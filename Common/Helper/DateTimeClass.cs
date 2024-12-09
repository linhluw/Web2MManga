using System;

namespace Web2mmanga.Common.Helper
{
    public class DateTimeClass
    {
        /// <summary>
        /// Convert string Date
        /// </summary>
        /// <param name="Date">string Date to convert</param>
        /// <returns>Default datetime format dd/MM/yyyy</returns>
        public static string ConvertDate(string Date)
        {
            return ConvertDate(Date, "dd/MM/yyyy");
        }
        /// <summary>
        /// Convert string Date
        /// </summary>
        /// <param name="Date">string Date to convert</param>
        /// <param name="DateFormat">string format date</param>
        /// <returns>string Date format as DateFormat</returns>
        public static string ConvertDate(string Date, string DateFormat)
        {
            DateTime dt = Convert.ToDateTime(Date);
            return dt.ToString(DateFormat);
        }

        /// <summary>
        /// Convert Date
        /// </summary>
        /// <param name="Date">Date to convert</param>
        /// <returns>Default datetime format dd/MM/yyyy</returns>
        public static string ConvertDate(DateTime Date)
        {
            return ConvertDate(Date, "dd/MM/yyyy");
        }
        /// <summary>
        /// Convert Date
        /// </summary>
        /// <param name="Date">Date</param>
        /// <param name="DateFormat">string format date</param>
        /// <returns>string Date format as DateFormat</returns>
        public static string ConvertDate(DateTime Date, string DateFormat)
        {
            return Date.ToString(DateFormat);
        }

        public static DateTime Convert2Date(string Date)
        {
            DateTime dt = Convert.ToDateTime(Date);
            return dt;
        }

        /// <summary>
        /// Convert string Datetime
        /// </summary>
        /// <param name="DateTime">string Datetime to convert</param>
        /// <returns>Default dd/MM/yyyy HH:mm:ss</returns>
        public static string ConvertDateTime(string DateTimes)
        {
            try
            {
                if (DateTimes.Length == 0)
                {
                    DateTimes = DateTime.Now.ToString();
                }
                //else
                //{
                //    DateTimes = DateTimes;
                //}
                return ConvertDateTime(DateTimes, "dd/MM/yyyy hh:mm:ss tt");
            }
            catch
            {
                return DateTimes;
            }
        }
        public static string ConvertDateTime_hhmm(string DateTime)
        {
            try
            {
                return ConvertDateTime(DateTime, "HH:mm");
            }
            catch
            {
                return DateTime;
            }
        }
        public static string ConvertDateTime_ddmmyyyy(string DateTime)
        {
            try
            {
                return ConvertDateTime(DateTime, "dd/MM/yyyy");
            }
            catch
            {
                return DateTime;
            }
        }
        public static string ConvertDateTime_ddMMyyyyHHmm(string DateTime)
        {
            try
            {
                return ConvertDateTime(DateTime, "dd/MM/yyyy HH:mm");
            }
            catch
            {
                return DateTime;
            }
        }
        /// <summary>
        /// Convert string Datetime
        /// </summary>
        /// <param name="DateTime">string Datetime to convert</param>
        /// <param name="DateFormat">string format date</param>
        /// <returns>string Datetime format as DateFormat</returns>
        public static string ConvertDateTime(string DateTime, string DateFormat)
        {
            DateTime dt = new DateTime();
            try
            {
                dt = Convert.ToDateTime(DateTime);
            }
            catch { }
            return dt.ToString(DateFormat);
        }

        /// <summary>
        /// Convert Datetime
        /// </summary>
        /// <param name="DateTime">Datetime to convert</param>
        /// <returns>Default dd/MM/yyyy HH:mm:ss</returns>
        public static string ConvertDateTime(DateTime DateTime)
        {
            return ConvertDateTime(DateTime, "dd/MM/yyyy HH:mm:ss tt");
        }
        /// <summary>
        /// Convert Datetime
        /// </summary>
        /// <param name="DateTime">Datetime to convert</param>
        /// <param name="DateFormat">string format date</param>
        /// <returns>string Datetime format as DateFormat</returns>
        public static string ConvertDateTime(DateTime DateTime, string DateFormat)
        {
            return DateTime.ToString(DateFormat);
        }

        /// <summary>
        ///  Convert string Time
        /// </summary>
        /// <param name="Time">string Time to convert</param>
        /// <returns>Default HH:mm:ss</returns>
        public static string ConvertTime(string Time)
        {
            return ConvertTime(Time, "HH:mm:ss");
        }

        /// <summary>
        ///  Convert string Time
        /// </summary>
        /// <param name="Time">string Time to convert</param>
        /// <param name="TimeFormat">string format time</param>
        /// <returns>string Time format as TimeFormat</returns>
        public static string ConvertTime(string Time, string TimeFormat)
        {
            DateTime dt = Convert.ToDateTime(Time);
            return dt.ToString(TimeFormat);
        }

        /// <summary>
        ///  Convert Time
        /// </summary>
        /// <param name="Time">Time to convert</param>
        /// <returns>Default HH:mm:ss</returns>
        public static string ConvertTime(DateTime Time)
        {
            return ConvertTime(Time, "HH:mm:ss");
        }

        /// <summary>
        ///  Convert Time
        /// </summary>
        /// <param name="Time">Time to convert</param>
        /// <param name="TimeFormat">string format time</param>
        /// <returns>string Time format as TimeFormat</returns>
        public static string ConvertTime(DateTime Time, string TimeFormat)
        {
            return Time.ToString(TimeFormat);
        }

        public static string DayOfWeek(string Date)
        {
            DateTime dt = new DateTime();
            try
            {
                dt = Convert.ToDateTime(Date);
            }
            catch { }
            return DayOfWeek(dt);
        }

        public static string DayOfWeek(DateTime Date)
        {
            string strReturn = "";
            switch (Date.DayOfWeek.ToString())
            {
                case "Sunday":
                    strReturn = "Chủ nhật";
                    break;
                case "Monday":
                    strReturn = "Thứ 2";
                    break;
                case "Tuesday":
                    strReturn = "Thứ 3";
                    break;
                case "Wednesday":
                    strReturn = "Thứ 4";
                    break;
                case "Thursday":
                    strReturn = "Thứ 5";
                    break;
                case "Friday":
                    strReturn = "Thứ 6";
                    break;
                case "Saturday":
                    strReturn = "Thứ 7";
                    break;
            }
            return strReturn;
        }
        public static string DayOfWeekTuanvd(DateTime Date, string lang)
        {
            string strReturn = "";
            if (lang == "vi")
            {
                switch (Date.DayOfWeek.ToString())
                {
                    case "Sunday":
                        strReturn = "Chủ nhật";
                        break;
                    case "Monday":
                        strReturn = "Thứ 2";
                        break;
                    case "Tuesday":
                        strReturn = "Thứ 3";
                        break;
                    case "Wednesday":
                        strReturn = "Thứ 4";
                        break;
                    case "Thursday":
                        strReturn = "Thứ 5";
                        break;
                    case "Friday":
                        strReturn = "Thứ 6";
                        break;
                    case "Saturday":
                        strReturn = "Thứ 7";
                        break;
                }
            }
            else
            {
                switch (Date.DayOfWeek.ToString())
                {
                    case "Sunday":
                        strReturn = "Sunday";
                        break;
                    case "Monday":
                        strReturn = "Monday";
                        break;
                    case "Tuesday":
                        strReturn = "Tuesday";
                        break;
                    case "Wednesday":
                        strReturn = "Wednesday";
                        break;
                    case "Thursday":
                        strReturn = "Thursday";
                        break;
                    case "Friday":
                        strReturn = "Friday";
                        break;
                    case "Saturday":
                        strReturn = "Saturday";
                        break;
                }
            }
            return strReturn;
        }

        //Ham lay ra so tuan cua nam
        public static int GetWeekNumber(DateTime date)
        {
            //Constants
            const int JAN = 1;
            const int DEC = 12;
            const int LASTDAYOFDEC = 31;
            const int FIRSTDAYOFJAN = 1;
            const int THURSDAY = 4;
            bool thursdayFlag = false;
            int dayOfYear = date.DayOfYear;
            int startWeekDayOfYear = (int)(new DateTime(date.Year, JAN, FIRSTDAYOFJAN)).DayOfWeek;
            int endWeekDayOfYear = (int)(new DateTime(date.Year, DEC, LASTDAYOFDEC)).DayOfWeek;
            if (startWeekDayOfYear == 0)
                startWeekDayOfYear = 7;
            if (endWeekDayOfYear == 0)
                endWeekDayOfYear = 7;
            int daysInFirstWeek = 8 - (startWeekDayOfYear);

            if (startWeekDayOfYear == THURSDAY || endWeekDayOfYear == THURSDAY)
                thursdayFlag = true;
            int fullWeeks = (int)Math.Ceiling((dayOfYear - (daysInFirstWeek)) / 7.0);
            int resultWeekNumber = fullWeeks;
            if (daysInFirstWeek >= THURSDAY)
                resultWeekNumber = resultWeekNumber + 1;
            if (resultWeekNumber > 52 && !thursdayFlag)
                resultWeekNumber = 1;
            if (resultWeekNumber == 0)
                resultWeekNumber = GetWeekNumber(new DateTime(date.Year - 1, DEC, LASTDAYOFDEC));
            return resultWeekNumber;
        }
        //lấy ngày đầu tuần và cuối tuần từ số tuần

        //Các phép toán cộng trừ số ngày ở sau đây đều dùng hàm AddDays của đối tượng dạng DateTime.

        //- Parse ngày đầu năm ("2012/01/01") thành DateTime.
        //- cộng 7 * số tuần
        //- xét thuộc tính DayOfWeek, so sánh với DayOfWeek.Monday, nếu không bằng thì trừ 1 ngày, dần cho đến bằng thì thôi, đó là ngày đầu tuần (nếu quy định đầu tuần là thứ hai).
        //- cộng 6 thì sẽ ra ngày cuối tuần
        //public static int LayNgayTuTuan(DateTime date)
        //{
        //    int nam = 2012;
        //    DateTime d1;
        //    DateTime.TryParse(nam.ToString() + "/01/01", out d1);
        //    d1 = d1.AddDays(7 * 10); // tuần thứ 10
        //    while (d1.DayOfWeek != DayOfWeek.Monday) d1 = d1.AddDays(-1); // tìm đầu tuần
        //    DateTime d2 = d1.AddDays(6); // cuối tuần
        //}

    }
}