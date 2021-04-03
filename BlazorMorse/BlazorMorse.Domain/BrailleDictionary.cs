using System.Collections.Generic;

namespace BlazorMorse.Domain
{
    public static class BrailleDictionary
    {
        private static readonly Dictionary<char, string> Map = new()
        {
            { 'A', "1" },
            { 'B', "11" },
            { 'C', "1001" },
            { 'D', "10011" },
            { 'E', "10001" },
            { 'F', "1101" },
            { 'G', "11011" },
            { 'H', "11001" },
            { 'I', "0101" },
            { 'J', "01011" },
            { 'K', "101" },
            { 'L', "111" },
            { 'M', "1011" },
            { 'N', "10111" },
            { 'O', "10101" },
            { 'P', "1111" },
            { 'Q', "11111" },
            { 'R', "11101" },
            { 'S', "0111" },
            { 'T', "01111" },
            { 'U', "101001" },
            { 'V', "111001" },
            { 'W', "010111" },
            { 'X', "101101" },
            { 'Y', "101111" },
            { 'Z', "101011" },
            { '1', "1" },
            { '2', "11" },
            { '3', "1001" },
            { '4', "10011" },
            { '5', "10001" },
            { '6', "1101" },
            { '7', "11011" },
            { '8', "11001" },
            { '9', "0101" },
            { '0', "01011" },
            { 'Å', "100001" },
            { 'Ä', "00111" },
            { 'Ö', "010101" },
        };

        public static List<IBrailleCharacter> ToBraille(this string inputText)
        {
            var result = new List<IBrailleCharacter>();
            char last = '\0';

            for (int i = 0; i < inputText.Length; i++)
            {
                var c = inputText[i];

                if (char.IsWhiteSpace(c))
                {
                    result.Add(new WhitespaceIndicator());
                    continue;
                }

                if (!Map.TryGetValue(char.ToUpperInvariant(c), out var code))
                {
                    continue;
                }

                if (char.IsUpper(c))
                {
                    result.Add(new CapitolIndicator());
                }
                else if (char.IsDigit(c) && !char.IsDigit(last))
                {
                    result.Add(new NumbersIndicator());
                }
                else if (char.IsLetter(c) && char.IsDigit(last))
                {
                    result.Add(new LetterIndicator());
                }

                result.Add(new BrailleCharacter(code));
                last = c;
            }

            return result;
        }
    }
}