using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        var tmp = Console.ReadLine().Split(' ');
        int x1 = int.Parse(tmp[0]);
        int y1 = int.Parse(tmp[1]);
        int x2 = int.Parse(tmp[2]);
        int y2 = int.Parse(tmp[3]);

        float a1 = (float)(x1 - x2) / (float)(y2 - y1);
        if (a1 < 0 || a1 != Math.Floor(a1)) {
            Console.WriteLine("NO");
        } else {
            Console.WriteLine("YES");
        }
    }
}
