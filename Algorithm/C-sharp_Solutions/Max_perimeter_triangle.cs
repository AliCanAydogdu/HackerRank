using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var l = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long maxPer = -1;
            long a = -1;
            long b = -1;
            long c = -1;

            for (int i = 0; i <= n - 3; i++)
                for (int j = i + 1; j <= n - 2; j++)
                    for (int k = j + 1; k <= n - 1; k++)
                        if (l[i] + l[j] + l[k] > maxPer && l[i] + l[j] > l[k] && l[i] + l[k] > l[j] && l[k] + l[j] > l[i])
                        {
                            maxPer = l[i] + l[j] + l[k];
                            a = l[i];
                            b = l[j];
                            c = l[k];
                        }

            if (maxPer == -1)
                Console.WriteLine(-1);
            else
            {
                var list = new List<long>();
                list.Add(a);
                list.Add(b);
                list.Add(c);

                list.Sort();

                Console.WriteLine("{0} {1} {2}", list[0], list[1], list[2]);
            }
        }
    }
}
