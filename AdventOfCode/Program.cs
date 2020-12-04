using System;
using System.Linq;
using AdventOfCode.DayOne;
using AdventOfCode.DayTwo;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day One
            // Console.Out.WriteLine("Day One");
            // Console.Out.WriteLine(ExpenseReport.FindDouble());
            // Console.Out.WriteLine(ExpenseReport.FindTriple());
            
            //Day Two
            var dayTwo = PasswordValidator.FindValidPasswords();
            dayTwo.ForEach(Console.Out.WriteLine);
        }
    }
}