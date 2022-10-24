using System;
namespace Proxy
{
    public class AnimationMovie : IAnimationMovie
    {

        public void Click()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Display The Movie");
        }

        public void Load()
        {
            Console.WriteLine("Load The Movie");
        }

        public void Play()
        {
            Console.WriteLine("Play the Movie");
        }
    }
}
