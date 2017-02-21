using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        int FirstSum = 0;
        int SecondSum = 0;

        for(int i = 0; i<n; i++)
        {
            string elements = Console.ReadLine();
            string[] split_header = elements.Split(' ');

            int firstLineNumber = Convert.ToInt32(split_header[i]);
            FirstSum += firstLineNumber;

            int secondLineNumber = Convert.ToInt32(split_header[n-i-1]);
            SecondSum += secondLineNumber;

        }

        int result = Math.Abs(FirstSum - SecondSum);

        Console.WriteLine(result);


    }
}
