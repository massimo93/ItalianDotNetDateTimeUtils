namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard.Tests.UnitTests;

public sealed class DateTimeFourMonthPeriodExtensionsTests
{
    #region Four Month Period and Four Month Period of Year

    [Theory]
    [InlineData("2023/01/01", 1)]
    [InlineData("2022/03/31", 1)]
    [InlineData("2023/05/01", 2)]
    [InlineData("2023/08/31", 2)]
    [InlineData("2023/09/01", 3)]
    [InlineData("2023/12/01", 3)]
    public void FourMonthPeriod_MustBeAsExpected(DateTime dateTime, int expectedFourMonthPeriod)
    {
        Assert.Equal(dateTime.FourMonthPeriod(), expectedFourMonthPeriod);
    }

    [Theory]
    [InlineData("2023/01/01", FourMonthPeriodOfYear.First)]
    [InlineData("2022/03/31", FourMonthPeriodOfYear.First)]
    [InlineData("2023/05/01", FourMonthPeriodOfYear.Second)]
    [InlineData("2023/08/31", FourMonthPeriodOfYear.Second)]
    [InlineData("2023/09/01", FourMonthPeriodOfYear.Third)]
    [InlineData("2023/12/01", FourMonthPeriodOfYear.Third)]
    public void FourMonthPeriodOfYear_MustBeAsExpected(DateTime dateTime, FourMonthPeriodOfYear expectedFourMonthPeriodOfYear)
    {
        Assert.Equal(dateTime.FourMonthPeriodOfYear(), expectedFourMonthPeriodOfYear);
    }

    [Theory]
    [InlineData("2023/01/01", "2023/02/16")]
    [InlineData("2023/02/16", "2023/03/31")]
    [InlineData("2023/05/01", "2022/05/01")]
    [InlineData("2023/09/01", "2023/12/31")]
    [InlineData("2023/12/01", "2023/10/01")]
    public void DifferentDateTimes_MustBeInSameFourMonthPeriod(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.Equal(firstDateTime.FourMonthPeriod(), secondDateTime.FourMonthPeriod());
    }

    [Theory]
    [InlineData("2023/01/01", "2023/10/01")]
    [InlineData("2023/02/16", "2023/05/01")]
    [InlineData("2023/05/01", "2022/12/01")]
    [InlineData("2023/09/01", "2023/08/31")]
    [InlineData("2023/01/01", "2023/12/31")]
    public void DifferentDateTimes_MustBeInDifferentFourMonthPeriod(DateTime firstDateTime, DateTime secondDateTime)
    {
        Assert.NotEqual(firstDateTime.FourMonthPeriod(), secondDateTime.FourMonthPeriod());
    }

    #endregion

    #region First and last day of Four Month Period

    [Theory]
    [InlineData("2023/02/16", "2023/01/01")]
    [InlineData("2022/05/16", "2022/05/01")]
    [InlineData("2023/08/16", "2023/05/01")]
    [InlineData("2023/12/12", "2023/09/01")]
    public void FirstDayOfFourMonthPeriod_MustBeAsExpected(DateTime givenDateTime, DateTime expectedDateTime)
    {
        Assert.Equal(givenDateTime.FirstDayOfFourMonthPeriod(), expectedDateTime);
    }

    [Theory]
    [InlineData("2023/02/16", "2023/04/30")]
    [InlineData("2022/05/16", "2022/08/31")]
    [InlineData("2023/08/16", "2023/08/31")]
    [InlineData("2023/12/12", "2023/12/31")]
    public void LastDayOfFourMonthPeriod_MustBeAsExpected(DateTime givenDateTime, DateTime expectedDateTime)
    {
        Assert.Equal(givenDateTime.LastDayOfFourMonthPeriod(), expectedDateTime);
    }

    #endregion

    #region First and last month of Four Month Period

    [Theory]
    [InlineData("2023/02/16", 1)]
    [InlineData("2022/05/16", 5)]
    [InlineData("2023/08/16", 5)]
    [InlineData("2023/12/12", 9)]
    [InlineData("2023/10/01", 9)]
    public void FirstMonthOfFourMonthPeriod_MustBeAsExpected(DateTime givenDateTime, int expectedMonth)
    {
        Assert.Equal(givenDateTime.FirstMonthOfFourMonthPeriod(), expectedMonth);
    }

    [Theory]
    [InlineData("2023/02/16", MonthOfYear.January)]
    [InlineData("2022/05/16", MonthOfYear.May)]
    [InlineData("2023/08/16", MonthOfYear.May)]
    [InlineData("2023/12/12", MonthOfYear.September)]
    public void FirstMonthOfFourMonthPeriodOfYear_MustBeAsExpected(DateTime givenDateTime, MonthOfYear expectedMonth)
    {
        Assert.Equal(givenDateTime.FirstMonthOfFourMonthPeriodOfYear(), expectedMonth);
    }

    [Theory]
    [InlineData("2023/02/16", 4)]
    [InlineData("2022/05/16", 8)]
    [InlineData("2023/08/16", 8)]
    [InlineData("2023/12/12", 12)]
    public void LastMonthOfFourMonthPeriod_MustBeAsExpected(DateTime givenDateTime, int expectedMonth)
    {
        Assert.Equal(givenDateTime.LastMonthOfFourMonthPeriod(), expectedMonth);
    }

    [Theory]
    [InlineData("2023/02/16", MonthOfYear.April)]
    [InlineData("2022/05/16", MonthOfYear.August)]
    [InlineData("2023/08/16", MonthOfYear.August)]
    [InlineData("2023/12/12", MonthOfYear.December)]
    public void LastMonthOfFourMonthPeriodOfYear_MustBeAsExpected(DateTime givenDateTime, MonthOfYear expectedMonth)
    {
        Assert.Equal(givenDateTime.LastMonthOfFourMonthPeriodOfYear(), expectedMonth);
    }

    #endregion
}
