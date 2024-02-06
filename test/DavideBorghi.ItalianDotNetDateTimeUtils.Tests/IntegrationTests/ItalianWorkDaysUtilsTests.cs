namespace DavideBorghi.ItalianDotNetDateTimeUtils.Tests.IntegrationTests;

public sealed class ItalianWorkDaysUtilsTests
{
    #region Private Fields

    public static Func<DateTime, bool>? IncludeJune24AsLocalHoliday => date => date.Month == 6 && date.Day == 24;

    #endregion

    [Theory]
    [InlineData("2021-01-01", "2021-01-10", 4)] // January 1 and January 6, 2021 are both holidays, so 4 office days
    [InlineData("2022-05-01", "2022-05-10", 7)] // May 1, 2022 is a holiday, so 7 office days
    [InlineData("2022-12-24", "2022-12-31", 4)] // December 25 and December 26, 2022, are both holidays, so 4 office days
    [InlineData("2023-07-01", "2023-07-10", 6)] // No holidays, but still weekends, so 6 office days
    [InlineData("2023-11-01", "2023-11-10", 7)] // November 1, 2023 is a holiday, a weekend is present, so 7 office days
    [InlineData("2023-12-25", "2023-12-26", 0)] // Christmas and Saint Stephen's Day, so 0 office days
    [InlineData("2024-02-06", "2024-02-06", 1)] // Single office day
    [InlineData("2024-02-01", "2024-02-11", 7)] // No holidays, but still weekends, so 7 office days
    public void HowManyItalianOfficeDaysBetweenDates_ShouldReturnCorrectResult(string startDateString, string endDateString, int expectedWorkingDays)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);

        // Act
        int result = ItalianWorkDaysUtils.HowManyItalianOfficeDaysBetweenDates(startDate, endDate);

        // Assert
        Assert.Equal(expectedWorkingDays, result);
    }

    [Theory]
    [InlineData("2021-01-01", "2021-01-10", 4)] // January 1 and January 6, 2021 are both holidays, so 4 working days
    [InlineData("2022-05-01", "2022-05-10", 7)] // May 1, 2022 is a holiday, so 7 working days
    [InlineData("2022-12-24", "2022-12-31", 4)] // December 25 and December 26, 2022, are both holidays, so 4 working days
    [InlineData("2023-07-01", "2023-07-10", 6)] // No holidays, but still weekends, so 6 working days
    [InlineData("2023-11-01", "2023-11-10", 7)] // November 1, 2023 is a holiday, a weekend is present, so 7 working days
    [InlineData("2023-12-25", "2023-12-26", 0)] // Christmas and Saint Stephen's Day, so 0 working days
    [InlineData("2024-02-06", "2024-02-06", 1)] // Single working day
    [InlineData("2024-02-01", "2024-02-11", 7)] // No holidays, but still weekends, so 7 working days
    public void HowManyItalianWorkDaysBetweenDates_ExcludingWeekends_ShouldReturnCorrectResult(string startDateString, string endDateString, int expectedWorkingDays)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);

        // Act
        int result = ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(startDate, endDate, ItalianWorkDaysUtils.ExcludeWeekendsCondition);

        // Assert
        Assert.Equal(expectedWorkingDays, result);
    }

    [Theory]
    [InlineData("2024-01-01", "2024-01-07", 4)] // January 1 and January 6, plus a Sunday, so 4 working days if we include Saturdays
    [InlineData("2024-02-01", "2024-02-11", 9)] // No holidays, but still sundays, so 9 working days if we include Saturdays
    public void HowManyItalianWorkDaysBetweenDates_ExcludeSundays_ShouldReturnCorrectResult(string startDateString, string endDateString, int expectedWorkingDays)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);

        // Act
        int result = ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(startDate, endDate, ItalianWorkDaysUtils.ExcludeSundaysCondition);

        // Assert
        Assert.Equal(expectedWorkingDays, result);
    }

    [Theory]
    [InlineData("2024-01-01", "2024-01-08", 3)] // January 1 and a weekend, so 3 even working days
    [InlineData("2024-02-01", "2024-02-15", 5)] // No holidays, but still 2 weekends, so 5 even working days
    public void HowManyItalianWorkDaysBetweenDates_ExcludeWeekends_TakeOnlyEvenDays_ShouldReturnCorrectResult(string startDateString, string endDateString, int expectedWorkingDays)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);
        static bool excludeWeekendsAndTakeOnlyEvenDays(DateTime date)
            => ItalianWorkDaysUtils.ExcludeWeekendsCondition(date) && ItalianWorkDaysUtils.IncludeOnlyEvenDaysCondition(date);

        // Act
        int result = ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(startDate, endDate, excludeWeekendsAndTakeOnlyEvenDays);

        // Assert
        Assert.Equal(expectedWorkingDays, result);
    }

    [Theory]
    [InlineData("2024-01-01", "2024-01-08", 2)] // January 1 and a weekend, so 2 odd working days
    [InlineData("2024-02-01", "2024-02-15", 6)] // No holidays, but still 2 weekends, so 6 odd working days
    public void HowManyItalianWorkDaysBetweenDates_ExcludeWeekends_TakeOnlyOddDays_ShouldReturnCorrectResult(string startDateString, string endDateString, int expectedWorkingDays)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);
        static bool excludeWeekendsAndTakeOnlyOddDays(DateTime date)
            => ItalianWorkDaysUtils.ExcludeWeekendsCondition(date) && ItalianWorkDaysUtils.IncludeOnlyOddDaysCondition(date);

        // Act
        int result = ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(startDate, endDate, excludeWeekendsAndTakeOnlyOddDays);

        // Assert
        Assert.Equal(expectedWorkingDays, result);
    }

    [Theory]
    [InlineData("2022-06-23", "2022-06-25", 1)] // June 24, is a local holiday in Turin (Italy), so 1 working day
    [InlineData("2022-06-20", "2022-06-24", 4)] // June 24, is a local holiday in Turin (Italy), so 4 working days
    [InlineData("2023-06-24", "2023-06-25", 0)] // June 24, is a local holiday in Turin (Italy), so 0 working days, considering the weekend as well
    [InlineData("2024-06-21", "2024-06-25", 2)] // June 24, is a local holiday in Turin (Italy), so 2 working days, considering the weekend as well
    public void HowManyItalianWorkDaysBetweenDates_ExcludingWeekends_IncludingJune24thAsLocalHoliday_ShouldReturnCorrectResult(string startDateString, string endDateString, int expectedWorkingDays)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);
        ItalianHolidaysUtils.LocalHolidayCondition = IncludeJune24AsLocalHoliday;

        // Act
        int result = ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(startDate, endDate, ItalianWorkDaysUtils.ExcludeWeekendsCondition);

        // Assert
        Assert.Equal(expectedWorkingDays, result);

        // Reset
        ItalianHolidaysUtils.LocalHolidayCondition = null;
    }

    [Theory]
    [InlineData("2022-12-31", "2022-12-24")] // End date before start date
    public void HowManyItalianWorkDaysBetweenDates_ShouldThrowArgumentException(string startDateString, string endDateString)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);

        // Act & Assert
        Assert.Throws<ArgumentException>(() 
            => ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(startDate, endDate, ItalianWorkDaysUtils.ExcludeWeekendsCondition));
    }
}
