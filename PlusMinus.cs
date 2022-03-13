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
//     * Complete the 'plusMinus' function below.
//     *
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */
//    public Dictionary<string, int> ratios = new Dictionary<string, int>();

       
//    public void plusMinus(List<int> arr)
//    {
//        foreach (int element in arr)
//        {
//            if (element > 0)
//            {
//                ratios["Positive"] += 1;
//            }
//            else if (element < 0)
//            {
//                ratios["Negative"] += 1;
//            }
//            else
//            {
//                ratios["Zero"] += 1;
//            }
//        }

//        double ratio = ratios["Positive"] * 1.0f / arr.Count;
//        string posit = ratio.ToString("0.000000");
//        ratio = ratios["Negative"] * 1.0f / arr.Count;
//        string negat = ratio.ToString("0.000000");
//        ratio = ratios["Zero"] * 1.0f / arr.Count;
//        string zero = ratio.ToString("0.000000");

//        Console.WriteLine(posit);
//        Console.WriteLine(negat);
//        Console.WriteLine(zero);

//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());
//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//        Result r = new Result();
//        r.ratios["Positive"] = 0;
//        r.ratios["Negative"] = 0;
//        r.ratios["Zero"] = 0;
//        r.plusMinus(arr);
//        Console.ReadKey();
//    }
//}