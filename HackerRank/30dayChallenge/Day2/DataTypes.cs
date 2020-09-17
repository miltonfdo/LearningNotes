using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


               int inputString ;
               float dInputString;
             
               
        // Declare second integer, double, and String variables.
        
        // Read and save an integer, double, and String to your variables.
        int.TryParse(Console.ReadLine(),out inputString); 
               float.TryParse(Console.ReadLine(),out dInputString); 
               string sInputString= Console.ReadLine();


               Console.WriteLine(inputString+i);
               Console.WriteLine(String.Format("{0:0.0}",(d+dInputString)));
               Console.WriteLine(s + sInputString);

        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}