using System;
namespace Interpreter
{
    public abstract class Expression
    {
        public abstract bool Evaluate(string description);

        protected static string Source;
        protected static int Index;
        protected static string Token;

        protected static void NextToken()
        {
            while ((Index < Source.Length)
                && (Source[Index] == ' '))
                Index++;
            if (Index == Source.Length)
                Token = null;
            else if ((Source[Index] == '(') || (Source[Index] == ')'))
            {
                Token = Source.Substring(Index, 1);
                Index++;
            }
            else
            {
                int start = Index;
                while ((Index < Source.Length) && (Source[Index] != ' ')
                    && (Source[Index] != ')'))
                {
                    Index++;
                }
                Token = Source.Substring(start, Index - start);
            }
        }

        public static Expression Analyse(string source)
        {
            Source = source;
            Index = 0;
            NextToken();
            return OrOperator.Parse();
        }

        public static Expression Parse()
        {
            Expression result;
            if (Token == "(")
            {
                NextToken();
                result = OrOperator.Parse();
                if (Token == null)
                    throw new Exception("Synthactic Error");
                if (Token != ")")
                    throw new Exception("Synthactic Error");
                NextToken();
            }
            else
            {
                result = KeyWord.Parse();
            }
            return result;
        }
    }
}
