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
//     * Complete the 'pangrams' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts STRING s as parameter.
//     */

//    public static string pangrams(string s)
//    {
//        var pangram = new Dictionary<char, int>();
//        foreach (char c in s)
//        {
//            Console.Write(" " + c);
//            if (c != ' ' && pangram.ContainsKey(char.ToUpperInvariant(c)))
//            {
//                Console.Write(" add 1");
//                pangram[char.ToUpperInvariant(c)]++;
//            }
//            else if (c != ' ')
//            {
//                Console.Write(" add new");
//                pangram.Add(char.ToUpperInvariant(c), 1);
//            }
//        }
//        if (pangram.Count == 26)
//        {
//            return "pangram";
//        }
//        return "not pangram";
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s = Console.ReadLine();

//        string result = Result.pangrams(s);

//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}
