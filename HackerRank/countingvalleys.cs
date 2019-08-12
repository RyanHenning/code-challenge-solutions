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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int currentLevel = 0;
        int numberOfValleys = 0;
        foreach (char c in s)
        {
            int previousLevel = currentLevel;
            switch(c)
            {
                case 'U':
                    currentLevel++;
                    break;
                case 'D':
                    currentLevel--;
                    break;
                default:
                    throw new ArgumentException(
                        "input string can only contain U or D!"
                        );
                    break;
            }
            
            if (previousLevel < 0 && currentLevel >= 0)
            {
                numberOfValleys++;
            }
        }

        return numberOfValleys;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
