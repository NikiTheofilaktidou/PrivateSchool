using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    public class Date    
    {
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public static List<DateTime> datesStartingMonday(DateTime date)
        {
            List<DateTime> assignmentDates = new List<DateTime>();
            assignmentDates.Add(date);
            assignmentDates.Add(date.AddDays(1));
            assignmentDates.Add(date.AddDays(2));
            assignmentDates.Add(date.AddDays(3));
            assignmentDates.Add(date.AddDays(4));

            return assignmentDates;
        }
        public static List<DateTime> datesStartingTuesday(DateTime date)
        {
            List<DateTime> assignmentDates = new List<DateTime>();
            assignmentDates.Add(date.AddDays(-1));
            assignmentDates.Add(date);
            assignmentDates.Add(date.AddDays(1));
            assignmentDates.Add(date.AddDays(2));
            assignmentDates.Add(date.AddDays(3));

            return assignmentDates;
        }
        public static List<DateTime> datesStartingWednesday(DateTime date)
        {
            List<DateTime> assignmentDates = new List<DateTime>();
            assignmentDates.Add(date.AddDays(-2));
            assignmentDates.Add(date.AddDays(-1));
            assignmentDates.Add(date);
            assignmentDates.Add(date.AddDays(1));
            assignmentDates.Add(date.AddDays(2));

            return assignmentDates;
        }
        public static List<DateTime> datesStartingThursday(DateTime date)
        {
            List<DateTime> assignmentDates = new List<DateTime>();
            assignmentDates.Add(date.AddDays(-3));
            assignmentDates.Add(date.AddDays(-2));
            assignmentDates.Add(date.AddDays(-1));
            assignmentDates.Add(date);
            assignmentDates.Add(date.AddDays(1));

            return assignmentDates;
        }
        public static List<DateTime> datesStartingFriday(DateTime date)
        {
            List<DateTime> assignmentDates = new List<DateTime>();
            assignmentDates.Add(date.AddDays(-4));
            assignmentDates.Add(date.AddDays(-3));
            assignmentDates.Add(date.AddDays(-2));
            assignmentDates.Add(date.AddDays(-1));
            assignmentDates.Add(date);

            return assignmentDates;
        }
        public static List<DateTime> datesStartingSaturday(DateTime date)
        {
            List<DateTime> assignmentDates = new List<DateTime>();
            assignmentDates.Add(date.AddDays(-5));
            assignmentDates.Add(date.AddDays(-4));
            assignmentDates.Add(date.AddDays(-3));
            assignmentDates.Add(date.AddDays(-2));
            assignmentDates.Add(date.AddDays(-1));

            return assignmentDates;
        }
        public static List<DateTime> datesStartingSunday(DateTime date)
        {
            List<DateTime> assignmentDates = new List<DateTime>();
            assignmentDates.Add(date.AddDays(-6));
            assignmentDates.Add(date.AddDays(-5));
            assignmentDates.Add(date.AddDays(-4));
            assignmentDates.Add(date.AddDays(-3));
            assignmentDates.Add(date.AddDays(-2));

            return assignmentDates;
        }
        public static List<DateTime> GetDatesList(DateTime date)
        {
            List<DateTime> workingDays = new List<DateTime>();
            int a = (int)date.DayOfWeek;
            switch (a)
            {
                case 1: workingDays = Date.datesStartingMonday(date); break;
                case 2: workingDays = Date.datesStartingTuesday(date); break;
                case 3: workingDays = Date.datesStartingWednesday(date); break;
                case 4: workingDays = Date.datesStartingThursday(date); break;
                case 5: workingDays = Date.datesStartingFriday(date); break;
                case 6: workingDays = Date.datesStartingSaturday(date); break;
                case 7: workingDays = Date.datesStartingSunday(date); break;
                default: Console.WriteLine("Wrong input"); break;
            }
            return workingDays;
        }
    }
}
