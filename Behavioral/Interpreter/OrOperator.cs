namespace Interpreter
{
    public class OrOperator : BinaryOperator
    {
        public OrOperator(Expression leftOperand,
            Expression rightOperand) : base(leftOperand,
                rightOperand)
        {
        }

        public override bool Evaluate(string description)
        {
            return LeftOperand.Evaluate(description) ||
                RightOperand.Evaluate(description);
        }

        // synthactic analyze part
        public static new Expression Parse()
        {
            Expression leftResult, rightResult;
            leftResult = AndOperator.Parse();
            while ((Token != null) && (Token == "Or" || Token == "||" || Token == "or"))
            {
                NextToken();
                rightResult = AndOperator.Parse();
                leftResult = new OrOperator(leftResult, rightResult);
            }

            return leftResult;
        }
    }
}
