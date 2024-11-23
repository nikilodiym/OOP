using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class DateOfBirthday
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public DateOfBirthday()
        {
            //lokal time
            DateTime now = DateTime.Now;
            DateTime today = DateTime.UtcNow;
            Day = now.Day;
            Month = now.Month;
            Year = now.Year;
        }

        public DateOfBirthday(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
