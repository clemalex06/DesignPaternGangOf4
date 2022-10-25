using System;
namespace Interpreter
{
    public class KeyWord : Expression
    {
        protected string Word;

        public KeyWord(string word)
        {
            Word = word;
        }

        public override bool Evaluate(string description)
        {
            return description.IndexOf(Word) != -1;
        }

        // synthactic analyze part
        public static new Expression Parse()
        {
            Expression result;
            result = new KeyWord(Token);
            NextToken();
            return result;
        }
    }
}
