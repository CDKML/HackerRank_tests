using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        var dict = new Dictionary<int, int>();
        foreach (int integer in a)
        {
            if (dict.ContainsKey(integer))
            {
                dict[integer]++;
            }
            else
            {
                dict.Add(integer, 1);
            }
        }

        return dict.FirstOrDefault(x => x.Value == 1).Key;
    }

    //XOR Approach (Bit manipulation)
    public static int lonelyintegerXOR(List<int> a)
    {
        //Since we've been assured all elements but one occur twice and 0 <= a[i] <= 100, 
        //we can use XOR bit manipulation, as all the even values will cancel out except 
        //the lonely integer with the XOR operation.
        int result = 0;
        foreach (int integer in a)
        {
            result ^= integer;
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        Console.Write("N: ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.Write("List: ");

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        //int result = Result.lonelyinteger(a);
        int result = Result.lonelyintegerXOR(a);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}