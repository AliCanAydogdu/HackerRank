import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int arr[] = new int[n];
        double a = 0;
        double b = 0;
        double c = 0;

        for(int arr_i=0; arr_i < n; arr_i++){
            arr[arr_i] = in.nextInt();

        if (arr[arr_i]>0){a++;}
        else if (arr[arr_i]<0){b++;}
        else if (arr[arr_i]==0){c++;}

    }
        System.out.println(a/n);
        System.out.println(b/n);
        System.out.println(c/n);
}



    }
