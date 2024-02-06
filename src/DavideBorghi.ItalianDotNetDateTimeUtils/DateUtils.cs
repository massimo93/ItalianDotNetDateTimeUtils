using System;
using System.Collections.Generic;

namespace DavideBorghi.ItalianDotNetDateTimeUtils
{
    /// <summary>
    /// Provides simple static <see cref="DateTime"/> utility methods.
    /// </summary>
    public static class DateUtils
    {
        #region Public Methods

        /// <summary>
        /// Gets the date time from a date formatted as string plus the year as an integer.
        /// </summary>
        /// <param name="dateAsString">Date formatted as ddMM.</param>
        /// <param name="year">An integer value representing the year.</param>
        /// <returns>The day in DateTime format.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when:
        /// - provided day or month part of given date as string are not in a valid range;
        /// - or when given year value is less than System.Int32.MinValue or greater than System.Int32.MaxValue;
        /// - or when the corresponding DateTime is not valid.</exception>
        ///<exception cref="ArgumentNullException">Thrown when provided day or month part of given date as string are null or empty.</exception>
        ///<exception cref="FormatException">Thrown when provided day or month part of given date as string are not in the correct integer format.</exception>
        ///<exception cref="OverflowException">Thrown when provided day or month part of given date as string and converted as integer 
        ///result in a value less than System.Int32.MinValue or greater than System.Int32.MaxValue.</exception>
        public static DateTime GetDateTimeFromDateAsStringAndYear(string dateAsString, int year)
        {
            if (year < Int32.MinValue || year > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException($"Given '{nameof(year)}' value is out of allowed range");
            }
            if (string.IsNullOrWhiteSpace(dateAsString))
            {
                throw new ArgumentNullException($"Given '{nameof(dateAsString)}' is null or consists only in white-space characters");
            }

            dateAsString = dateAsString.Trim();

            int day = int.Parse(dateAsString.Substring(0, 2));
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException($"Day part of given '{nameof(dateAsString)}' is out of allowed range");
            }

            int month = int.Parse(dateAsString.Substring(2, 2));
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException($"Month part of given '{nameof(dateAsString)}' is out of allowed range");
            }

            year = dateAsString.Length > 4 ? int.Parse(dateAsString.Substring(4, 4)) : year;

            return new DateTime(year, month, day);
        }

        /// <summary>
        /// Gets an array of years between two dates.
        /// </summary>
        /// <param name="startDate">The starting date.</param>
        /// <param name="endDate">The ending date.</param>
        /// <returns>An array of integers containing the years between the two given dates.</returns>
        /// <exception cref="ArgumentException">Thrown when provided starting date is after given ending date.</exception>
        public static int[] GetYearsBetweenDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException($"{nameof(startDate)} cannot be after {nameof(endDate)}");
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
