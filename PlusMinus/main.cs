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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal positives = 0;
        decimal negatives = 0;
        decimal zeros =0;
        decimal length = arr.Length;
        
        for(int i=0; i<length; i++;)
        {
            if(arr[i]<0)
            {
                negatives++;
            } 
            else if
            {
                positives;   
            }
            else
            {
                zeros;    
            }
        }
        
        Cosole.WritLine($"(positives / length:F6));
        Cosole.WritLine($"(negatives / length:F6)");
        Cosole.WritLine($"(zeros / length:F6)");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
