using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

        string[] input=Console.ReadLine().Split(' ');

        int N=Convert.ToInt32(input[0]);
        int K=Convert.ToInt32(input[1]);
        int Q=Convert.ToInt32(input[2]);

        input=Console.ReadLine().Split(' ');

        int[] apple=new int[N];

        for (int i=0;i<N;i++){
            apple[i]=Convert.ToInt32(input[i]);
        }

        for (int i=0;i<Q;i++){
            int x=Convert.ToInt32(Console.ReadLine());

            int banana=x-K;

            while (banana<0){
                banana+=N;
            }

            Console.WriteLine(apple[banana]);
        }
    }
}
