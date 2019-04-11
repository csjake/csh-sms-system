﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Utils
{
    public class DateTimeUnixTimeStampConverter
    {
        public static System.DateTime unixBaseDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        public static DateTime ToDateTime(long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            var result = unixBaseDate.AddSeconds(unixTimeStamp).ToLocalTime();
            return result;
        }

        public static long ToUnixTimeStamp(DateTime date)
        {
            return (long)(date - unixBaseDate).TotalSeconds;
        }
    }

    public class DateTimeTelerivetTimeStringConverter
    {
        private static CultureInfo MyCultureInfo = new CultureInfo("en-US");
        public static DateTime? ToDateTimeNullable(string date)
        {
            if (date == null) return null;          
            return DateTime.ParseExact(date, "yyyy-MM-dd", MyCultureInfo);
        }        
        public static DateTime ToDateTime(string date)
        {           
            return DateTime.ParseExact(date, "yyyy-MM-dd", MyCultureInfo);
        }
    }

    public class DateTimeSurveyCTOStringConverter
    {
        public static DateTime? ConvertToDateTimeNullable(string surveyCtoDate)
        {
            if (surveyCtoDate == "") return null;
            return ConvertToDateTime(surveyCtoDate);
        }

        public static DateTime ConvertToDateTime(string surveyCtoDate)
        {           
            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(surveyCtoDate, "MMM d, yyyy", provider);
        }

        public static DateTime ConvertSurveyCTODateTimeToDateTime(string surveyCtoDateTime)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(surveyCtoDateTime, "MMM d, yyyy h:mm:ss tt", provider);
        }
      
  
        //static string ConvertSurveyCtoDateTimeToTelerivetDate(string surveyCtoDate)
        //{
        //    if (surveyCtoDate == "") return surveyCtoDate;
        //    CultureInfo provider = CultureInfo.InvariantCulture;
        //    return DateTime.ParseExact(surveyCtoDate, "MMM d, yyyy h:mm:ss tt", provider).ToString("yyyy-MM-dd");
        //}

        //static string ConvertSurveyCtoDateToTelerivetDate(string surveyCtoDate)
        //{
        //    if (surveyCtoDate == "") return surveyCtoDate;
        //    CultureInfo provider = CultureInfo.InvariantCulture;
        //    return DateTime.ParseExact(surveyCtoDate, "MMM d, yyyy", provider).ToString("yyyy-MM-dd");
        //}
    }
}
