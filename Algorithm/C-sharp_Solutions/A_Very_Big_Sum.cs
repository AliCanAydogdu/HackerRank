
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] array = Console.ReadLine().Split(' ');
        double sum = 0;

        for (int i = 0; i < N; i++)
            sum += Convert.ToInt32(array[i]);

        Console.WriteLine(sum);
    }
}
