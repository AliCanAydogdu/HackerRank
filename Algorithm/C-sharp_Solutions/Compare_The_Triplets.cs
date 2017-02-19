using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);

        int alice = 0;
        int bob = 0;
        if(a0 > b0)
        {
            alice++;
        }

        if(a0 < b0)
        {
            bob++;
        }

        if(a1 > b1)
        {
            alice++;
        }

        if(a1 < b1)
        {
            bob++;
        }

        if(a2 > b2)
        {
            alice++;
        }

        if(a2 < b2)
        {
            bob++;
        }

        Console.WriteLine(alice + " " + bob);
    }
}
