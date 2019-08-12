using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int i2;
        double d2;
        string s2;
        // Read and save an integer, double, and String to your variables.
        Int32.TryParse(Console.ReadLine(), out i2);
        Double.TryParse(Console.ReadLine(), out d2);
        s2 = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + i2);
        // Print the sum of the double variables on a new line.
        Console.WriteLine((d + d2).ToString("F1"));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + s2);
        // The 's' variable above should be printed first.
    }
}