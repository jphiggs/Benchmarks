using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ReadTextFile>();
        }
    }

    public class ReadTextFile
    {
        [Benchmark]
        public void SynchronousRead() => ReadTextSynchronouslyFromExternalDrive();

        private void ReadTextSynchronouslyFromExternalDrive()
        {
            string path = @"D:\IQFeedData\Trades\DailyFiles\";
            string fileName = "SPY_20220124.csv";
            string strDataLine;
            long lngCurrNumRows = 0;

            using (StreamReader srStreamRdr = new StreamReader(path+fileName))
            {
                while ((strDataLine = srStreamRdr.ReadLine()) != null)
                {
                    lngCurrNumRows++;
                }
            }

            Console.WriteLine(String.Format("Lines read: {0:n0}", lngCurrNumRows));
        }
    }
}
