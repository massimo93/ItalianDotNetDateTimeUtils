namespace DavideBorghi.ItalianDotNetDateTimeUtils.Tests.UnitTests;

public sealed class DateTimeWeekExtensionsTests
{
    #region StartOfWeek

    [Theory]
    [InlineData("2023/03/20", "2023/03/20")]
    [InlineData("2023/03/20", "2023/03/21")]
    public void StartOfWeek_MustBeEqual(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.StartOfWeek(), secondDateTime.StartOfWeek());
        Assert.Equal(firstDateTime.StartOfWeek(DayOfWeek.Monday), secondDateTime.StartOfWeek());
        Assert.Equal(firstDateTime.StartOfWeek(DayOfWeek.Sunday), secondDateTime.StartOfWeek(DayOfWeek.Sunday));
        Assert.Equal(firstDateTime.StartOfWeek(DayOfWeek.Monday), secondDateTime.StartOfWeek(DayOfWeek.Monday));
    }

    [Theory]
    [InlineData("2023/03/20", "2023/03/27")]
    [InlineData("2022/03/20", "2023/03/20")]
    [InlineData("2022/03/01", "2023/04/01")]
    [InlineData("2023/03/01", "2022/04/01")]
    public void StartOfWeek_MustBeDifferent(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.StartOfWeek(), secondDateTime.StartOfWeek());
        Assert.NotEqual(firstDateTime.StartOfWeek(DayOfWeek.Sunday), secondDateTime.StartOfWeek(DayOfWeek.Sunday));
        Assert.NotEqual(firstDateTime.StartOfWeek(DayOfWeek.Sunday), secondDateTime.StartOfWeek(DayOfWeek.Tuesday));
    }

    [Theory]
    [InlineData("2023/03/20", "2023/03/20")]
    [InlineData("2023/03/20", "2023/03/21")]
    public void StartOfWeek_WithDifferentStartOfWeekDay_MustBeDifferent(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.StartOfWeek(DayOfWeek.Sunday), secondDateTime.StartOfWeek(DayOfWeek.Monday));
        Assert.NotEqual(firstDateTime.StartOfWeek(DayOfWeek.Sunday), secondDateTime.StartOfWeek(DayOfWeek.Tuesday));
        Assert.NotEqual(firstDateTime.StartOfWeek(DayOfWeek.Tuesday), secondDateTime.StartOfWeek(DayOfWeek.Friday));
    }

    #endregion

    #region EndOfWeek

    [Theory]
    [InlineData("2023/03/20", "2023/03/20")]
    [InlineData("2023/03/20", "2023/03/21")]
    public void EndOfWeek_MustBeEqual(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.EndOfWeek(), secondDateTime.EndOfWeek());
        Assert.Equal(firstDateTime.EndOfWeek(DayOfWeek.Monday), secondDateTime.EndOfWeek());
        Assert.Equal(firstDateTime.EndOfWeek(DayOfWeek.Sunday), secondDateTime.EndOfWeek(DayOfWeek.Sunday));
    }

    [Theory]
    [InlineData("2023/03/20", "2023/03/27")]
    [InlineData("2022/03/20", "2023/03/20")]
    [InlineData("2023/03/01", "2023/04/01")]
    [InlineData("2022/03/01", "2023/04/01")]
    public void EndOfWeek_MustBeDifferent(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.EndOfWeek(), secondDateTime.EndOfWeek());
        Assert.NotEqual(firstDateTime.EndOfWeek(DayOfWeek.Monday), secondDateTime.EndOfWeek());
        Assert.NotEqual(firstDateTime.EndOfWeek(DayOfWeek.Sunday), secondDateTime.EndOfWeek(DayOfWeek.Sunday));
        Assert.NotEqual(firstDateTime.EndOfWeek(DayOfWeek.Sunday), secondDateTime.EndOfWeek(DayOfWeek.Tuesday));
    }

    [Theory]
    [InlineData("2023/03/20", "2023/03/20")]
    [InlineData("2023/03/20", "2023/03/21")]
    public void EndOfWeek_WithDifferentStartOfWeekDay_MustBeDifferent(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.EndOfWeek(DayOfWeek.Sunday), secondDateTime.EndOfWeek(DayOfWeek.Wednesday));
        Assert.NotEqual(firstDateTime.EndOfWeek(DayOfWeek.Monday), secondDateTime.EndOfWeek(DayOfWeek.Tuesday));
    }

    #endregion
}
