using System;
using System.Collections.Generic;

namespace Strategy
{
    public class DrawOneCarPerLine : ICatalogDraw
    {
        public void Draw(IList<CarView> contenu)
        {
            Console.WriteLine("Will draw the cars with one car per line");

            foreach(var v in contenu)
            {
                v.Draw();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
