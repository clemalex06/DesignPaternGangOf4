using System;
namespace Observer
{
    public class CarObserver : IObserver
    {
        protected Car Car;
        protected string Text = string.Empty;

        public CarObserver(Car car)
        {
            Car = car;
            car.Add(this);
            UpdateText();
            
        }
        protected void UpdateText()
        {
            Text = $"Description {Car.Description} Price : {Car.Price}";
        }

        public void Refresh()
        {
            UpdateText();
            ReWrite();
        }

        public void ReWrite()
        {
            Console.WriteLine(Text);
        }
    }
}
