using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairs.Module {
    class calculateAge {

        public static (int Year, int Month, int Day) calAge(DateTime birthday) {
            DateTime today = DateTime.Now;
             int y = birthday.Year;
             int m = birthday.Month;
             int d = birthday.Day;

            int leap_year = 0;
            for (int i = y; i < today.Year; i++) {
                if (DateTime.IsLeapYear(i)) {
                    ++leap_year;
                }
            }

            TimeSpan timespan = today.Subtract(birthday);
            d = timespan.Days - leap_year;
            int r = 0;
            y = Math.DivRem(d, 365, out r);
            m = Math.DivRem(r, 30, out r);
            d = r;
            return (y, m, d);
        }

    }
}
