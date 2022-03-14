﻿using System.CodeDom.Compiler;
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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int diagonalDifferenceO_N_Square(List<List<int>> arr)
    {
        int leftDiagonal = 0;
        int rightDiagonal = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                Console.Write("i = " + i + ", j = " + j + " ");

                if (i == j)
                {
                    Console.Write("LD add: " + arr[i][j]);
                    leftDiagonal += arr[i][j];
                }
                if (i + j == arr.Count - 1)
                {
                    Console.Write("RD add: " + arr[i][j]);
                    rightDiagonal += arr[i][j];
                }
                Console.WriteLine();
            }

        }
        Console.WriteLine("LD: " + leftDiagonal + " RD: " + rightDiagonal);

        return Math.Abs(leftDiagonal - rightDiagonal);
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int leftDiagonal = 0;
        int rightDiagonal = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            leftDiagonal += arr[i][i];
        }

        for (int j = 0; j < arr.Count; j++)
        {
            rightDiagonal += arr[j][arr.Count - 1 - j];
        }

        return Math.Abs(leftDiagonal - rightDiagonal);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}