using System;
using System.Collections.Generic;

namespace Strategy
{
    public class DrawThreeCarsPerLine : ICatalogDraw
    {
        public DrawThreeCarsPerLine()
        {
        }

        public void Draw(IList<CarView> content)
        {
            Console.WriteLine("Will draw the cars with three cars per line");
            int count = 0;

            foreach (var v in content)
            {
                v.Draw();
                count++;
                if (count == 3)
                {
                    Console.WriteLine();
                    count = 0;
                }
                else
                    Console.Write(" ");
            }
            if (count != 0)
                Console.WriteLine();
            Console.WriteLine();
        }
    }
}
