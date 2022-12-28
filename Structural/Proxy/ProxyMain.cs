namespace Proxy
{
    /*
     * Proxy's Concept :
     * lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, 
     * allowing you to perform something either before or after the request gets through to the original object.
     */
    public static class ProxyMain
    {
        public static void Main()
        {
            var animationMovie = new AnimationProxy();
            animationMovie.Draw();
            animationMovie.Click();
            animationMovie.Draw();
        }
    }
}
