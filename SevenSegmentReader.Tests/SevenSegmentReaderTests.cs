public class SevenSegmentReaderTests
{
    [Theory]
    [InlineData(SevenSegmentConstants.Zero, 0)]
    [InlineData(SevenSegmentConstants.One, 1)]
    [InlineData(SevenSegmentConstants.Two, 2)]
    [InlineData(SevenSegmentConstants.Three, 3)]
    [InlineData(SevenSegmentConstants.Four, 4)]
    [InlineData(SevenSegmentConstants.Five, 5)]
    [InlineData(SevenSegmentConstants.Six, 6)]
    [InlineData(SevenSegmentConstants.Seven, 7)]
    [InlineData(SevenSegmentConstants.Eight, 8)]
    [InlineData(SevenSegmentConstants.Nine, 9)]
    public void ConvertToNumber_ValidInput_ReturnsCorrectNumber(string input, int expected)
    {
        int result = SevenSegmentReader.ConvertToNumber(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("")]
    [InlineData("1234567")]
    [InlineData("11111111")]
    [InlineData("000000")]
    [InlineData("ABN AMRO")]
    public void ConvertToNumber_InvalidInput_ThrowsArgumentException(string input)
    {
        Assert.Throws<ArgumentException>(() => SevenSegmentReader.ConvertToNumber(input));
    }


    [Theory]
    [InlineData(0, SevenSegmentConstants.Zero)]
    [InlineData(1, SevenSegmentConstants.One)]
    [InlineData(2, SevenSegmentConstants.Two)]
    [InlineData(3, SevenSegmentConstants.Three)]
    [InlineData(4, SevenSegmentConstants.Four)]
    [InlineData(5, SevenSegmentConstants.Five)]
    [InlineData(6, SevenSegmentConstants.Six)]
    [InlineData(7, SevenSegmentConstants.Seven)]
    [InlineData(8, SevenSegmentConstants.Eight)]
    [InlineData(9, SevenSegmentConstants.Nine)]
    public void ConvertToSegmentData_ValidInput_ReturnsCorrectSegmentData(int input, string expected)
    {
        string result = SevenSegmentReader.ConvertToSegmentData(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(10)]
    [InlineData(100)]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void ConvertToSegmentData_InvalidInput_ThrowsArgumentException(int input)
    {
        Assert.Throws<ArgumentException>(() => SevenSegmentReader.ConvertToSegmentData(input));
    }

}