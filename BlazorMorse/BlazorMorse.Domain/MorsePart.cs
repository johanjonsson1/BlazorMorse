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

    public class Pause : IMorsePart
    {
        public const char Sign = ' ';

        public override string ToString()
        {
            return Sign.ToString();
        }
    }
}
