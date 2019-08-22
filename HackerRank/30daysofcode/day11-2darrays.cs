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

class Solution {

    static void maxHourGlassSum(int[][] arr)
    {
        List<int> sums = new List<int>();

        for (int i = 0; i < arr.Length-2; i++)
        {
            for (int j = 0; j < arr[0].Length-2; j++)
            {
                sums.Add(arr[i][j] + arr[i][j+1] + arr[i][j+2]
                                + arr[i+1][j+1] +
                          arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]);


            }
        }
        Console.WriteLine(sums.Max());
    }

    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        }

        maxHourGlassSum(arr);
    }
}
