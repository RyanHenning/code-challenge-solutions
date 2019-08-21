using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        string [] S = new string[n];

        for (int i = 0; i < S.Length; i++)
        {
            S[i] = Console.ReadLine();
        }

        foreach (string str in S)
        {
            string oddLetters = string.Empty;
            string evenLetters = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 1)
                {
                    oddLetters = oddLetters + str[i];
                }
                else
                {
                    evenLetters = evenLetters + str[i];
                }
            }

            Console.WriteLine($"{evenLetters} {oddLetters}");
        }
    }
}

