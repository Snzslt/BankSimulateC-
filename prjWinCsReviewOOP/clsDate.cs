using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsReviewOOP
{
    public class clsDate
    {
        private int vDay;//0
        private int vMonth;//0
        private int vYear;//0

        public clsDate()
        {
            vDay = 1;
            vMonth = 1;
            vYear = 1;
        }
        public clsDate(int aDay, int aMonth, int aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }

        public clsDate(int aDay, int aMonth)
        {
            Day = aDay;
            Month = aMonth;
            Year = DateTime .Today .Year ;
        }
        public int Day 
        {
            get { return vDay; }
            set { vDay = (value>=1 && value <= 31)? value: DateTime.Today.Day ; }
        }
        public int Month
        {
            get { return vMonth; }
            set { vMonth = (value >= 1 && value <= 12) ? value : DateTime.Today.Month; }
        }
        public int Year
        {
            get { return vYear; }
            set { vYear = (value >= 1 ) ? value : DateTime.Today.Year; }
        }

        public void Initialize(int aDay, int aMonth, int aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }

        public string ToNumber()
        {
            return Day + "/" + Month + "/" + Year;
        }

        // Friday 23 of December 2003
        public string ToLetter()
        {
            string info = "";

            DateTime mydate = new DateTime(Year, Month, Day);
            int indxDayWeek = Convert.ToInt32(mydate.DayOfWeek);
            // Search for the name of the day of the week 
            switch (indxDayWeek)
            {
                case 0:
                    info = "Sunday "; break;
                case 1:
                    info = "Monday "; break;
                case 2:
                    info = "Tuesday "; break;
                case 3:
                    info = "Wednesday "; break;
                case 4:
                    info = "Thursday "; break;
                case 5:
                    info = "Friday "; break;
                case 6:
                    info = "Saturday "; break;
            }

            info += Day + " of ";

            // Search for the name of the month of the year 
            switch (Month)
            {
                case 1:
                    info += "January "; break;
                case 2:
                    info += "February "; break;
                case 3:
                    info += "March "; break;
                case 4:
                    info += "April "; break;
                case 5:
                    info += "May "; break;
                case 6:
                    info += "June "; break;
                case 7:
                    info += "July "; break;
                case 8:
                    info += "August "; break;
                case 9:
                    info += "September "; break;
                case 10:
                    info += "October "; break;
                case 11:
                    info += "November "; break;
                case 12:
                    info += "December "; break;
            }

            info += Year;




            return info;
        }

    }
}
