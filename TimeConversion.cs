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
//     * Complete the 'timeConversion' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts STRING s as parameter.
//     */

//    public static string timeConversion(string s)
//    {
//        string militaryTime;
//        if (s.EndsWith("AM"))
//        {
//            if(Int32.Parse(s.Substring(0, 2)) == 12)
//            {
//                militaryTime = "00" + s.Trim(new Char[] { 'A', 'M' }).Substring(2);
//            }
//            else
//            {
//                militaryTime = s.Trim(new Char[] { 'A', 'M' });
//            }
//        }
//        else
//        {
//            if (Int32.Parse(s.Substring(0, 2)) == 12)
//            {
//                militaryTime = "12" + s.Trim(new Char[] { 'P', 'M' }).Substring(2);
//            }
//            else
//            {
//                int hour = Int32.Parse(s.Substring(0, 2)) + 12;
//                militaryTime = hour + s.Trim(new Char[] { 'P', 'M' }).Substring(2);
//            }
//        }
//        return militaryTime;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s = Console.ReadLine();

//        string result = Result.timeConversion(s);
//        Console.WriteLine(result);
//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}