namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard.Tests.UnitTests;

public sealed class NationalHolidaysExtensionsTests
{
    #region January's

    [Fact]
    public void IsNewYearsDay_ShouldReturnTrueForJanuary1st()
    {
        // Arrange
        DateTime newYearsDay = new(2022, 1, 1);

        // Act
        bool result = newYearsDay.IsNewYearsDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNewYearsDay_ShouldReturnFalseForNonJanuary1st()
    {
        // Arrange
        DateTime nonNewYearsDay = new(2022, 2, 15);

        // Act
        bool result = nonNewYearsDay.IsNewYearsDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsEpiphany_ShouldReturnTrueForJanuary6thBefore1978()
    {
        // Arrange
        DateTime epiphanyBefore1978 = new(1977, 1, 6);

        // Act
        bool result = epiphanyBefore1978.IsEpiphany();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEpiphany_ShouldReturnFalseForJanuary6thBetween1978And1984()
    {
        // Arrange
        DateTime epiphanyBetween1978And1984 = new(1980, 1, 6);

        // Act
        bool result = epiphanyBetween1978And1984.IsEpiphany();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsEpiphany_ShouldReturnTrueForJanuary6thAfter1984()
    {
        // Arrange
        DateTime epiphanyAfter1984 = new(1985, 1, 6);

        // Act
        bool result = epiphanyAfter1984.IsEpiphany();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEpiphany_ShouldReturnFalseForNonJanuary6th()
    {
        // Arrange
        DateTime nonEpiphanyDate = new(2022, 3, 15);

        // Act
        bool result = nonEpiphanyDate.IsEpiphany();

        // Assert
        Assert.False(result);
    }

    #endregion

    #region March's

    [Fact]
    public void IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated_ShouldReturnTrueForMarch17th1961()
    {
        // Arrange
        DateTime anniversaryDate = new(1961, 3, 17);

        // Act
        bool result = anniversaryDate.IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated_ShouldReturnTrueForMarch17th2011()
    {
        // Arrange
        DateTime anniversaryDate = new(2011, 3, 17);

        // Act
        bool result = anniversaryDate.IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated_ShouldReturnFalseForNonMarch17th()
    {
        // Arrange
        DateTime nonAnniversaryDate = new(2022, 5, 20);

        // Act
        bool result = nonAnniversaryDate.IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated_ShouldReturnFalseForMarch17thBefore1961()
    {
        // Arrange
        DateTime nonAnniversaryDate = new(1950, 3, 17);

        // Act
        bool result = nonAnniversaryDate.IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated_ShouldReturnFalseForNon50thAnniversary()
    {
        // Arrange
        DateTime nonAnniversaryDate = new(2010, 3, 17);

        // Act
        bool result = nonAnniversaryDate.IsAnniversaryOfTheUnificationOfItalyDayOfficiallyCelebrated();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSaintJosephsDay_ShouldReturnTrueForMarch19thBefore1977()
    {
        // Arrange
        DateTime saintJosephsDayBefore1977 = new(1976, 3, 19);

        // Act
        bool result = saintJosephsDayBefore1977.IsSaintJosephsDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsSaintJosephsDay_ShouldReturnFalseForNonMarch19th()
    {
        // Arrange
        DateTime nonSaintJosephsDay = new(2022, 5, 20);

        // Act
        bool result = nonSaintJosephsDay.IsSaintJosephsDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSaintJosephsDay_ShouldReturnFalseForMarch19thAfter1977()
    {
        // Arrange
        DateTime saintJosephsDayAfter1977 = new(1980, 3, 19);

        // Act
        bool result = saintJosephsDayAfter1977.IsSaintJosephsDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSaintJosephsDay_ShouldReturnFalseForNon19thOfMonth()
    {
        // Arrange
        DateTime non19thDay = new(1975, 3, 20);

        // Act
        bool result = non19thDay.IsSaintJosephsDay();

        // Assert
        Assert.False(result);
    }

    #endregion

    #region April's

    [Fact]
    public void WasDuringRomeBirthday_ShouldReturnTrueForApril21st1924()
    {
        // Arrange
        DateTime romeBirthday1924 = new(1924, 4, 21);

        // Act
        bool result = romeBirthday1924.WasDuringRomeBirthday();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void WasDuringRomeBirthday_ShouldReturnTrueForApril21st1944()
    {
        // Arrange
        DateTime romeBirthday1944 = new(1944, 4, 21);

        // Act
        bool result = romeBirthday1944.WasDuringRomeBirthday();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void WasDuringRomeBirthday_ShouldReturnFalseForNonApril21st()
    {
        // Arrange
        DateTime nonRomeBirthday = new(1930, 5, 15);

        // Act
        bool result = nonRomeBirthday.WasDuringRomeBirthday();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void WasDuringRomeBirthday_ShouldReturnFalseForApril21stBefore1924()
    {
        // Arrange
        DateTime beforeRomeBirthday = new(1923, 4, 21);

        // Act
        bool result = beforeRomeBirthday.WasDuringRomeBirthday();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void WasDuringRomeBirthday_ShouldReturnFalseForApril21stAfter1944()
    {
        // Arrange
        DateTime afterRomeBirthday = new(1950, 4, 21);

        // Act
        bool result = afterRomeBirthday.WasDuringRomeBirthday();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsItalianLiberationDay_ShouldReturnTrueForApril25th1946()
    {
        // Arrange
        DateTime italianLiberationDay1946 = new(1946, 4, 25);

        // Act
        bool result = italianLiberationDay1946.IsItalianLiberationDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsItalianLiberationDay_ShouldReturnTrueForApril25th1950()
    {
        // Arrange
        DateTime italianLiberationDay1950 = new(1950, 4, 25);

        // Act
        bool result = italianLiberationDay1950.IsItalianLiberationDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsItalianLiberationDay_ShouldReturnFalseForNonApril25th()
    {
        // Arrange
        DateTime nonItalianLiberationDay = new(1960, 5, 20);

        // Act
        bool result = nonItalianLiberationDay.IsItalianLiberationDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsItalianLiberationDay_ShouldReturnFalseForApril25thBefore1945()
    {
        // Arrange
        DateTime beforeItalianLiberationDay = new(1944, 4, 25);

        // Act
        bool result = beforeItalianLiberationDay.IsItalianLiberationDay();

        // Assert
        Assert.False(result);
    }

    #endregion

    #region May's

    [Fact]
    public void IsLateModernPeriodWorkersDay_ShouldReturnTrueForMay1st1945()
    {
        // Arrange
        DateTime date = new(1945, 5, 1);

        // Act
        bool result = date.IsLateModernPeriodWorkersDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsLateModernPeriodWorkersDay_ShouldReturnTrueForMay1st1950()
    {
        // Arrange
        DateTime date = new(1950, 5, 1);

        // Act
        bool result = date.IsLateModernPeriodWorkersDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsLateModernPeriodWorkersDay_ShouldReturnFalseForNonMay1st()
    {
        // Arrange
        DateTime date = new(1960, 6, 15);

        // Act
        bool result = date.IsLateModernPeriodWorkersDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsLateModernPeriodWorkersDay_ShouldReturnFalseForMay1stBefore1945()
    {
        // Arrange
        DateTime date = new(1944, 5, 1);

        // Act
        bool result = date.IsLateModernPeriodWorkersDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsLateModernPeriodWorkersDay_ShouldReturnTrueForMay1stAfter1950()
    {
        // Arrange
        DateTime date = new(2024, 5, 1);

        // Act
        bool result = date.IsLateModernPeriodWorkersDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsWorkersDay_ShouldReturnTrueForMay1st1945()
    {
        // Arrange
        DateTime date = new(1945, 5, 1);

        // Act
        bool result = date.IsWorkersDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsWorkersDay_ShouldReturnTrueForMay1st1950()
    {
        // Arrange
        DateTime date = new(1950, 5, 1);

        // Act
        bool result = date.IsWorkersDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsWorkersDay_ShouldReturnTrueForApril21st1924()
    {
        // Arrange
        DateTime date = new(1924, 4, 21);

        // Act
        bool result = date.IsWorkersDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsWorkersDay_ShouldReturnFalseForNonWorkersDay()
    {
        // Arrange
        DateTime date = new(1960, 6, 15);

        // Act
        bool result = date.IsWorkersDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsWorkersDay_ShouldReturnFalseForBefore1890()
    {
        // Arrange
        DateTime date = new(1889, 5, 1);

        // Act
        bool result = date.IsWorkersDay();

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1945, 5, 1, true)]
    [InlineData(1950, 5, 1, true)]
    [InlineData(1924, 4, 21, true)]
    [InlineData(1960, 6, 15, false)]
    [InlineData(1880, 5, 1, false)]
    public void IsWorkersDay_ShouldReturnCorrectResult(int year, int month, int day, bool expected)
    {
        // Arrange
        DateTime date = new(year, month, day);

        // Act
        bool result = date.IsWorkersDay();

        // Assert
        Assert.Equal(expected, result);
    }

    #endregion

    #region June's

    [Fact]
    public void IsItalianRepublicDay_ShouldReturnTrueForJune2nd1947()
    {
        // Arrange
        DateTime date = new(1947, 6, 2);

        // Act
        bool result = date.IsItalianRepublicDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsItalianRepublicDay_ShouldReturnTrueForJune2nd1950()
    {
        // Arrange
        DateTime date = new(1950, 6, 2);

        // Act
        bool result = date.IsItalianRepublicDay();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsItalianRepublicDay_ShouldReturnFalseForNonJune2nd()
    {
        // Arrange
        DateTime date = new(1960, 7, 15);

        // Act
        bool result = date.IsItalianRepublicDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsItalianRepublicDay_ShouldReturnFalseForJune2ndBefore1946()
    {
        // Arrange
        DateTime date = new(1945, 6, 2);

        // Act
        bool result = date.IsItalianRepublicDay();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSaintsPeterAndPaulFeast_ShouldReturnTrueForJune29th1976()
    {
        // Arrange
        DateTime date = new(1976, 6, 29);

        // Act
        bool result = date.IsSaintsPeterAndPaulFeast();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsSaintsPeterAndPaulFeast_ShouldReturnFalseForNonJune29th()
    {
        // Arrange
        DateTime date = new(1960, 7, 15);

        // Act
        bool result = date.IsSaintsPeterAndPaulFeast();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSaintsPeterAndPaulFeast_ShouldReturnFalseForJune29thAfter1977()
    {
        // Arrange
        DateTime date = new(1980, 6, 29);

        // Act
        bool result = date.IsSaintsPeterAndPaulFeast();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSaintsPeterAndPaulFeast_ShouldReturnTrueForJune29thBefore1977()
    {
        // Arrange
        DateTime date = new(1975, 6, 29);

        // Act
        bool result = date.IsSaintsPeterAndPaulFeast();

        // Assert
        Assert.True(result);
    }

    #endregion

    #region August's

    [Theory]
    [InlineData(2021, 8, 15, true)] // Assumption of Mary Day
    [InlineData(1990, 8, 15, true)] // Assumption of Mary Day
    [InlineData(2022, 8, 15, true)] // Assumption of Mary Day
    [InlineData(1980, 7, 15, false)] // Non-August 15th
    [InlineData(1975, 8, 14, false)] // Non-August 15th
    [InlineData(2023, 8, 16, false)] // Non-August 15th
    public void IsAssumptionOfMaryDay_ShouldReturnCorrectResult(int year, int month, int day, bool expected)
    {
        // Arrange
        DateTime date = new(year, month, day);

        // Act
        bool result = date.IsAssumptionOfMaryDay();

        // Assert
        Assert.Equal(expected, result);
    }

    #endregion

    #region November's

    [Theory]
    [InlineData(2021, 11, 1, true)] // All Saints' Day
    [InlineData(1990, 11, 1, true)] // All Saints' Day
    [InlineData(2022, 11, 1, true)] // All Saints' Day
    [InlineData(1980, 10, 31, false)] // Non-November 1st
    [InlineData(1975, 11, 2, false)] // Non-November 1st
    [InlineData(2023, 11, 3, false)] // Non-November 1st
    public void IsAllSaintsDay_ShouldReturnCorrectResult(int year, int month, int day, bool expected)
    {
        // Arrange
        DateTime date = new(year, month, day);

        // Act
        bool result = date.IsAllSaintsDay();

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1945, 11, 4, true)] // Italian National Unity and Armed Forces Day
    [InlineData(1976, 11, 4, true)] // Italian National Unity and Armed Forces Day
    [InlineData(1977, 11, 4, false)] // No-holiday in 1977
    [InlineData(1980, 11, 3, false)] // Non-November 4th
    [InlineData(1975, 11, 5, false)] // Non-November 4th
    [InlineData(2023, 11, 4, false)] // No-holiday from 1977
    public void IsItalianNationalUnityAndArmedForcesDay_ShouldReturnCorrectResult(int year, int month, int day, bool expected)
    {
        // Arrange
        DateTime date = new(year, month, day);

        // Act
        bool result = date.IsItalianNationalUnityAndArmedForcesDay();

        // Assert
        Assert.Equal(expected, result);
    }

    #endregion

    #region Winter holidays' season

    [Theory]
    [InlineData(2021, 12, 8, true)] // Immaculate Conception Day
    [InlineData(1990, 12, 8, true)] // Immaculate Conception Day
    [InlineData(2022, 12, 8, true)] // Immaculate Conception Day
    [InlineData(1980, 12, 7, false)] // Non-December 8th
    [InlineData(1975, 12, 9, false)] // Non-December 8th
    [InlineData(2023, 12, 10, false)] // Non-December 8th
    public void IsImmaculateConceptionDay_ShouldReturnCorrectResult(int year, int month, int day, bool expected)
    {
        // Arrange
        DateTime date = new(year, month, day);

        // Act
        bool result = date.IsImmaculateConceptionDay();

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2021, 12, 25, true)] // Christmas
    [InlineData(1990, 12, 25, true)] // Christmas
    [InlineData(2022, 12, 25, true)] // Christmas
    [InlineData(1980, 12, 24, false)] // Non-December 25th
    [InlineData(1975, 12, 26, false)] // Non-December 25th
    [InlineData(2023, 12, 27, false)] // Non-December 25th
    public void IsChristmas_ShouldReturnCorrectResult(int year, int month, int day, bool expected)
    {
        // Arrange
        DateTime date = new(year, month, day);

        // Act
        bool result = date.IsChristmas();

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2021, 12, 26, true)] // Saint Stephen's Day
    [InlineData(1990, 12, 26, true)] // Saint Stephen's Day
    [InlineData(2022, 12, 26, true)] // Saint Stephen's Day
    [InlineData(1980, 12, 25, false)] // Non-December 26th
    [InlineData(1975, 12, 27, false)] // Non-December 26th
    [InlineData(2023, 12, 28, false)] // Non-December 26th
    public void IsSaintStephensDay_ShouldReturnCorrectResult(int year, int month, int day, bool expected)
    {
        // Arrange
        DateTime date = new(year, month, day);

        // Act
        bool result = date.IsSaintStephensDay();

        // Assert
        Assert.Equal(expected, result);
    }

    #endregion
}
