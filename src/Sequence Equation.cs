using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the permutationEquation function below.
    static int[] permutationEquation(int[] p)
    {
        int[] indexes = new int[p.Length];

        int[] pNums = new int[p.Length];
        for(int i = 0; i < p.Length; i++)
        {
            pNums[i] = p[i];
        }

        Array.Sort(pNums);
        int[] nums = new int[p.Length];
        int count = 0;
        for(int j = 0; j < p.Length; j++)
        {
            for(int x = 0; x < p.Length; x++)
            {
                if(pNums[j] == p[x])
                {
                    nums[count] = pNums[x];
                    count = count + 1;
                }
            }
        }

        int[] ans = new int[p.Length];
        int count2 = 0;
        for(int z = 0; z < p.Length; z++)
        {
            for(int h = 0; h < p.Length; h++)
            {
                if(nums[z] == p[h])
                {
                    ans[count2] = h+1;
                    count2 = count2 + 1;
                }   
            }
        }

        return ans;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
        ;
        int[] result = permutationEquation(p);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
