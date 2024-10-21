public class SevenSegmentReader
{
    private static readonly Dictionary<string, int> _segmentToNumber = new()
    {
        {SevenSegmentConstants.Zero, 0},
        {SevenSegmentConstants.One, 1},
        {SevenSegmentConstants.Two, 2},
        {SevenSegmentConstants.Three, 3},
        {SevenSegmentConstants.Four, 4},
        {SevenSegmentConstants.Five, 5},
        {SevenSegmentConstants.Six, 6},
        {SevenSegmentConstants.Seven, 7},
        {SevenSegmentConstants.Eight, 8},
        {SevenSegmentConstants.Nine, 9}
    };

    private static readonly Dictionary<int, string> _numberToSegment = _segmentToNumber.ToDictionary(x => x.Value, x => x.Key);

    public static int ConvertToNumber(string segmentData)
    {
        var isNullOrEmpty = string.IsNullOrEmpty(segmentData);
        var containsInvalidCharacters = !segmentData.All(c => c == '0' || c == '1');
        var isInvalidLength = segmentData.Length != 7;

        if (isNullOrEmpty || isInvalidLength || containsInvalidCharacters)
        {
            throw new ArgumentException("please add a 7-character string containing only 0s and 1s, invalid segment data");
        }

        if (_segmentToNumber.TryGetValue(segmentData, out int number))
        {
            return number;
        }
        else
        {
            throw new ArgumentException("no matching number found, invalid segment data.");
        }
    }

    public static string ConvertToSegmentData(int number)
    {
        if (number < 0 || number > 9)
        {
            throw new ArgumentException("number must be between 0 and 9.");
        }
        return _numberToSegment[number];
    }
}
