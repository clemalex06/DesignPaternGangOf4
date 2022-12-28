namespace Interpreter
{
    public abstract class BinaryOperator : Expression
    {
        protected Expression LeftOperand, RightOperand;

        public BinaryOperator(Expression leftOperand,
            Expression rightOperand)
        {
            LeftOperand = leftOperand;
            RightOperand = rightOperand;
        }
    }
}
