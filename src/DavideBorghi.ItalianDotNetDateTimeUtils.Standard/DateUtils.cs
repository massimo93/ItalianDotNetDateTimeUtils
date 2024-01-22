using System;
using System.Collections.Generic;
using System.Linq;

namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard
{
    public static class DateUtils
    {
        #region Public Methods

        /// <summary>
        /// Gets the date time from a date formatted as string plus the year as an integer.
        /// </summary>
        /// <param name="dateAsString">Date formatted as ddMM</param>
        /// <param name="year">An integer value representing the year.</param>
        /// <returns>The day in DateTime format.</returns>
        public static DateTime GetDateTimeFromDateAsStringAndYear(string dateAsString, int year)
        {
            int day = int.Parse(dateAsString[..2]);
            int month = int.Parse(dateAsString.Substring(2, 2));
            year = dateAsString.Length > 4 ? int.Parse(dateAsString.Substring(4, 4)) : year;
            return new DateTime(year, month, day);
        }

        /// <summary>
        /// Gets an array of years between two dates.
        /// </summary>
        /// <param name="startDate">The starting date.</param>
        /// <param name="endDate">The ending date.</param>
        /// <returns>An array of integers containing the years between the two given dates.</returns>
        /// <exception cref="System.ArgumentException">Thrown when provided starting date is bigger then given ending date.</exception>
        public static int[] GetYearsBetweenDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate) {
                throw new ArgumentException($"{nameof(startDate)} cannot be bigger than {nameof(endDate)}");
            }

            List<int> years = new List<int>();
            int startYear = startDate.Year;

            while (startYear <= endDate.Year)
                years.Add(startYear++);
            return years.ToArray();
        }

        #endregion
    }
}
