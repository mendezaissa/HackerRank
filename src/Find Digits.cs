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

    // Complete the findDigits function below.
    static int findDigits(int n)
    {
        int original = n;
        List<int> intList = new List<int>();
        int num = 0;
        int count = 0;
        while(n != 0)
        {
            num = n % 10;
            intList.Add(num);
            n = n / 10;
        }

        foreach(int item in intList)
        {
            if(item > 0)
            {
                if(original % item == 0)
                {
                    count = count + 1;
                }
            }
        }
        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
