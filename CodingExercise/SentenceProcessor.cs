using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodingExercise
{
    public class SentenceProcessor : ISentenceProcessor
    {

        public string ProcessSentence(string s)
        {
            var sb = new StringBuilder();
            var words = Regex.Split(s, @"([^\p{L}])");
            
            foreach(var w in words)
            {
                if(Regex.IsMatch(w, @"\p{L}") && w.Length > 1)
                {
                    var newWord = new StringBuilder();
                    newWord.Append(w[0]);
                    var middle = w[1..^1];
                    newWord.Append(middle.Distinct().Count());
                    newWord.Append(w[^1]);
                    sb.Append(newWord);
                }
                else
                    sb.Append(w);
            }

            return sb.ToString();
        }
    }
}
