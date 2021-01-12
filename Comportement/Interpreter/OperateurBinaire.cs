using System;
namespace Interpreter
{
    public abstract class OperateurBinaire:Expression
    {
        protected Expression operandeGauche, operandeDroite;

        public OperateurBinaire(Expression operandeGauche,
            Expression operandeDroite)
        {
            this.operandeGauche = operandeGauche;
            this.operandeDroite = operandeDroite;
        }
    }
}
