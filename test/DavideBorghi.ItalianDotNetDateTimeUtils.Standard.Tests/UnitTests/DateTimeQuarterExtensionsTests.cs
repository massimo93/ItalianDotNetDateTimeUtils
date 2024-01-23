namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard.Tests.UnitTests;

public sealed class DateTimeQuarterExtensionsTests
{
    #region Quarter and QuarterOfYear

    [Theory]
    [InlineData("2023/01/01", 1)]
    [InlineData("2023/02/16", 1)]
    [InlineData("2023/03/31", 1)]
    [InlineData("2023/05/01", 2)]
    [InlineData("2023/09/01", 3)]
    [InlineData("2023/12/01", 4)]
    public void Quarter_MustBeAsExpected(DateTime dateTime, int expectedQuarter)
    {
        Assert.Equal(dateTime.Quarter(), expectedQuarter);
    }

    [Theory]
    [InlineData("2023/01/01", QuarterOfYear.First)]
    [InlineData("2023/02/16", QuarterOfYear.First)]
    [InlineData("2023/03/31", QuarterOfYear.First)]
    [InlineData("2023/05/01", QuarterOfYear.Second)]
    [InlineData("2023/09/01", QuarterOfYear.Third)]
    [InlineData("2023/12/01", QuarterOfYear.Fourth)]
    public void QuarterOfYear_MustBeAsExpected(DateTime dateTime, QuarterOfYear expectedQuarter)
    {
        Assert.Equal(dateTime.QuarterOfYear(), expectedQuarter);
    }

    [Theory]
    [InlineData("2023/01/01", "2023/02/16")]
    [InlineData("2023/02/16", "2023/03/31")]
    [InlineData("2023/05/01", "2022/05/01")]
    [InlineData("2023/09/01", "2023/08/31")]
    [InlineData("2023/12/01", "2023/10/01")]
    public void DifferentDateTimes_MustBeInSameQuarter(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.Quarter(), secondDateTime.Quarter());
    }

    [Theory]
    [InlineData("2023/01/01", "2023/02/16")]
    [InlineData("2023/02/16", "2023/03/31")]
    [InlineData("2023/05/01", "2022/05/01")]
    [InlineData("2023/09/01", "2023/08/31")]
    [InlineData("2023/12/01", "2023/10/01")]
    public void DifferentDateTimes_MustBeInSameQuarterOfYear(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.QuarterOfYear(), secondDateTime.QuarterOfYear());
    }

    [Theory]
    [InlineData("2023/01/01", "2023/10/01")]
    [InlineData("2023/02/16", "2023/04/01")]
    [InlineData("2023/05/01", "2022/12/01")]
    [InlineData("2023/09/01", "2023/03/31")]
    [InlineData("2023/01/01", "2023/12/31")]
    public void DifferentDateTimes_MustBeInDifferentQuarter(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.Quarter(), secondDateTime.Quarter());
    }

    [Theory]
    [InlineData("2023/01/01", "2023/10/01")]
    [InlineData("2023/02/16", "2023/04/01")]
    [InlineData("2023/05/01", "2022/12/01")]
    [InlineData("2023/09/01", "2023/03/31")]
    [InlineData("2023/01/01", "2023/12/31")]
    public void DifferentDateTimes_MustBeInDifferentQuarterOfYear(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.QuarterOfYear(), secondDateTime.QuarterOfYear());
    }

    #endregion

    #region First and last day of Quarter

    [Theory]
    [InlineData("2023/02/16", "2023/01/01")]
    [InlineData("2022/05/16", "2022/04/01")]
    [InlineData("2023/08/16", "2023/07/01")]
    [InlineData("2023/12/12", "2023/10/01")]
    public void FirstDayOfQuarter_MustBeAsExpected(DateTime givenDateTime, DateTime expectedDateTime)
    {
        Assert.Equal(givenDateTime.FirstDayOfQuarter(), expectedDateTime);
    }

    [Theory]
    [InlineData("2023/02/16", "2023/03/31")]
    [InlineData("2022/05/16", "2022/06/30")]
    [InlineData("2023/08/16", "2023/09/30")]
    [InlineData("2023/12/12", "2023/12/31")]
    public void LastDayOfQuarter_MustBeAsExpected(DateTime givenDateTime, DateTime expectedDateTime)
    {
        Assert.Equal(givenDateTime.LastDayOfQuarter(), expectedDateTime);
    }

    #endregion

    #region First and last month of Quarter

    [Theory]
    [InlineData("2023/02/16", 1)]
    [InlineData("2022/05/16", 4)]
    [InlineData("2023/08/16", 7)]
    [InlineData("2023/12/12", 10)]
    [InlineData("2023/10/01", 10)]
    public void FirstMonthOfQuarter_MustBeAsExpected(DateTime givenDateTime, int expectedMonth)
    {
        Assert.Equal(givenDateTime.FirstMonthOfQuarter(), expectedMonth);
    }

    [Theory]
    [InlineData("2023/02/16", MonthOfYear.January)]
    [InlineData("2022/05/16", MonthOfYear.April)]
    [InlineData("2023/08/16", MonthOfYear.July)]
    [InlineData("2023/12/12", MonthOfYear.October)]
    public void FirstMonthOfQuarterYear_MustBeAsExpected(DateTime givenDateTime, MonthOfYear expectedMonth)
    {
        Assert.Equal(givenDateTime.FirstMonthOfQuarterYear(), expectedMonth);
    }

    [Theory]
    [InlineData("2023/02/16", 3)]
    [InlineData("2022/05/16", 6)]
    [InlineData("2023/08/16", 9)]
    [InlineData("2023/12/12", 12)]
    public void LastMonthOfQuarter_MustBeAsExpected(DateTime givenDateTime, int expectedMonth)
    {
        Assert.Equal(givenDateTime.LastMonthOfQuarter(), expectedMonth);
    }

    [Theory]
    [InlineData("2023/02/16", MonthOfYear.March)]
    [InlineData("2022/05/16", MonthOfYear.June)]
    [InlineData("2023/08/16", MonthOfYear.September)]
    [InlineData("2023/12/12", MonthOfYear.December)]
    public void LastMonthOfQuarterYear_MustBeAsExpected(DateTime givenDateTime, MonthOfYear expectedMonth)
    {
        Assert.Equal(givenDateTime.LastMonthOfQuarterYear(), expectedMonth);
    }

    #endregion
}
