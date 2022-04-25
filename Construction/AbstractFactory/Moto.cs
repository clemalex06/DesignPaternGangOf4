namespace AbstractFactory
{
    public abstract class Moto
    {
        protected string model;
        protected string color;
        protected int power;

        public Moto(string model, string color, int power)
        {
            this.model = model;
            this.color = color;
            this.power = power;
        }

        public abstract void DisplayFeatures();
    }
}
