namespace caesar
{
    public class Cypher
    {
        public static string Encrypt(string text, int shiftValue)
        {
            string returnText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = (char)(text[i] + (shiftValue % 26));
                if (symbol > 90)
                {
                    symbol = (char)(symbol % 90 + 64);
                }
                returnText += symbol;
            }
            return returnText;
        }
        public static string Decrypt(string text, int shiftValue)
        {
            string returnText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = (char)(text[i] - (shiftValue % 26));
                if (symbol < 65)
                {
                    symbol = (char)(symbol + 26);
                }
                returnText += symbol;
            }
            return returnText;
        }
    }
}
