using System.Collections.Generic;
namespace Command
{
    public class Catalog
    {
        protected IList<Car> CarsInStock =
            new List<Car>();
        protected IList<DiscountedCommand> DiscountedCommands =
            new List<DiscountedCommand>();

        public void LaunchDiscountedCommand(DiscountedCommand discountedCommand)
        {
            DiscountedCommands.Insert(0, discountedCommand);
            discountedCommand.Discount(CarsInStock);
        }

        public void CancelDiscountedCommand( int order)
        {
            DiscountedCommands[order].Cancel();
        }

        public void RestoreDiscountedCommand(int order)
        {
            DiscountedCommands[order].Restore();
        }

        public void Add(Car vehicule)
        {
            CarsInStock.Add(vehicule);
        }

        public void Display()
        {
            foreach (var vehicule in CarsInStock)
                vehicule.Display();
        }
    }
}
