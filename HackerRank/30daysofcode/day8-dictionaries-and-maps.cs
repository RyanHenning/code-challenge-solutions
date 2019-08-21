using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            string name = input.Substring(0, input.IndexOf(" "));
            string number = input.Substring(input.IndexOf(" ")+1, input.Length - input.IndexOf(" ")-1);
            phoneBook.Add(name, number);
        }

        do
        {
            string query = Console.ReadLine();

            if (query == null)
            {
                break;
            }

            string number = string.Empty;

            if (!phoneBook.ContainsKey(query))
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"{query}={phoneBook[query]}");
            }
        } while(true);
    }
}