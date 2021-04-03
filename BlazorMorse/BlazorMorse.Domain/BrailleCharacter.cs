using System;
using System.Collections;

namespace BlazorMorse.Domain
{
    public interface IBrailleCharacter 
    {
        public BitArray Dots { get; }
    }

    public class BrailleCharacter : IBrailleCharacter
    {
        public BitArray Dots { get; } = new BitArray(6, false);

        public BrailleCharacter(string binary)
        {
            if (binary.Length > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(binary), "Must not exceed 6");
            }

            for (int i = 0; i < binary.Length; i++)
            {
                Dots[i] = binary[i] == '1';
            }

            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            var aa = new bool[6];
            Dots.CopyTo(aa, 0);
            return string.Join(',', aa);
        }
    }

    public class NumbersIndicator : BrailleCharacter
    {
        public NumbersIndicator() : base("001111") // # ble
        {
        }
    }

    public class CapitolIndicator : BrailleCharacter
    {
        public CapitolIndicator() : base("000001")
        {
        }
    }

    public class LetterIndicator : BrailleCharacter
    {
        public LetterIndicator() : base("000011")
        {
        }
    }

    public class WhitespaceIndicator : BrailleCharacter
    {
        public WhitespaceIndicator() : base("")
        {
        }
    }
}
