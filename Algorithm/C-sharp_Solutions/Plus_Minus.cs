using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string firstLine = Console.ReadLine();
      int length = Convert.ToInt32(firstLine);
      string nextLine = Console.ReadLine();
      string[] brokenLine = nextLine.Split(new char[] { ' ' });
      int positiveCount = 0;
      int negativeCount = 0;
      int zero = 0;
      for (int i = 0; i < length; i++)
      {
        if (Convert.ToInt32(brokenLine[i]) > 0)
        {
          positiveCount++;
        }
        else if (Convert.ToInt32(brokenLine[i]) < 0)
        {
          negativeCount++;
        }
        else
        {
          zero++;
        }
      }
      Console.WriteLine(Math.Round((double)positiveCount / length, 3));
      Console.WriteLine(Math.Round((double)negativeCount / length, 3));
      Console.WriteLine(Math.Round((double)zero / length, 3));
    }
}
