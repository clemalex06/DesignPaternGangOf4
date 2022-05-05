namespace AbstractFactory
{
    public abstract class Car
    {
        protected string Model;
        protected string Color;
        protected int Power;
        protected double Space;

        public Car(string model, string color, int power, double space)
        {
            this.Model = model;
            this.Color = color;
            this.Power = power;
            this.Space = space;
        }

        public abstract void DisplayFeatures();
    }
}
