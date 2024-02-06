using DavideBorghi.ItalianDotNetDateTimeUtils.DateTimeEnums;
using System;

namespace DavideBorghi.ItalianDotNetDateTimeUtils
{
    /// <summary>
    /// Provides extension methods for <see cref="DateTime"/>, supporting equality check, week and weekends, days of months, quarters and four month periods.
    /// </summary>
    public static class DateTimeExtensions
    {
        #region Equals

        /// <summary>
        /// Tells if two dates are equal by their <see cref="DateTime.Date"/> property.
        /// </summary>
        /// <param name="firstDate">The first date to compare.</param>
        /// <param name="secondDate">The second date to compare.</param>
        /// <returns>True if the two values are equal; otherwise, false.</returns>
        public static bool EqualsByDate(this DateTime firstDate, DateTime secondDate)
            => firstDate.Date == secondDate.Date;

        #endregion

        #region Day

        /// <summary>
        /// Tells if the day of a given date is week end or not.
        /// </summary>
        /// <param name="dateTime">The given date time.</param>
        /// <returns>A boolean value representing if the date of the given date is week end or not.</returns>
        public static bool IsWeekend(this DateTime dateTime)
            => dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;

        #endregion

        #region Week

        /// <summary>
        /// Gets the date of the week start (Monday set as default) of the given date.
        /// </summary>
        /// <param name="dateTime">The given date time.</param>
        /// <param name="startOfWeek">The start day of the week, Monday set as default.</param>
        /// <returns>The date of the week start of the given date.</returns>
        public static DateTime StartOfWeek(this DateTime dateTime, DayOfWeek startOfWeek = DayOfWeek.Monday)
        {
            int num = (7 + (dateTime.DayOfWeek - startOfWeek)) % 7;
            return dateTime.AddDays(-1 * num).Date;
        }

        /// <summary>
        /// Gets the date of the week end (Monday set as default week start day) of the given date.
        /// </summary>
        /// <param name="dateTime">The given date time.</param>
        /// <param name="startOfWeek">The start day of the week, Monday set as default.</param>
        /// <returns>The date of the week end of the given date.</returns>
        public static DateTime EndOfWeek(this DateTime dateTime, DayOfWeek startOfWeek = DayOfWeek.Monday)
            => StartOfWeek(dateTime, startOfWeek).AddDays(6.0);

        #endregion

        #region Month

        /// <summary>
        /// Gets an enum representation of the given date month of year.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An enum representation of the given date month of year.</returns>
        public static MonthOfYear MonthOfYear(this DateTime dateTime)
            => (MonthOfYear)dateTime.Month;

        /// <summary>
        /// Gets the first day of the given date month.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>The date of the first day of the month of the given date.</returns>
        public static DateTime FirstDayOfMonth(this DateTime dateTime)
            => new DateTime(dateTime.Year, dateTime.Month, 1);

        /// <summary>
        /// Gets the last day of the given date month.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>The date of the last day of the month of the given date.</returns>
        public static DateTime LastDayOfMonth(this DateTime dateTime)
            => new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));

        #endregion

        #region Quarter

        /// <summary>
        /// Gets the ordinal number of the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An integer representing the ordinal number of the date corresponding quarter.</returns>
        public static int Quarter(this DateTime dateTime)
        {
            switch (dateTime.Month)
            {
                case int month when month <= 3:
                    return 1;
                case int month when month <= 6:
                    return 2;
                case int month when month <= 9:
                    return 3;
                default:
                    return 4;
            }
        }

        /// <summary>
        /// Gets an enum representing the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An enum representing the quarter related to the given date.</returns>
        public static QuarterOfYear QuarterOfYear(this DateTime dateTime)
        {
            switch (dateTime.Month)
            {
                case int month when month <= 3:
                    return DateTimeEnums.QuarterOfYear.First;
                case int month when month <= 6:
                    return DateTimeEnums.QuarterOfYear.Second;
                case int month when month <= 9:
                    return DateTimeEnums.QuarterOfYear.Third;
                default:
                    return DateTimeEnums.QuarterOfYear.Fourth;
            }
        }

        /// <summary>
        /// Gets the first day of the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>A date time representing the first day of the date corresponding quarter.</returns>
        public static DateTime FirstDayOfQuarter(this DateTime dateTime)
            => new DateTime(dateTime.Year, dateTime.FirstMonthOfQuarter(), 1);

        /// <summary>
        /// Gets the last day of the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>A date time representing the last day of the date corresponding quarter.</returns>
        public static DateTime LastDayOfQuarter(this DateTime dateTime)
            => new DateTime(dateTime.Year, dateTime.LastMonthOfQuarter(), 1).LastDayOfMonth();

        /// <summary>
        /// Gets the ordinal number of the first month of the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An integer representing the ordinal number of the first month of the date corresponding quarter.</returns>
        public static int FirstMonthOfQuarter(this DateTime dateTime)
        {
            switch (dateTime.Quarter())
            {
                case 1:
                    return 1;
                case 2:
                    return 4;
                case 3:
                    return 7;
                default:
                    return 10;
            }
        }

        /// <summary>
        /// Gets an enum representing the first month of the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An enum representing the first month of the date corresponding quarter.</returns>
        public static MonthOfYear FirstMonthOfQuarterYear(this DateTime dateTime)
        {
            switch (dateTime.QuarterOfYear())
            {
                case DateTimeEnums.QuarterOfYear.First:
                    return DateTimeEnums.MonthOfYear.January;
                case DateTimeEnums.QuarterOfYear.Second:
                    return DateTimeEnums.MonthOfYear.April;
                case DateTimeEnums.QuarterOfYear.Third:
                    return DateTimeEnums.MonthOfYear.July;
                default:
                    return DateTimeEnums.MonthOfYear.October;
            }
        }

        /// <summary>
        /// Gets the ordinal number of the last month of the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An integer representing the ordinal number of the last month of the date corresponding quarter.</returns>
        public static int LastMonthOfQuarter(this DateTime dateTime)
        {
            switch (dateTime.Quarter())
            {
                case 1:
                    return 3;
                case 2:
                    return 6;
                case 3:
                    return 9;
                default:
                    return 12;
            }
        }

        /// <summary>
        /// Gets an enum representing the last month of the date corresponding quarter.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An enum representing the last month of the date corresponding quarter.</returns>
        public static MonthOfYear LastMonthOfQuarterYear(this DateTime dateTime)
        {
            switch (dateTime.QuarterOfYear())
            {
                case DateTimeEnums.QuarterOfYear.First:
                    return DateTimeEnums.MonthOfYear.March;
                case DateTimeEnums.QuarterOfYear.Second:
                    return DateTimeEnums.MonthOfYear.June;
                case DateTimeEnums.QuarterOfYear.Third:
                    return DateTimeEnums.MonthOfYear.September;
                default:
                    return DateTimeEnums.MonthOfYear.December;
            }
        }

        #endregion

        #region Four Month Period

        /// <summary>
        /// Gets the ordinal number of the date corresponding fourth month period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An integer representing the ordinal number of the date corresponding fourth month period.</returns>
        public static int FourMonthPeriod(this DateTime dateTime)
        {
            switch (dateTime.Month)
            {
                case int month when month <= 4:
                    return 1;
                case int month when month <= 8:
                    return 2;
                default:
                    return 3;
            }
        }

        /// <summary>
        /// Gets an enum representing the date corresponding fourth month period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An enum representing the ordinal number of the date corresponding fourth month period.</returns>
        public static FourMonthPeriodOfYear FourMonthPeriodOfYear(this DateTime dateTime)
        {
            switch (dateTime.Month)
            {
                case int month when month <= 4:
                    return DateTimeEnums.FourMonthPeriodOfYear.First;
                case int month when month <= 8:
                    return DateTimeEnums.FourMonthPeriodOfYear.Second;
                default:
                    return DateTimeEnums.FourMonthPeriodOfYear.Third;
            }
        }

        /// <summary>
        /// Gets the first day of the date corresponding four mounth period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>A date time representing the first day of the date corresponding four month period.</returns>
        public static DateTime FirstDayOfFourMonthPeriod(this DateTime dateTime)
            => new DateTime(dateTime.Year, dateTime.FirstMonthOfFourMonthPeriod(), 1);

        /// <summary>
        /// Gets the last day of the date corresponding four mounth period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>A date time representing the last day of the date corresponding four month period.</returns>
        public static DateTime LastDayOfFourMonthPeriod(this DateTime dateTime)
            => new DateTime(dateTime.Year, dateTime.LastMonthOfFourMonthPeriod(), 1).LastDayOfMonth();

        /// <summary>
        /// Gets the ordinal number of the first month of the date corresponding four month period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An integer representing the ordinal number of the first month of the date corresponding four month period.</returns>
        public static int FirstMonthOfFourMonthPeriod(this DateTime dateTime)
        {
            switch (dateTime.FourMonthPeriod())
            {
                case 1:
                    return 1;
                case 2:
                    return 5;
                default:
                    return 9;
            }
        }

        /// <summary>
        /// Gets an enum representing the first month of the date corresponding four month period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An enum representing the first month of the date corresponding four month period.</returns>
        public static MonthOfYear FirstMonthOfFourMonthPeriodOfYear(this DateTime dateTime)
        {
            switch (dateTime.FourMonthPeriodOfYear())
            {
                case DateTimeEnums.FourMonthPeriodOfYear.First:
                    return DateTimeEnums.MonthOfYear.January;
                case DateTimeEnums.FourMonthPeriodOfYear.Second:
                    return DateTimeEnums.MonthOfYear.May;
                default:
                    return DateTimeEnums.MonthOfYear.September;
            }
        }

        /// <summary>
        /// Gets the ordinal number of the last month of the date corresponding four month period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An integer representing the ordinal number of the last month of the date corresponding four month period.</returns>
        public static int LastMonthOfFourMonthPeriod(this DateTime dateTime)
        {
            switch (dateTime.FourMonthPeriod())
            {
                case 1:
                    return 4;
                case 2:
                    return 8;
                default:
                    return 12;
            }
        }

        /// <summary>
        /// Gets an enum representing the last month of the date corresponding four month period.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>An enum representing the last month of the date corresponding four month period.</returns>
        public static MonthOfYear LastMonthOfFourMonthPeriodOfYear(this DateTime dateTime)
        {
            switch (dateTime.FourMonthPeriodOfYear())
            {
                case DateTimeEnums.FourMonthPeriodOfYear.First:
                    return DateTimeEnums.MonthOfYear.April;
                case DateTimeEnums.FourMonthPeriodOfYear.Second:
                    return DateTimeEnums.MonthOfYear.August;
                default:
                    return DateTimeEnums.MonthOfYear.December;
            }
        }

        #endregion
    }
}
