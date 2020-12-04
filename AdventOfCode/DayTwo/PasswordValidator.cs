using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.DayTwo
{
    public static class PasswordValidator
    {
        private static string Input = "/home/stephen/programming/csharp/AdventOfCode/AdventOfCode/DayTwo/input.txt";

        public static List<int> FindValidPasswords()
        {
            var answer = new List<int>();
            
            var entries = File.ReadAllLines(Input);
            var parsedEntries = entries.Select(ParsePassword).ToList();
            
            answer.Add(parsedEntries.Count(HasValidCharacters));
            answer.Add(parsedEntries.Count(HasValidPositions));
            
            return answer;
        }

        private static string[] ParsePassword(string line)
        {
            return line.Replace("-", " ").Replace(":", " ").Split(" ");
        }

        private static bool HasValidCharacters(string[] parsedPassword)
        {
            var min = int.Parse(parsedPassword[0]);
            var max = int.Parse(parsedPassword[1]);

            var letter = char.Parse(parsedPassword[2]);
            var pass = parsedPassword[4].ToCharArray(); //index 3 is empty.

            var charCount = pass.Count(c => c == letter);
            
            return charCount >= min && charCount <= max;
        }

        private static bool HasValidPositions(string[] parsedPassword)
        {
            
            var record = new List<bool>();
            var pos1 = int.Parse(parsedPassword[0]);
            var pos2 = int.Parse(parsedPassword[1]);

            var letter = char.Parse(parsedPassword[2]);
            var pass = parsedPassword[4].ToCharArray(); //index 3 is empty.

            record.Add(pass[pos1 - 1] == letter);
            record.Add(pass[pos2 - 1] == letter);

            return record.Count(b => b == true) == 1;
        }
    }
}