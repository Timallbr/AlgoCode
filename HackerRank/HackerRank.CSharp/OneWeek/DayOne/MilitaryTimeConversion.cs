using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CSharp.OneWeek.DayOne
{
    public class MilitaryTimeConversion
    {
        public static string Process(string s)
        {
            var timeAs24HourFormat = "";

            if (TimeOnly.TryParse(s, out var timeAs12HourFormat))
            {
                timeAs24HourFormat = timeAs12HourFormat.ToString("HH:mm:ss");
            }

            return timeAs24HourFormat;
        }
    }
}
