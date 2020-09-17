xusing System.CodeDom.Compiler;
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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int pairs=0;
       int counter = 0;
        int count = 0;
        //
        for (int i = 0; i < n; i++) {
            count = 1;
            //
            for (int j = i + 1; j < n; j++) {
                if (ar[i] == ar[j]) {
                    count++;
                }
            }

            if (count % 2 == 0) {
                counter++;
            }
        }

        return counter;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
