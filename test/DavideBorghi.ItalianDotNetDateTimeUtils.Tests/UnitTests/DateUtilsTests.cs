namespace DavideBorghi.ItalianDotNetDateTimeUtils.Tests.UnitTests;

public sealed class DateUtilsTests
{
    [Theory]
    [InlineData("0101", 2021, 2021, 1, 1)] // January 1st, 2021
    [InlineData("1205", 2022, 2022, 5, 12)] // May 12th, 2022
    [InlineData("0603", 2020, 2020, 3, 6)] // March 6th, 2020
    [InlineData("2209", 2023, 2023, 9, 22)] // September 22nd, 2023
    [InlineData("1402", 1985, 1985, 2, 14)] // February 14th, 1985
    public void GetDateTimeFromDateAsStringAndYear_ShouldReturnCorrectResult(string dateAsString, int initialYear, int expectedYear, int expectedMonth, int expectedDay)
    {
        // Arrange
        int year = initialYear;

        // Act
        DateTime result = DateUtils.GetDateTimeFromDateAsStringAndYear(dateAsString, year);

        // Assert
        Assert.Equal(expectedYear, result.Year);
        Assert.Equal(expectedMonth, result.Month);
        Assert.Equal(expectedDay, result.Day);
    }

    [Theory]
    [InlineData(null, 2021, typeof(ArgumentNullException))] // Null dateAsString
    [InlineData("", 2021, typeof(ArgumentNullException))] // Empty dateAsString
    [InlineData("  ", 2021, typeof(ArgumentNullException))] // Whitespace-only dateAsString
    [InlineData("3205", 2021, typeof(ArgumentOutOfRangeException))] // Invalid day
    [InlineData("1233", 2021, typeof(ArgumentOutOfRangeException))] // Invalid month
    public void GetDateTimeFromDateAsStringAndYear_ShouldThrowExceptionForInvalidInput(string dateAsString, int year, Type expectedExceptionType)
    {
        // Act & Assert
        Assert.Throws(expectedExceptionType, () => DateUtils.GetDateTimeFromDateAsStringAndYear(dateAsString, year));
    }

    [Theory]
    [InlineData("0101", Int32.MaxValue, typeof(ArgumentOutOfRangeException))] // Invalid year (greater than Int32.MaxValue)
    [InlineData("0101", Int32.MinValue, typeof(ArgumentOutOfRangeException))] // Invalid year (less than Int32.MinValue)
    public void GetDateTimeFromDateAsStringAndYear_ShouldThrowExceptionForInvalidYear(string dateAsString, int year, Type expectedExceptionType)
    {
        // Act & Assert
        Assert.Throws(expectedExceptionType, () => DateUtils.GetDateTimeFromDateAsStringAndYear(dateAsString, year));
    }

    [Fact]
    public void GetYearsBetweenDates_ShouldReturnArrayOfYears()
    {
        // Arrange
        DateTime startDate = new(2020, 1, 1);
        DateTime endDate = new(2025, 12, 31);

        // Act
        int[] result = DateUtils.GetYearsBetweenDates(startDate, endDate);

        // Assert
        Assert.Equal([2020, 2021, 2022, 2023, 2024, 2025], result);
    }

    [Fact]
    public void GetYearsBetweenDates_ShouldReturnSingleYear()
    {
        // Arrange
        DateTime startDate = new(2022, 6, 15);
        DateTime endDate = new(2022, 12, 31);

        // Act
        int[] result = DateUtils.GetYearsBetweenDates(startDate, endDate);

        // Assert
        Assert.Equal([2022], result);
    }

    [Fact]
    public void GetYearsBetweenDates_ShouldThrowArgumentExceptionIfEndDateIsBeforeStartDate()
    {
        // Arrange
        DateTime startDate = new(2023, 1, 1);
        DateTime endDate = new(2022, 12, 31);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DateUtils.GetYearsBetweenDates(startDate, endDate));
    }

    [Theory]
    [InlineData("2020-01-01", "2025-12-31", new[] { 2020, 2021, 2022, 2023, 2024, 2025 })]
    [InlineData("2022-06-15", "2022-12-31", new[] { 2022 })]
    public void GetYearsBetweenDates_ShouldReturnArrayOfYears_UsingTheory(string startDateString, string endDateString, int[] expectedYears)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);

        // Act
        int[] result = DateUtils.GetYearsBetweenDates(startDate, endDate);

        // Assert
        Assert.Equal(expectedYears, result);
    }

    [Theory]
    [InlineData("2023-01-01", "2022-12-31")]
    public void GetYearsBetweenDates_ShouldThrowArgumentExceptionIfEndDateIsBeforeStartDate_UsingTheory(string startDateString, string endDateString)
    {
        // Arrange
        DateTime startDate = DateTime.Parse(startDateString);
        DateTime endDate = DateTime.Parse(endDateString);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DateUtils.GetYearsBetweenDates(startDate, endDate));
    }
}
