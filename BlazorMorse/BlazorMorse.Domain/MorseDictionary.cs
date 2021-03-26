using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMorse.Domain
{
    public static class MorseDictionary
    {
        private static readonly Dictionary<char, string> Map = new()
        {
            {' ', " "},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
        };

        public static List<IMorsePart> ToMorseCode(this char c)
        {
            var code = Map[char.ToUpperInvariant(c)];
            return code.Select(GetMorsePart).ToList();
        }

        private static IMorsePart GetMorsePart(char cc) =>
            cc switch
            {
                Dot.Sign => new Dot(),
                Dash.Sign => new Dash(),
                Pause.Sign => new Pause(),
                _ => throw new ArgumentException($"unsupported character {cc}")
            };
    }
}