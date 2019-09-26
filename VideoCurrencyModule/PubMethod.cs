using System;
using System.Collections.Generic;
using System.Text;

namespace VideoCurrencyModule
{
    public class PubMethod
    {
        /// <summary>
        /// 时间戳转DateTime (毫秒)
        /// </summary>
        /// <param name="lTime"></param>
        /// <returns></returns>
        public static DateTime UnixMillisecondsTimestampToDateTime(long lTime)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            lTime = long.Parse(lTime + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        /// <summary>
        /// DateTime 转时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long DateTimeToUnixTimestamp(DateTime dateTime)
        {
            var start = new DateTime(1970, 1, 1, 8, 0, 0, dateTime.Kind);
            return Convert.ToInt64((dateTime - start).TotalMilliseconds);
        }
    }
}
