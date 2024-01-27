namespace DavideBorghi.ItalianDotNetDateTimeUtils.Tests.UnitTests;

public sealed class DateTimeMonthExtensionsTests
{
    #region MonthOfYear

    [Fact]
    public void MonthOfYear_MustBeJanuary()
    {
        Assert.Equal(DateTimeEnums.MonthOfYear.January, new DateTime(2023, 1, 1).MonthOfYear());
    }

    [Theory]
    [InlineData("2023/07/16")]
    public void MonthOfYear_MustBeAsExpected(DateTime datetime, DateTimeEnums.MonthOfYear expectedMonthOfYear = DateTimeEnums.MonthOfYear.July)
    {
        Assert.Equal(datetime.MonthOfYear(), expectedMonthOfYear);
    }

    [Theory]
    [InlineData("2022/01/01", "2022/01/01")]
    [InlineData("2023/07/16", "2023/07/16")]
    [InlineData("2022/07/16", "2023/07/01")]
    [InlineData("2022/07/16", "2022/07/01")]
    public void MonthOfYear_MustBeEqual(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.MonthOfYear(), secondDateTime.MonthOfYear());
    }

    [Theory]
    [InlineData("2023/06/16", "2023/07/01")]
    public void MonthOfYear_MustBeDifferent(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.MonthOfYear(), secondDateTime.MonthOfYear());
    }

    #endregion

    #region FirstDayOfMonth && LastDayOfMonth

    [Fact]
    public void FirstDayOfMonth_MustBe_First()
    {
        var dateTime = new DateTime(2023, 1, 1);
        Assert.Equal(dateTime, dateTime.FirstDayOfMonth());
    }

    [Theory]
    [InlineData("2023/01/16", "2023/01/31")]
    public void FirstDayOfMonth_MustBeEqual_WhenSameMonth(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.FirstDayOfMonth(), secondDateTime.FirstDayOfMonth());
    }

    [Theory]
    [InlineData("2023/01/16", "2023/02/16")]
    [InlineData("2022/01/16", "2023/01/16")]
    public void FirstDayOfMonth_MustBeDifferent_WhenDifferentMonthOrYear(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.FirstDayOfMonth(), secondDateTime.FirstDayOfMonth());
    }

    [Theory]
    [InlineData("2023/01/01", "2023/01/01")]
    [InlineData("2023/02/28", "2023/02/01")]
    [InlineData("2023/04/01", "2023/04/01")]
    [InlineData("2020/02/29", "2020/02/01")]
    public void FirstDayOfMonth_Shoud_Be_As_Expected(DateTime inputDateTime, DateTime expectedDateTime)
    {
        Assert.Equal(inputDateTime.FirstDayOfMonth(), expectedDateTime);
    }

    [Fact]
    public void LastDayOfMonth_MustBe_Last()
    {
        var dateTime = new DateTime(2023, 1, 31);
        Assert.Equal(dateTime, dateTime.LastDayOfMonth());
    }

    [Theory]
    [InlineData("2023/01/16", "2023/01/31")]
    public void LastDayOfMonth_MustBeEqual_WhenSameMonth(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.LastDayOfMonth(), secondDateTime.LastDayOfMonth());
    }

    [Theory]
    [InlineData("2023/01/16", "2023/02/16")]
    [InlineData("2022/01/16", "2023/01/16")]
    public void LastDayOfMonth_MustBeDifferent_WhenDifferentMonthOrYear(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.LastDayOfMonth(), secondDateTime.LastDayOfMonth());
    }

    [Theory]
    [InlineData("2023/01/01", "2023/01/31")]
    [InlineData("2023/02/01", "2023/02/28")]
    [InlineData("2023/04/01", "2023/04/30")]
    [InlineData("2020/02/01", "2020/02/29")]
    public void LastDayOfMonth_Shoud_Be_As_Expected(DateTime inputDateTime, DateTime expectedDateTime)
    {
        Assert.Equal(inputDateTime.LastDayOfMonth(), expectedDateTime);
    }

    #endregion
}
