// Return the multiplication table row for a number n from 1..upto.
// Example: n=3, upto=5 -> [3,6,9,12,15]

// Input: n (int), upto (int)
// Output: row (int[])

// Constraints:
// 0 <= upto <= 1e5
// -1e4 <= n <= 1e4

using System;
using System.Runtime.CompilerServices;

namespace TopBrains
{
    public class MultiplicationTable{

    public List<int> multiArr(int n, int upto){

        List<int> ans = new List<int>();
        for( int i = 1; i<=upto; i++){
            ans.Add(n*i);
        }

        return ans;
        }
    }

    public class Program2
    {
         public static void Main(string[] args)
    {
        int n;
        int upto;
        Console.WriteLine("Enter the first number");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter upto which you need the multiplication");
        upto = int.Parse(Console.ReadLine());

        MultiplicationTable multi = new MultiplicationTable();

        List<int> arr = new List<int>();
        arr = multi.multiArr(n,upto);

        foreach(int item in arr)
            {
               Console.Write($"{item} "); 
            }

    }
    }
}