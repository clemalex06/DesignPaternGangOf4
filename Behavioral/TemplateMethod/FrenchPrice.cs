namespace TemplateMethod
{
    public class FrenchPrice : Price
    {
        protected override void ComputeValueAddedTax()
        {
            ValueAddedTax = PriceWithoutTax * 0.196;
        }
    }
}
