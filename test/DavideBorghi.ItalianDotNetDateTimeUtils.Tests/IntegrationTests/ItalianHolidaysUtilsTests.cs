namespace DavideBorghi.ItalianDotNetDateTimeUtils.Tests.IntegrationTests;

public sealed class ItalianHolidaysUtilsTests
{
    #region Private Fields

    public static Func<DateTime, bool>? IncludeJune24AsLocalHoliday => date => date.Month == 6 && date.Day == 24;

    #endregion

    #region Easter

    [Theory]
    [InlineData(1900, "1900/04/15")]
    [InlineData(1927, "1927/04/17")]
    [InlineData(1951, "1951/03/25")]
    [InlineData(2000, "2000/04/23")]
    [InlineData(2023, "2023/04/09")]
    [InlineData(2049, "2049/04/18")]
    public void Check_If_EasterOfYear_Is_AsExpected(int year, DateTime expectedEasterDateTime)
    {
        DateTime calculatedEasterOfYear = ItalianHolidaysUtils.GetYearlyEaster(year);
        Assert.Equal(calculatedEasterOfYear, expectedEasterDateTime);
    }

    #endregion

    #region National Holidays

    [Fact]
    public void XmasIsHoliday()
    {
        Assert.True(ItalianHolidaysUtils.IsHoliday(new DateTime(2023, 12, 25)));
    }

    [Theory]
    [InlineData("1961/03/17")]
    [InlineData("2011/03/17")]
    [InlineData("2023/01/01")]
    [InlineData("2023/01/06")]
    [InlineData("2024/04/25")]
    [InlineData("2024/05/01")]
    [InlineData("2024/06/02")]
    [InlineData("2024/08/15")]
    [InlineData("2024/11/01")]
    [InlineData("2024/12/08")]
    [InlineData("2024/12/25")]
    [InlineData("2024/12/26")]
    public void Check_If_GivenNationalHolidayDateTime_IsHoliday(DateTime givenDate)
    {
        Assert.True(ItalianHolidaysUtils.IsHoliday(givenDate));
    }

    [Theory]
    [InlineData("2023/06/24")]
    public void Check_If_GivenLocalHolidayDateTime_IsHoliday(DateTime givenDate)
    {
        ItalianHolidaysUtils.LocalHolidayCondition = IncludeJune24AsLocalHoliday;
        Assert.True(ItalianHolidaysUtils.IsHoliday(givenDate));
        ItalianHolidaysUtils.LocalHolidayCondition = null;
    }

    [Theory]
    [InlineData("2023/11/04")]
    public void Check_If_GivenLocalHolidayDateTime_IsNotHoliday(DateTime givenDate)
    {
        ItalianHolidaysUtils.LocalHolidayCondition = IncludeJune24AsLocalHoliday;
        Assert.False(ItalianHolidaysUtils.IsHoliday(givenDate));
        ItalianHolidaysUtils.LocalHolidayCondition = null;
    }
    
    [Theory]
    [InlineData(2021, new[] { "2021-01-01", "2021-01-06", "2021-04-04", "2021-04-05", "2021-04-25", "2021-05-01", "2021-06-02", "2021-08-15", "2021-11-01", "2021-12-08", "2021-12-25", "2021-12-26" })]
    [InlineData(2022, new[] { "2022-01-01", "2022-01-06", "2022-04-17", "2022-04-18", "2022-04-25", "2022-05-01", "2022-06-02", "2022-08-15", "2022-11-01", "2022-12-08", "2022-12-25", "2022-12-26" })]
    [InlineData(2023, new[] { "2023-01-01", "2023-01-06", "2023-04-09", "2023-04-10", "2023-04-25", "2023-05-01", "2023-06-02", "2023-08-15", "2023-11-01", "2023-12-08", "2023-12-25", "2023-12-26" })]
    [InlineData(2024, new[] { "2024-01-01", "2024-01-06", "2024-03-31", "2024-04-01", "2024-04-25", "2024-05-01", "2024-06-02", "2024-08-15", "2024-11-01", "2024-12-08", "2024-12-25", "2024-12-26" })]
    [InlineData(2025, new[] { "2025-01-01", "2025-01-06", "2025-04-20", "2025-04-21", "2025-04-25", "2025-05-01", "2025-06-02", "2025-08-15", "2025-11-01", "2025-12-08", "2025-12-25", "2025-12-26" })]
    public void GetYearlyItalianHolidays_ShouldReturnCorrectResult(int year, string[] expectedDates)
    {
        // Arrange
        IEnumerable<DateTime> expectedDateTimeList = expectedDates.Select(date => DateTime.Parse(date));

        // Act
        IEnumerable<DateTime> result = ItalianHolidaysUtils.GetYearlyItalianHolidays(year);

        // Assert
        Assert.Equal(expectedDateTimeList, result);
    }

    [Theory]
    [InlineData(1945)] // Year before 1946
    public void GetYearlyItalianHolidays_ShouldThrowArgumentException(int year)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => ItalianHolidaysUtils.GetYearlyItalianHolidays(year));
    }

    [Theory]
    [InlineData("2021-01-01", "2021-12-31", new[] { "2021-01-01", "2021-01-06", "2021-04-04", "2021-04-05", "2021-04-25", "2021-05-01", "2021-06-02", "2021-08-15", "2021-11-01", "2021-12-08", "2021-12-25", "2021-12-26" })]
    [InlineData("2022-01-01", "2022-12-31", new[] { "2022-01-01", "2022-01-06", "2022-04-17", "2022-04-18", "2022-04-25", "2022-05-01", "2022-06-02", "2022-08-15", "2022-11-01", "2022-12-08", "2022-12-25", "2022-12-26" })]
    [InlineData("2023-01-01", "2023-12-31", new[] { "2023-01-01", "2023-01-06", "2023-04-09", "2023-04-10", "2023-04-25", "2023-05-01", "2023-06-02", "2023-08-15", "2023-11-01", "2023-12-08", "2023-12-25", "2023-12-26" })]
    [InlineData("2024-01-01", "2024-12-31", new[] { "2024-01-01", "2024-01-06", "2024-03-31", "2024-04-01", "2024-04-25", "2024-05-01", "2024-06-02", "2024-08-15", "2024-11-01", "2024-12-08", "2024-12-25", "2024-12-26" })]
    [InlineData("2025-01-01", "2025-12-31", new[] { "2025-01-01", "2025-01-06", "2025-04-20", "2025-04-21", "2025-04-25", "2025-05-01", "2025-06-02", "2025-08-15", "2025-11-01", "2025-12-08", "2025-12-25", "2025-12-26" })]
    public void GetItalianHolidaysInRange_ShouldReturnCorrectResult(string startDateString, string endDateString, string[] expectedDates)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);
        IEnumerable<DateTime> expectedDateTimeList = expectedDates.Select(date => DateTime.Parse(date));

        // Act
        IEnumerable<DateTime> result = ItalianHolidaysUtils.GetItalianHolidaysInRange(startDate, endDate);

        // Assert
        Assert.Equal(expectedDateTimeList, result);
    }

    [Theory]
    [InlineData("2022-12-31", "2022-01-01")] // Invalid date range
    public void GetItalianHolidaysInRange_ShouldThrowArgumentException(string startDateString, string endDateString)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => ItalianHolidaysUtils.GetItalianHolidaysInRange(startDate, endDate));
    }

    #endregion
}
