using System;
using System.Reflection;
namespace ReflectiveVisitor
{
    public abstract class Visitor
    {
        public void StartVisit(IVisitable visitable)
        {
            MethodInfo infoMethod = this.GetType().GetMethod("Visit",
                new Type[] { visitable.GetType() });
            infoMethod.Invoke(this, new object[] { visitable });
        }

        public void Visit(IVisitable visitable)
        {
            Console.WriteLine("default Visit");
        }
    }
}
