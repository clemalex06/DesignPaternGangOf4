using System;
namespace Interpreter
{
    public class AndOperator : BinaryOperator
    {
        public AndOperator(Expression leftOperand,
            Expression rightOperand) : base(leftOperand,
                rightOperand)
        {
        }

        public override bool Evaluate(string description)
        {
            return LeftOperand.Evaluate(description) &&
                RightOperand.Evaluate(description);
        }

        // synthactic analyze part
        public static new Expression Parse()
        {
            Expression leftResult, rightResult;
            leftResult = Expression.Parse();

            while ((Token != null) && (Token == "And"))
            {
                NextToken();
                rightResult = Expression.Parse();
                leftResult = new AndOperator(leftResult, rightResult);
            }
            return leftResult;
        }
    }
}
