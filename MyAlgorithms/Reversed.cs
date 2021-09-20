using System.Text;

namespace MyAlgorithms
{
    public class Reversed
    {
        public string ReversedWord(string word)
        {
            StringBuilder sb = new();

            for (int i = (word.Length - 1); 0 <= i; i--)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
        }
    }
}
