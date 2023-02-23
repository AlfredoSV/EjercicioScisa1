using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosScisa
{
    class Program
    {
        static Dictionary<char, string> MorseToNat = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},

            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},

            {' ', ""},
            {'.', ".-.-.-"},
            {',', "--..--"},
            {':', "---..."},
            {'?', "..--.."},
            {'!', "..--."},
            {'\'', ".----."},
            {'-', "-....-"},
            {'/', "-..-."},
            {'"', ".-..-."},
            {'@', ".--.-."},
            {'=', "-...-"}
        };

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim();

            if (ValidateTypeText(input))
                ToTextNat(input);
            else
                ToMorse(input);

        }

        public static bool ValidateTypeText(string text)
        {
            var val = (text.ToCharArray().All(ch => (int)ch == 46 || (int)ch == 45 || (int)ch == 32));
            return val;
        }


        public static void ToMorse(string text)
        {
            var input = (text.ToLower().Trim()).ToCharArray();
            var output = new StringBuilder();
            foreach (var c in input)
                if (MorseToNat.ContainsKey(c))
                    output.Append($"{MorseToNat.FirstOrDefault(x => x.Key.Equals(c)).Value} ");


            Console.WriteLine(output);

            Console.Read();
        }
        public static void ToTextNat(string text)
        {
            var input = ReplacesSpaces(text.ToLower().Trim()).Split(' ');
            var output = new StringBuilder();
            foreach (string s in input)
                if (MorseToNat.ContainsValue(s))
                    output.Append(MorseToNat.FirstOrDefault(x => x.Value.Equals(s)).Key);
                else if (s == "_")
                    output.Append(" ");
            Console.WriteLine(output);

            Console.Read();
        }

        public static string ReplacesSpaces(string text) => text.Replace("  ", " _ ");


    }
}
