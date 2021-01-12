using System;
using System.Reflection;
namespace ReflectiveVisitor
{
    public abstract class Visiteur
    {
        public void demarreVisite(Visitable visitable)
        {
            MethodInfo infoMethod = this.GetType().GetMethod("visite",
                new Type[] { visitable.GetType() });
            infoMethod.Invoke(this, new object[] { visitable });
        }

        public void visite(Visitable visitable)
        {
            Console.WriteLine("Visite par defaut");
        }
    }
}
