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

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr)
    {
        //copy array elements to list
        List<int> list = arr.ToList();

        List<int> list2 = new List<int>();

        int sticks_cut = 0;

        while(list.Count > 0)
        {
            sticks_cut = list.Count;
            list2.Add(sticks_cut);
            Console.WriteLine(sticks_cut);

            //finding lowest_length
            int lowest_length = list.Min();

            //remove lowest lengths
            for(int j = 0; j < list.Count; j++)
            {
                if(list[j] == lowest_length)
                {
                    list.RemoveAll(x=> x == lowest_length);
                }
            }

            //cut sticks
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] - lowest_length;
            }
        }

        int[] array = list2.ToArray();

        return array;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
