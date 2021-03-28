namespace BlazorMorse.Domain
{
    public interface IMorsePart { }

    public class Dot : IMorsePart
    {
        public const char Sign = '.';

        public override string ToString()
        {
            return Sign.ToString();
        }
    }

    public class Dash : IMorsePart
    {
        public const char Sign = '-';

        public override string ToString()
        {
            return Sign.ToString();
        }
    }

    public class ShortGap : IMorsePart
    {
        public const char Sign = ' ';

        public override string ToString()
        {
            return Sign.ToString();
        }
    }

    public class MediumGap : IMorsePart
    {
        public const string Sign = "   ";

        public override string ToString()
        {
            return Sign;
        }
    }
}
