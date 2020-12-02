using System;
using System.IO;
using System.Numerics;

namespace AdventOfCode.DayOne
{
    public class ExpenseReport
    {

        private static string FilePath = "/home/stephen/programming/csharp/AdventOfCode/AdventOfCode/DayOne/input.txt";

        //https://adventofcode.com/2020/day/1
        public static int FindDouble()
        {
            const int target = 2020;
            var lines = File.ReadAllLines(FilePath);
            if (lines.Length == 0) return 0;

            foreach (var line in lines)
            {
                var num1 = int.Parse(line);

                foreach (var otherLine in lines)
                {
                    var num2 = int.Parse(otherLine);

                    if (num1 + num2 == target)
                    {
                        Console.Out.WriteLine($"we've hit our target ${num1} + ${num2}");
                        return num1 * num2;
                    }
                }
            }
            
            return 0;
        }

        //more nested loops. what could go wrong.
        public static BigInteger FindTriple()
        {
            const int target = 2020;
            var lines = File.ReadAllLines(FilePath);
            if(lines.Length == 0) return new BigInteger(0);
            
            foreach (var line in lines)
            {
                var num1 = int.Parse(line);
                foreach (var otherLine in lines)
                {
                    var num2 = int.Parse(otherLine);
                    foreach(var otherOtherLine in lines)
                    {
                        var num3 = int.Parse(otherOtherLine);
                        if (num1 + num2 + num3 == target)
                        {
                            return new BigInteger(num1 * num2 * num3);
                        }
                    }
                }
            }
            
            return new BigInteger(0);
        }
    }
}