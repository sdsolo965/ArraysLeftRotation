using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int[] b = RotateArray(a, k, n);
        foreach (var num in b) { Console.Write(num + " "); }
    }
    /*
     * Simple Array rotation algorithm, input takes number of left shifts
     * and takes the array inputs and output is the rotated array.
     */
    static int[] RotateArray(int[] a, int d, int n)
    {
        int[] b = a;
        for (int i = n - 1; i >= 0; i--)
        {
            if (i == n - 1) { b[i - d] = a[i]; }
            else {b[n - d] = a[i]; }
        }
        return b;
    }
}

