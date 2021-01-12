using System;

namespace Proxy
{
    /*
     *
     * Concept du PROXY
     * construit un objet qui se substitue à unautre objet et
     * qui controle son acces
     * 
     */
    public class VueVehicule
    {
        public static void Main(string[] args)
        {
            var animation = new AnimationProxy();
            animation.dessine();
            animation.clic();
            animation.dessine();
        }
    }
}
