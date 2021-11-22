using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз
{
    class Program

    {
        static void PrintArray(int [] myArray, int  i =0)
        {
            if ( i< myArray.Length)
            {
                Console.WriteLine(myArray[i] );
                PrintArray(myArray, i+1);
            }
            
        }


        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 3 };

            PrintArray(myArray);

            //StringConversion();
            //StringBuilderDemo();
            //WorkingWithArrays();
            //PadAndTrim();
            //SearchingStrings();
            


        }


        private static void StringConversion()
        {
            string testString = "tHis iS tHe FBI Calling!";
            string result;

            result = testString.ToLower();

            Console.WriteLine(result);

            result = testString.ToUpper();

            Console.WriteLine(result);

        }

        private static void StringBuilderDemo()
        {
            //Stopwatch regularStopwatch = new Stopwatch();
           // regularStopwatch.Start();

            string test = "";

            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }

           // regularStopwatch.Stop();
           // Console.WriteLine($"Regular Stopwatch: {regularStopwatch.ElapsedMilliseconds} ms ");
        }

        private static void WorkingWithArrays()
        {
            int[] ages = new int[] {6,7,3,5,8 };
            string results;

            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join(",", ages);
            Console.WriteLine(results);

            string testString = "Jon,Tim,Sue,Bob";
            string[] resultsArray = testString.Split(',');

            Array.ForEach(resultsArray, x => Console.WriteLine(x));

            testString = "Jon, Tim, Sue, Bob";
            //resultsArray = testString.Split(", ");
            Array.ForEach(resultsArray, x => Console.WriteLine(x));
            }

        private static void PadAndTrim()
        {
            string testString = "         Hello World        ";
            string results;

            //results = testString.TrimStart($"'{results}'");
        }

        private static void SearchingStrings()
        {
            string testString = "This is a test of the search. Let's see how it's testing works out.";
            bool resultsBoolean;
            int resultsInt;

            resultsBoolean = testString.StartsWith("ThIs is");
            Console.WriteLine($"Starts with\"This is\":{resultsBoolean}");

            resultsBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Starts with\"THis is\":{resultsBoolean}");

            resultsBoolean = testString.EndsWith("works out.");
            Console.WriteLine($"Ends with\"works out.\":{resultsBoolean}");

            resultsBoolean = testString.EndsWith("work out.");
            Console.WriteLine($"Ends with\"work out.\":{resultsBoolean}");

            resultsBoolean = testString.Contains("test");
            Console.WriteLine($"Contains\"test\":{resultsBoolean}");

            resultsBoolean = testString.Contains("tests");
            Console.WriteLine($"Contains\"tests\":{resultsBoolean}");

            resultsInt = testString.IndexOf("test");
            Console.WriteLine($"Index of \"test\": {resultsInt}");

            resultsInt = testString.IndexOf("test", 49);
            Console.WriteLine($"Index of \"test\" after character 48: {resultsInt}"); 
        }

      
    }


}
