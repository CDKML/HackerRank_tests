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
//     * Complete the 'flippingBits' function below.
//     *
//     * The function is expected to return a LONG_INTEGER.
//     * The function accepts LONG_INTEGER n as parameter.
//     */

//    public static long flippingBits(long n)
//    {
//        //bitwise complement operator approach
//        //return (uint) ~n;

//        //32 because we are dealing with 32 bit unsigned integers
//        for (int i = 0; i < 32; i++)
//        {
//            n ^= (1U << i); //shift by i each bit 1U as unsigned
//        }
//        return n;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//        Console.Write("q: ");

//        int q = Convert.ToInt32(Console.ReadLine().Trim());

//        for (int qItr = 0; qItr < q; qItr++)
//        {
//            Console.Write("n: ");
//            long n = Convert.ToInt64(Console.ReadLine().Trim());

//            long result = Result.flippingBits(n);

//            Console.WriteLine(result);
//            //textWriter.WriteLine(result);
//        }

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}
