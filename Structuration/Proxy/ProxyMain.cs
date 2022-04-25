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
    public static class ProxyMain
    {
        public static void Main()
        {
            var animation = new AnimationProxy();
            animation.dessine();
            animation.clic();
            animation.dessine();
        }
    }
}
