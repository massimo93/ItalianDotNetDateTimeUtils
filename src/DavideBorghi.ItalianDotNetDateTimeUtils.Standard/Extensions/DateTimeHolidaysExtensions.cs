using System;

namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard
{
    public static class DateTimeHolidaysExtensions
    {
        #region January's

        public static bool IsNewYearsDay(this DateTime dateTime)
            => dateTime.Month == 1 && dateTime.Day == 1;

        public static bool IsEpiphany(this DateTime dateTime)
            => dateTime.Month == 1 && dateTime.Day == 6 && (dateTime.Year < 1978 || dateTime.Year > 1984);

        #endregion

        #region March's 

        public static bool IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated(this DateTime dateTime)
            => dateTime.Month == 3 && dateTime.Day == 17 && dateTime.Year >= 1961 && (dateTime.Year - 1961) % 50 == 0;
        
        public static bool IsSaintJosephsDay(this DateTime dateTime)
            => dateTime.Month == 3 && dateTime.Day == 19 && dateTime.Year < 1977;
        
        #endregion

        #region April's

        internal static bool WasDuringRomeBirthday(this DateTime dateTime)
            => dateTime.Month == 4 && dateTime.Day == 21 && dateTime.Year >= 1924 && dateTime.Year <= 1944;
        
        public static bool IsItalianLiberationDay(this DateTime dateTime)
            => dateTime.Month == 4 && dateTime.Day == 25 && dateTime.Year > 1945;

        #endregion

        #region May's

        internal static bool IsLateModernPeriodWorkersDay(this DateTime dateTime)
            => dateTime.Month == 5 && dateTime.Day == 1 && dateTime.Year >= 1945;

        public static bool IsWorkersDay(this DateTime dateTime)
            => dateTime.Year >= 1890 && (dateTime.IsLateModernPeriodWorkersDay() || dateTime.WasDuringRomeBirthday());

        #endregion

        #region June's

        public static bool IsItalianRepublicDay(this DateTime dateTime)
            => dateTime.Month == 6 && dateTime.Day == 2 && dateTime.Year > 1946;

        public static bool IsSaintsPeterAndPaulFeast(this DateTime dateTime)
            => dateTime.Month == 6 && dateTime.Day == 29 && dateTime.Year < 1977;
        
        #endregion
        
        #region August's

        public static bool IsAssumptionOfMaryDay(this DateTime dateTime)
            => dateTime.Month == 8 && dateTime.Day == 15;

        #endregion
        
        #region November's

        public static bool IsAllSaintsDay(this DateTime dateTime)
            => dateTime.Month == 11 && dateTime.Day == 1;
        
        public static bool IsItalianNationalUnityAndArmedForcesDay(this DateTime dateTime)
            => dateTime.Month == 11 && dateTime.Day == 4 && dateTime.Year < 1977;
        
        #endregion
        
        #region Winter holidays' season

        public static bool IsImmaculateConceptionDay(this DateTime dateTime)
            => dateTime.Month == 12 && dateTime.Day == 8;
        
        public static bool IsChristmas(this DateTime dateTime)
            => dateTime.Month == 12 && dateTime.Day == 25;
        
        public static bool IsSaintStephensDay(this DateTime dateTime)
            => dateTime.Month == 12 && dateTime.Day == 26;

        #endregion
    }
}
