using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Text;

namespace MyBenchmarks
{
    public class Program
    {
        static readonly Stopwatch timer = new Stopwatch();

        static async Task Main()
        {
            //var rtf = new ReadTextFile();
            //timer.Start();

            //Console.WriteLine("Program Start - " + timer.Elapsed.ToString());

            ////rtf.ReadTextSynchronouslyFromExternalDrive();
            ////Console.WriteLine("Sychronous read - " + timer.Elapsed.ToString());

            //await rtf.ReadTextAsynchronouslyFromExternalDrive();
            //Console.WriteLine("Sychronous read - " + timer.Elapsed.ToString());
            ////await rtf.ReadTextAsyncFromExternalDrive();

            //timer.Stop();

            var summary = BenchmarkRunner.Run<ReadTextFile>();
        }
    }

    public class ReadTextFile
    {
        [Benchmark(Baseline = true)]
        public void SynchronousRead() => ReadTextSynchronouslyFromExternalDrive();

        [Benchmark]
        public void AsynchronousRead() => ReadTextAsynchronouslyFromExternalDrive();

        //[Benchmark]
        //public void AsynchronousRead() => ReadTextAsyncFromExternalDrive();

        public void ReadTextSynchronouslyFromExternalDrive()
        {
            string path = @"D:\IQFeedData\Trades\DailyFiles\";
            //string path = @"C:\Users\User\Documents\";
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

            Console.WriteLine(String.Format("Lines read snyc: {0:n0}", lngCurrNumRows));
        }

        public async Task ReadTextAsynchronouslyFromExternalDrive()
        {
            string path = @"D:\IQFeedData\Trades\DailyFiles\";
            //string path = @"C:\Users\User\Documents\";
            string fileName = "SPY_20220124.csv";
            string strDataLine;
            long lngCurrNumRows = 0;

            StreamReader srStreamRdr = new StreamReader(path+fileName);

            Task<string> line;
            while (await (line = srStreamRdr.ReadLineAsync()) != null)
            {
                //Console.WriteLine(line.Result);
                lngCurrNumRows++;
            }

            Console.WriteLine(String.Format("Lines read: {0:n0}", lngCurrNumRows));
        }

        //public async Task ReadTextAsyncFromExternalDrive()
        //{
        //    string path = @"D:\IQFeedData\Trades\DailyFiles\";
        //    string fileName = "SPY_20220124.csv";
        //    string strDataLine;
        //    long lngCurrNumRows = 0;

        //    using var sourceStream =
        //        new FileStream(
        //            path+fileName,
        //            FileMode.Open, FileAccess.Read, FileShare.Read,
        //            bufferSize: 4096, useAsync: true);

        //    var sb = new StringBuilder();

        //    byte[] buffer = new byte[0x1000];
        //    int numRead;
        //    while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
        //    {
        //        string text = Encoding.Unicode.GetString(buffer, 0, numRead);
        //        lngCurrNumRows++;
        //    }

        //    Console.WriteLine(String.Format("Lines read async: {0:n0}", lngCurrNumRows));
        //}
    }
}
