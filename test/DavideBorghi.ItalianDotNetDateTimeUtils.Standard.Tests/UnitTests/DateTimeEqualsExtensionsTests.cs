namespace DavideBorghi.ItalianDotNetDateTimeUtils.Standard.Tests.UnitTests;

public sealed class DateTimeEqualsExtensionsTests
{
    #region Equals
    
    [Fact]
    public void EqualsByDate_ReturnsTrueForEqualDates()
    {
        // Arrange
        DateTime firstDate = new(2022, 1, 15);
        DateTime secondDate = new(2022, 1, 15);

        // Act
        bool result = firstDate.EqualsByDate(secondDate);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void EqualsByDate_ReturnsFalseForDifferentDates()
    {
        // Arrange
        DateTime firstDate = new(2022, 1, 15);
        DateTime secondDate = new(2023, 1, 15);

        // Act
        bool result = firstDate.EqualsByDate(secondDate);

        // Assert
        Assert.False(result);
    }

    #endregion
}
