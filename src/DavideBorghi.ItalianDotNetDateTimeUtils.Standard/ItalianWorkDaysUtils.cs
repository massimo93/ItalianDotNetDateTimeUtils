using System;

namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard
{
    public class ItalianWorkDaysUtils
    {
        #region Public Functions

        public static Func<DateTime, bool> ExcludeWeekendsCondition => date => !date.IsWeekend();
        public static Func<DateTime, bool> ExcludeSundaysCondition => date => date.DayOfWeek != DayOfWeek.Sunday;
        public static Func<DateTime, bool> IncludeWeekendsCondition => date => true;
        public static Func<DateTime, bool> IncludeOnlyEvenDaysCondition => date => date.Day % 2 == 0;
        public static Func<DateTime, bool> IncludeOnlyOddDaysCondition => date => date.Day % 2 != 0;

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the number of office days between two given dates, removing weekends and Italian national and local holidays.
        /// </summary>
        /// <param name="startDate">The starting date./param>
        /// <param name="endDate">The ending date.</param>
        /// <returns>The number of Italian office days between two dates.</returns>
        /// <exception cref="System.ArgumentException">Thrown when provided starting date is bigger then given ending date.</exception>
        public static int HowManyItalianOfficeDaysBetweenDates(DateTime startDate, DateTime endDate)
            => HowManyItalianWorkDaysBetweenDates(startDate, endDate, ExcludeWeekendsCondition);

        public static int HowManyItalianWorkDaysBetweenDates(DateTime startDate, DateTime endDate, Func<DateTime, bool> workingDayCondition)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException($"{nameof(startDate)} cannot be bigger than {nameof(endDate)}");
            }

            int workingDaysCount = 0;
            DateTime currentDate = startDate;

            while (currentDate <= endDate)
            {
                if (workingDayCondition(currentDate) && !ItalianHolidaysUtils.IsHoliday(currentDate))
                    workingDaysCount++;
                currentDate = currentDate.AddDays(1);
            }

            return workingDaysCount;
        }

        #endregion
    }
}
