using System;
using System.Collections.Generic;
namespace FlighWeight
{
    public class CarOrder
    {
        public IList<CarOption> Options = new
            List<CarOption>();
        protected IList<int> OptionsSellingPrice =
            new List<int>();

        public void AddOption(string name, int sellingPrice,
            OptionsFactory factory)
        {
            Options.Add(factory.getOption(name));
            OptionsSellingPrice.Add(sellingPrice);
        }

        public void DisplayOptions()
        {
            int index, length;

            length = Options.Count;

            for (index = 0; index < length; index++)
            {
                Options[index].Display(OptionsSellingPrice[index]);
                Console.WriteLine();
            }
        }
    }
}
