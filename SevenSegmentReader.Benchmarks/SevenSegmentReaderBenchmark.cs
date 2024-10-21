using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class SevenSegmentReaderBenchmarks
{
    private readonly string[] _segmentData =
        {
        SevenSegmentConstants.Zero,
        SevenSegmentConstants.One,
        SevenSegmentConstants.Two,
        SevenSegmentConstants.Three,
        SevenSegmentConstants.Four,
        SevenSegmentConstants.Five,
        SevenSegmentConstants.Six,
        SevenSegmentConstants.Seven,
        SevenSegmentConstants.Eight,
        SevenSegmentConstants.Nine
        };

        [Benchmark]
        public void BenchmarkConvertToNumber()
        {
            foreach (var data in _segmentData)
            {
                SevenSegmentReader.ConvertToNumber(data);
            }
        }

        [Benchmark]
        public void BenchmarkConvertToSegmentData()
        {
            for (int i = 0; i < 10; i++)
            {
               SevenSegmentReader.ConvertToSegmentData(i);
            }
        }
}
