using System;
using System.Collections.Generic;
using System.Linq;

namespace DavideBorghi.ItalianDotNetDateTimeUtils
{
    /// <summary>
    /// Provides static utility methods when working with Italian holidays checks.
    /// </summary>
    public static class ItalianHolidaysUtils
    {
        #region Constants

        private const int EasterMondayDaysCountFromEaster = 1;
        private const int AscensionOfJesusDaysCountFromEaster = 40;
        private const int FeastOfCorpusChristiDaysCountAfterEaster = 60;

        #endregion
        
        #region Public Fields

        /// <summary>
        /// Represents a condition to consider a date as local holiday.
        /// </summary>
        /// <remarks>
        /// Remember to set or update this condition to let the utility methods consider it.
        /// </remarks>
        public static Func<DateTime, bool> LocalHolidayCondition;

        #endregion

        #region Public Methods

        /// <summary>
        /// Tells if a particular date is an Italian (national or local) holiday or not.
        /// </summary>
        /// <param name="date">The given date.</param>
        /// <returns>True if the given date is an Italian (national or local) holiday; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown when provided date's year is before 1946.</exception>
        public static bool IsHoliday(DateTime date)
        {
            if (date.Year < 1946)
            {
                throw new ArgumentException($"Given {nameof(date)}'s year must be later than 1945");
            }

            DateTime yearlyEaster = GetYearlyEaster(date.Year);

            return date.IsNewYearsDay() 
                || date.IsEpiphany()
                || date.IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated()
                || date.IsSaintJosephsDay()
                || date.EqualsByDate(yearlyEaster)
                || date.EqualsByDate(yearlyEaster.AddDays(EasterMondayDaysCountFromEaster))
                || (date.Year < 1977 
                    && (date.EqualsByDate(yearlyEaster.AddDays(AscensionOfJesusDaysCountFromEaster)) 
                        || date.EqualsByDate(yearlyEaster.AddDays(FeastOfCorpusChristiDaysCountAfterEaster))))
                || date.IsItalianLiberationDay()
                || date.IsWorkersDay()
                || date.IsItalianRepublicDay()
                || date.IsSaintsPeterAndPaulFeast()
                || date.IsAssumptionOfMaryDay()
                || date.IsAllSaintsDay()
                || date.IsItalianNationalUnityAndArmedForcesDay()
                || date.IsImmaculateConceptionDay()
                || date.IsChristmas()
                || date.IsSaintStephensDay()
                || (LocalHolidayCondition != null && LocalHolidayCondition(date));
        }

        /// <summary>
        /// Gets the DateTime of Easter Sunday given the year.
        /// </summary>
        /// <param name="year">An integer value representing the year.</param>
        /// <returns>The DateTime representing of Easter Sunday.</returns>
        public static DateTime GetYearlyEaster(int year)
        {
            int num = year % 19;
            int num2 = year / 100;
            int num3 = (num2 - num2 / 4 - (8 * num2 + 13) / 25 + 19 * num + 15) % 30;
            int num4 = num3 - num3 / 28 * (1 - num3 / 28 * (29 / (num3 + 1)) * ((21 - num) / 11));
            int day = num4 - (year + year / 4 + num4 + 2 - num2 + num2 / 4) % 7 + 28;
            int month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            return new DateTime(year, month, day);
        }

        /// <summary>
        /// Gets a DateTime list of yearly Italian holidays.
        /// </summary>
        /// <param name="year">The given year.</param>
        /// <returns>A list of yearly Italian holidays.</returns>
        /// <exception cref="ArgumentException">Thrown when provided year is before 1946.</exception>
        public static IEnumerable<DateTime> GetYearlyItalianHolidays(int year)
        {
            if (year < 1946)
            {
                throw new ArgumentException($"Given {nameof(year)} must be later than 1945");
            }
            
            return GetItalianHolidaysInRange(new DateTime(year, 1, 1) , new DateTime(year, 12, 31));
        }

        /// <summary>
        /// Gets a DateTime list of Italian holidays between given dates.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>A list of Italian holidays in given dates range.</returns>
        /// <exception cref="ArgumentException">Thrown when provided start date is after given end date.</exception>
        /// <exception cref="ArgumentException">Thrown when one or both of the provided dates' year is before 1946.</exception>
        public static IEnumerable<DateTime> GetItalianHolidaysInRange(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException($"{nameof(startDate)} cannot be after {nameof(endDate)}");
            }

            return Enumerable
                .Range(0, (endDate - startDate).Days)
                .Select(offset => startDate.AddDays(offset))
                .Where(date => IsHoliday(date))
                .ToList();
        }

        #endregion
    }
}
