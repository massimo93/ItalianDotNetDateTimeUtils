using System;

namespace DavideBorghi.ItalianDotNetDateTimeUtils
{
    /// <summary>
    /// Provides static utility methods when dealing with Italian work days calculations.
    /// </summary>
    public static class ItalianWorkDaysUtils
    {
        #region Public Functions

        /// <summary>
        /// Function set up to exclude weekends.
        /// </summary>
        public static Func<DateTime, bool> ExcludeWeekendsCondition => date => !date.IsWeekend();

        /// <summary>
        /// Function set up to exclude Sundays only.
        /// </summary>
        public static Func<DateTime, bool> ExcludeSundaysCondition => date => date.DayOfWeek != DayOfWeek.Sunday;

        /// <summary>
        /// Function set up to include weekends.
        /// </summary>
        public static Func<DateTime, bool> IncludeWeekendsCondition => date => true;

        /// <summary>
        /// Function set up to include only even days.
        /// </summary>
        public static Func<DateTime, bool> IncludeOnlyEvenDaysCondition => date => date.Day % 2 == 0;

        /// <summary>
        /// Function set up to include only odd days.
        /// </summary>
        public static Func<DateTime, bool> IncludeOnlyOddDaysCondition => date => date.Day % 2 != 0;

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the number of Italian office days between two given dates, removing weekends and Italian national and local holidays.
        /// </summary>
        /// <remarks>A typical Italian office week goes from Monday to Friday.</remarks>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>The number of Italian office days between two dates.</returns>
        /// <exception cref="ArgumentException">Thrown when provided start date is after given end date.</exception>
        /// <exception cref="ArgumentException">Thrown when one or both of the provided dates' year is before 1946.</exception>
        public static int HowManyItalianOfficeDaysBetweenDates(DateTime startDate, DateTime endDate)
            => HowManyItalianWorkDaysBetweenDates(startDate, endDate, ExcludeWeekendsCondition);

        /// <summary>
        /// Gets the number of Italian work days between two given dates, keeping those that match a given condition 
        /// but still removing Italian both national and local holidays.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="workDaysCondition">Condition to consider matching dates as work days.</param>
        /// <returns>The number of Italian calculated work days.</returns>
        /// <exception cref="ArgumentException">Thrown when: 
        /// - given start date is after given end date;
        /// - or when one or both of the provided dates' year is before 1946.</exception>
        public static int HowManyItalianWorkDaysBetweenDates(DateTime startDate, DateTime endDate, Func<DateTime, bool> workDaysCondition)
        {
            startDate = startDate.Date;
            endDate = endDate.Date;

            if (startDate > endDate)
            {
                throw new ArgumentException($"{nameof(startDate)} cannot be after {nameof(endDate)}");
            }

            int workDaysCount = 0;
            DateTime currentDate = startDate;

            while (currentDate <= endDate)
            {
                if (workDaysCondition(currentDate) && !ItalianHolidaysUtils.IsHoliday(currentDate))
                    workDaysCount++;
                currentDate = currentDate.AddDays(1);
            }

            return workDaysCount;
        }

        #endregion
    }
}
