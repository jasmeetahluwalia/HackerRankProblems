using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayProblems;

namespace HackerRankInterviewPrepApp
{
    internal class Program
    {
        static string filePath = @"../../Result.txt";
        static List<int> learnerResult = new List<int>();

        static string[] test_dates = {
            "July 4, 1776",
            "12/25/2025",
            "April 1",
            "Not a date",
            "Feb 14, 2036",
            "1/2020",
            "Sat, 18 Aug 2018"
        };

        public static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //Program.plusMinus(arr);
            //Program.miniMaxSum(arr);
            //Program.timeConversion();
            //Program.matchinStrings();
            //Program.lonelyInteger();
            //Program.flippingBits();
            //object[] items = { 1, 2, "Hello!", "World", 'X', true, 2.0, ".NET", 'A' };
            //int total = 0;
            //string CountType = "System.String";
            //foreach (object item in items)
            //{
            //    if (Program.CountTheType(item, CountType))
            //    {
            //        total++;
            //    }
            //}
            foreach (string date in test_dates)
            {
                learnerResult.Add(CalcHowManyDays(date));
            }


        }

        public static void plusMinus(List<int> arr)
        {
            float positiveNum = arr.Where(x => x > 0).Count();
            float negativeNum = arr.Where(x => x < 0).Count();
            float zeroNum = arr.Where(x => x == 0).Count();
            float size = arr.Count();

            Console.WriteLine((positiveNum / size).ToString("N6"));
            Console.WriteLine((negativeNum / size).ToString("N6"));
            Console.WriteLine((zeroNum / size).ToString("N6"));
        }

        public static void miniMaxSum(List<int> arr)
        {
            long minVal = arr[0];
            long maxVal = arr[0];
            long totalsum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                totalsum += arr[i];
                if (i > 0)
                {
                    if (arr[i] < minVal)
                    {
                        minVal = arr[i];
                    }
                    if (arr[i] > maxVal)
                    {
                        maxVal = arr[i];
                    }
                }
            }

            long minSum = totalsum - maxVal;
            long maxSum = totalsum - minVal;

            //long maxVal = arr.Max();
            //long minVal = arr.Min();
            //long total = arr.Sum();
            //long maxSum = total - minVal;
            //long minSum = total - maxVal;
            //Console.WriteLine(minSum + " " + maxSum);

            Console.WriteLine(minSum + " " + maxSum);

        }

        public static void timeConversion()
        {
            string filePath = @"../../Result.txt";
            TextWriter textWriter = new StreamWriter(filePath, true);
            string s = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
            textWriter.WriteLine(dt.ToString("HH:mm:ss"));
            textWriter.Flush();
            textWriter.Close();
            File.WriteAllText(filePath, dt.ToString("HH:mm:ss"));

        }

        /// <summary>
        /// input : 4 aba baba aba xzxb 3 aba xzxb ab
        /// output: [2,1,0]
        /// </summary>
        /// <returns></returns>
        public static void matchinStrings()
        {
            
            TextWriter textWriter = new StreamWriter(filePath, true);

            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> result = new List<int>();
            foreach (string q in queries)
            {
                int sCount = strings.Where(x => x == q).Count();
                result.Add(sCount);
            }

            textWriter.WriteLine(String.Join(",", result));

            textWriter.Flush();
            textWriter.Close();


            Console.WriteLine(String.Join(",", result));


        }

        public static void lonelyInteger()
        {

            TextWriter textWriter = new StreamWriter(filePath, true);
                                                                            
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int unique = 0;//1 2 3 4 3 2 1
            foreach (int num in arr)
            {
                unique ^= num;
            }
            

            textWriter.WriteLine(unique);
            Console.WriteLine(unique);

            textWriter.Flush();
            textWriter.Close();
        }

        public static long flippingBits()
        {
            TextWriter textWriter = new StreamWriter(filePath, true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());
            long result = 0;
            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                 result = n ^ 0xFFFFFFFF;
                Console.WriteLine($"Original: {n}, Flipped: {result}");
                textWriter.WriteLine(result);
            }
            
            textWriter.Flush();
            textWriter.Close();
            return result;
        }

        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        public static bool CountTheType(object Arg, string TypeToCount)
        {
            // Your code goes here. Return true if the type of the Arg is the same
            // as what the TypeToCount parameter says to count.
            if (Arg.GetType() == TypeToCount.GetType())
            {
                return true;
            }
            return false;
        }

        public static int CalcHowManyDays(string date_str)
        {

            DateTime todaydate = DateTime.Now;
            DateTime result;
            int days = 0;
            if (DateTime.TryParse(date_str, out result))
            {
                TimeSpan interval = todaydate - result;
                Console.WriteLine(interval);
                days = interval.Days;
            }
            else
            {
                days = 0;
            }
            return days;
        }

       
    }
}
