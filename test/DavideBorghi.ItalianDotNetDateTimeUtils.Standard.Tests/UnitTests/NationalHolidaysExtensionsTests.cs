namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard.Tests.UnitTests;

public class NationalHolidaysExtensionsTests
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
}
