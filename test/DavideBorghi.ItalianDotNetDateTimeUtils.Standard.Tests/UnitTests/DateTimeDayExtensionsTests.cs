namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard.Tests.UnitTests;

public sealed class DateTimeDayExtensionsTests
{
    #region IsWeekend

    [Fact]
    public void IsSaturdayWeekend()
    {
        Assert.True(new DateTime(2023, 3, 25).IsWeekend());
    }

    [Fact]
    public void IsSundayWeekend()
    {
        Assert.True(new DateTime(2023, 3, 26).IsWeekend());
    }

    [Fact]
    public void IsWeekDayNotAWeekendDay()
    {
        Assert.False(new DateTime(2023, 3, 24).IsWeekend());
    }

    #endregion
}
