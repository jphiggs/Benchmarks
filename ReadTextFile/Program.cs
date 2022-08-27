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
        public void Result() => ReadTextSynchronouslyFromExternalDrive();

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

    
        //private static void ReadTextAsynchronouslyFromExternalDrive(string file)
        //{

        //}

        //private static void ReadTextUsingPipelineFromExternalDrive(string file)
        //{

        //}

//using System;
//using System.Security.Cryptography;
//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//namespace MyBenchmarks
//{
//    public class Md5VsSha256
//    {
//        private const int N = 10000;
//        private readonly byte[] data;

//        private readonly SHA256 sha256 = SHA256.Create();
//        private readonly MD5 md5 = MD5.Create();

//        public Md5VsSha256()
//        {
//            data = new byte[N];
//            new Random(42).NextBytes(data);
//        }

//        [Benchmark]
//        public byte[] Sha256() => sha256.ComputeHash(data);

//        [Benchmark]
//        public byte[] Md5() => md5.ComputeHash(data);
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var summary = BenchmarkRunner.Run<Md5VsSha256>();
//        }
//    }
//}