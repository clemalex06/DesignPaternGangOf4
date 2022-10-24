using System;
namespace Proxy
{
    public class AnimationProxy : IAnimationMovie
    {
        protected AnimationMovie Movie = null;
        protected string Photo = "Display the photo";

        public void Click()
        {
            if (Movie == null)
            {
                Movie = new AnimationMovie();
                Movie.Load();
            }
            Movie.Play();
        }

        public void Draw()
        {
            if (Movie != null)
            {
                Movie.Draw();
            }
            else
                Draw(Photo);
        }

        public void Draw(string photo)
        {
            Console.WriteLine(photo);
        }
    }
}
