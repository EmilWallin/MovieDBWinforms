using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBSearch
{
    internal static class TimeConvert
    {
        public static string MinutesToTimeString(int min)
        {
            int hr = min / 60;
            int mins = min % 60;

            if (hr == 0 && mins == 0)
                return "Unknown";
            else
                return $"{hr}h {mins}m";
        }
    }
}
