using System;
using System.Collections.Generic;
namespace Command
{
    public class DiscountedCommand
    {
        protected IList<Car> DiscountedCars =
            new List<Car>();

        protected DateTime Today;
        protected string Name;
        protected long StorageDuration;
        protected double DiscountRate;

        public DiscountedCommand(DateTime today,
            long storageDuration, double discountRate, string name)
        {
            Today = today;
            StorageDuration = storageDuration;
            DiscountRate = discountRate;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Discounted Command, Name =>{Name}, Effective Date => {Today}, " +
                $"for Cars stored before => {Today.AddDays(-StorageDuration)}, Discount Rate => {DiscountRate}");
        }

        public void Discount(IList<Car> cars)
        {
            DiscountedCars.Clear();
            foreach (var car in cars)
            {
                if (car.GetStorageDuration(Today) >=
                    StorageDuration)
                {
                    DiscountedCars.Add(car);
                }
            }

            foreach (var car in DiscountedCars)
            {
                car.ModifyPrice(1 - DiscountRate);
            }
        }

        public void Cancel()
        {
            foreach (var vehicule in DiscountedCars)
                vehicule.ModifyPrice(1 / (1 - DiscountRate));
        }

        public void Restore()
        {
            foreach (var vehicule in DiscountedCars)
                vehicule.ModifyPrice(1 - DiscountRate);
        }
    }
}
