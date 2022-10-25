using System;
namespace Command
{
    public class Car
    {
        protected string Name;
        protected DateTime StorageStartDate;
        protected double SellingPrice;

        public Car(string name, DateTime storageStartDate, double sellingPrice)
        {
            Name = name;
            StorageStartDate = storageStartDate;
            SellingPrice = sellingPrice;
        }

        public double GetStorageDuration(DateTime today)
        {
            var timeSpent = today - StorageStartDate;
            return timeSpent.TotalDays;
        }

        public void ModifyPrice(double coefficient)
        {
            SellingPrice = 0.01 * Math.Round(coefficient *
                SellingPrice * 100);
        }

        public void Display()
        {
            Console.WriteLine($"Car, Name =>{Name}, Selling Price => {SellingPrice}, " +
                $"Storage Start Date => {StorageStartDate}");
        }
    }
}
