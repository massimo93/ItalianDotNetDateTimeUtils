using System;

namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard
{
    public static class DateTimeHolidaysExtensions
    {
        #region January's

        /// <summary>
        /// Tells if given date is New Year's Day.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is New Year's Day; otherwise, false.</returns>
        public static bool IsNewYearsDay(this DateTime dateTime)
            => dateTime.Month == 1 && dateTime.Day == 1;

        /// <summary>
        /// Tells if given date is Epiphany (i.e. January 6th, excluding occurrences from 1978 to 1984).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Epiphany; otherwise, false.</returns>
        public static bool IsEpiphany(this DateTime dateTime)
            => dateTime.Month == 1 && dateTime.Day == 6 && (dateTime.Year < 1978 || dateTime.Year > 1984);

        #endregion

        #region March's 

        /// <summary>
        /// Tells if given date is the Anniversary of the Unification Of Italy:
        /// this official celebration occurres on March 17th and every 50 years from 1961 included.
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is is the Anniversary of the Unification Of Italy; otherwise, false.</returns>
        public static bool IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated(this DateTime dateTime)
            => dateTime.Month == 3 && dateTime.Day == 17 && dateTime.Year >= 1961 && (dateTime.Year - 1961) % 50 == 0;
        
        /// <summary>
        /// Tells if given date is Saint Joseph's Day (i.e. March 19th, until 1977 excluded).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Saint Joseph's Day; otherwise, false.</returns>
        public static bool IsSaintJosephsDay(this DateTime dateTime)
            => dateTime.Month == 3 && dateTime.Day == 19 && dateTime.Year < 1977;
        
        #endregion

        #region April's

        /// <summary>
        /// Tells if given date was City of Rome foundation celebration day (i.e. April 21st, from 1924 to 1944, both included).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date was City of Rome foundation celebration day; otherwise, false.</returns>
        internal static bool WasDuringRomeBirthday(this DateTime dateTime)
            => dateTime.Month == 4 && dateTime.Day == 21 && dateTime.Year >= 1924 && dateTime.Year <= 1944;
        
        /// <summary>
        /// Tells if given date is Italian Liberation Day (i.e. April 25th).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Italian Liberation Day; otherwise, false.</returns>
        public static bool IsItalianLiberationDay(this DateTime dateTime)
            => dateTime.Month == 4 && dateTime.Day == 25 && dateTime.Year > 1945;

        #endregion

        #region May's

        /// <summary>
        /// Tells if given date is Italian Late Modern Period Workers' Day (i.e. May 1th since 1945 included).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Italian Late Modern Period Workers' Day; otherwise, false.</returns>
        internal static bool IsLateModernPeriodWorkersDay(this DateTime dateTime)
            => dateTime.Month == 5 && dateTime.Day == 1 && dateTime.Year >= 1945;

        /// <summary>
        /// Tells if given date is Italian Workers' Day:
        /// from 1890 this day has been celebrated on May 1th during Late Modern Period,
        /// or during City of Rome foundation celebration day (i.e. April 21st, from 1924 to 1944, both included).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Italian Workers' Day; otherwise, false.</returns>
        public static bool IsWorkersDay(this DateTime dateTime)
            => dateTime.Year >= 1890 && (dateTime.IsLateModernPeriodWorkersDay() || dateTime.WasDuringRomeBirthday());

        #endregion

        #region June's

        /// <summary>
        /// Tells if given date is Italian Republic Day (i.e. June 2nd since 1946 excluded).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Italian Republic Day; otherwise, false.</returns>
        public static bool IsItalianRepublicDay(this DateTime dateTime)
            => dateTime.Month == 6 && dateTime.Day == 2 && dateTime.Year > 1946;

        /// <summary>
        /// Tells if given date is Saints Peter and Paul Feast (i.e. June 29th until 1977 excluded).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Saints Peter and Paul Feast; otherwise, false.</returns>
        public static bool IsSaintsPeterAndPaulFeast(this DateTime dateTime)
            => dateTime.Month == 6 && dateTime.Day == 29 && dateTime.Year < 1977;
        
        #endregion
        
        #region August's

        /// <summary>
        /// Tells if given date is Assumption Of Mary Day (i.e. August 15th).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Assumption Of Mary Day; otherwise, false.</returns>
        public static bool IsAssumptionOfMaryDay(this DateTime dateTime)
            => dateTime.Month == 8 && dateTime.Day == 15;

        #endregion
        
        #region November's

        /// <summary>
        /// Tells if given date is All Saints' Day (i.e. November 1st).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is All Saints' Day; otherwise, false.</returns>
        public static bool IsAllSaintsDay(this DateTime dateTime)
            => dateTime.Month == 11 && dateTime.Day == 1;
        
        /// <summary>
        /// Tells if given date is Italian National Unity and Armed Forces Day (i.e. November 4th until 1977 excluded).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Italian National Unity and Armed Forces Day; otherwise, false.</returns>
        public static bool IsItalianNationalUnityAndArmedForcesDay(this DateTime dateTime)
            => dateTime.Month == 11 && dateTime.Day == 4 && dateTime.Year < 1977;
        
        #endregion
        
        #region Winter holidays' season

        /// <summary>
        /// Tells if given date is Immaculate Conception Day (i.e. December 8th).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Immaculate Conception Day; otherwise, false.</returns>
        public static bool IsImmaculateConceptionDay(this DateTime dateTime)
            => dateTime.Month == 12 && dateTime.Day == 8;
        
        /// <summary>
        /// Tells if given date is Christmas Day (i.e. December 25th).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Christmas Day; otherwise, false.</returns>
        public static bool IsChristmas(this DateTime dateTime)
            => dateTime.Month == 12 && dateTime.Day == 25;

        /// <summary>
        /// Tells if given date is Saint Stephen's Day (i.e. December 26th).
        /// </summary>
        /// <param name="dateTime">The given date.</param>
        /// <returns>True if given date is Saint Stephen's Day; otherwise, false.</returns>
        public static bool IsSaintStephensDay(this DateTime dateTime)
            => dateTime.Month == 12 && dateTime.Day == 26;

        #endregion
    }
}
