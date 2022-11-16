using System;
using System.Collections.Generic;

namespace Strategy
{
    public class CatalogView
    {
        protected IList<CarView> Content =
            new List<CarView>();

        protected ICatalogDraw Drawing;

        public CatalogView(ICatalogDraw dessin)
        {
            Content.Add(new CarView("Cheap Car"));
            Content.Add(new CarView("Space Car"));
            Content.Add(new CarView("Fast Car"));
            Content.Add(new CarView("Confortable Car"));
            Content.Add(new CarView("Sport Car"));

            this.Drawing = dessin;
        }

        public void Draw()
        {
            Drawing.Draw(Content);
        }
    }
}
