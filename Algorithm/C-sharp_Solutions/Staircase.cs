using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string inputHeight = Console.ReadLine();
        int height = Convert.ToInt32(inputHeight);
        int curLevel = height-1;
        int i;

        while(curLevel >= 0){
            i = 0;
            while(i < curLevel)
            {
                Console.Write(" ");
                i++;
            }

            while(i < height)
            {
                Console.Write("#");
                i++;
            }

            Console.Write("\n");
            curLevel--;

        }

    }
}
