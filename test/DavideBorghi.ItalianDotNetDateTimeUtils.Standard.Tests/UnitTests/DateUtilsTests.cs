namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard.Tests.UnitTests;

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
}
