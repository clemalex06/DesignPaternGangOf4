namespace TemplateMethod
{
    public class SpanishPrice : Price
    {
        protected override void ComputeValueAddedTax()
        {
            ValueAddedTax = PriceWithoutTax * 0.15;
        }
    }
}
