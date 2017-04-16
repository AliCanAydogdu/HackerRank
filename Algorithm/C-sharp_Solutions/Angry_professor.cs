using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
#if DEBUG
        Console.SetIn(new StreamReader("problem1_input1.txt"));
#endif

        int T = int.Parse(Console.ReadLine());

        var results = new bool[T];

        for(int i = 0; i < T; i++)
        {
            var firstLine = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var secondLine = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            results[i] = Solve(firstLine[0], firstLine[1], secondLine);
        }

        for (int i = 0; i < T; i++)
            Console.WriteLine(results[i] ? "YES" : "NO");
    }

    static bool Solve(int n, int k, int[] enter)
    {
        return enter.Where(x => x <= 0).Count() < k;
    }
}
