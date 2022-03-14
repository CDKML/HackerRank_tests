//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Result
//{

//    /*
//     * Complete the 'matchingStrings' function below.
//     *
//     * The function is expected to return an INTEGER_ARRAY.
//     * The function accepts following parameters:
//     *  1. STRING_ARRAY strings
//     *  2. STRING_ARRAY queries
//     */

//    public static List<int> matchingStrings(List<string> strings, List<string> queries)
//    {
//        IDictionary<string, int> matching = new Dictionary<string, int>();
//        List<int> occurrences = new List<int>();
//        foreach (var str in strings)
//        {
//            if(matching.ContainsKey(str))
//                matching[str] += 1;
//            else
//            {
//                matching.Add(str, 1);
//            }
//        }

//        foreach (var qry in queries)
//        {
//            if (matching.ContainsKey(qry))
//                occurrences.Add(matching[qry]);
//            else
//            {
//                occurrences.Add(0);
//            }
//        }
//        return occurrences;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//        Console.WriteLine("Strings Count");

//        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<string> strings = new List<string>();

//        Console.WriteLine("Strings:");

//        for (int i = 0; i < stringsCount; i++)
//        {
//            string stringsItem = Console.ReadLine();
//            strings.Add(stringsItem);
//        }

//        Console.WriteLine("Queries Count");

//        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<string> queries = new List<string>();

//        Console.WriteLine("Queries:");

//        for (int i = 0; i < queriesCount; i++)
//        {
//            string queriesItem = Console.ReadLine();
//            queries.Add(queriesItem);
//        }

//        List<int> res = Result.matchingStrings(strings, queries);
//        Console.WriteLine(String.Join("\n", res));
//        //textWriter.WriteLine(String.Join("\n", res));

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}