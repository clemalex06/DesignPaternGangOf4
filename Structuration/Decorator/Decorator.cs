namespace Decorator
{
    public abstract class Decorator : ICarDisplayComponent
    {
        protected ICarDisplayComponent component;

        public Decorator(ICarDisplayComponent component)
        {
            this.component = component;
        }

        public virtual void Display()
        {
            component.Display();
        }
    }
}
