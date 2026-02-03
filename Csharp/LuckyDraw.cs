// Question
// 1
// Programming
// Description
// In a lucky draw, contestants with ticket numbers having a special property are chosen as Lucky Winners.

// Let S(n) be the sum of the digits of n. Example:
// S(484) = 4 + 8 + 4 = 16
// S(22) = 2 + 2 = 4
// A non-prime positive integer x is called a Lucky Number if:
// S(x × x) = S(x) × S(x)
// Example: 22 is a Lucky Number because:
// S(22) = 4
// S(484) = 16
// And 4 × 4 = 16 
// You must find how many Lucky Numbers lie between m and n (inclusive).
//  Sample Input 20 30
// Sample Output 4

// num = 22
// sumOfDigits = 2 + 2 = 4
// sumDigits ka square = 4 *4 = 16
// squareOfNum = 22 * 22 = 484
// squareofNum ka sumOfDigits = 4 + 8 + 4 = 16
// because SquareOfNum(sumOfDigits(num)) = sumOfDigits(SquareOfNum(num)) --> Lucky Number
using System;
namespace TopBrains
{
    public class LuckyNumber
    {
        public int sumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = (int)number / 10;
                // sum += number;
            }

            return sum;

        }

        public int squareOfNum(int number)
        {
            return number * number;
        }

        public bool isPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            int stop = (int)Math.Sqrt(number);
            for (int i = 3; i < stop; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isLucky(int number)
        {
            int squareOfSumOfDigits = squareOfNum(sumOfDigits(number));
            int sumOfDigitsOfSquareOfNum = sumOfDigits(squareOfNum(number));

            if (squareOfSumOfDigits == sumOfDigitsOfSquareOfNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    public class Program3
    {
        public static void Main(string[] args)
        {
            // int number;
            Console.WriteLine("Enter your ticket number");
            int StartNumber = int.Parse(Console.ReadLine());
            int EndNumber = int.Parse(Console.ReadLine());
            int count = 0;
            LuckyNumber luckyNumber = new LuckyNumber();

            for (int i = StartNumber; i <= EndNumber; i++)
            {
                if (i <= 0 || luckyNumber.isPrime(i))
                {
                    continue;
                }
                else if (luckyNumber.isLucky(i))
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}

