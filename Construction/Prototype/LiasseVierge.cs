﻿using System.Collections.Generic;
namespace Prototype
{
    public class LiasseVierge:Liasse
    {
        private static LiasseVierge _instance;

        private LiasseVierge()
        {
            documents = new List<Document>();
        }

        public static LiasseVierge Instance()
        {
            if (_instance == null)
                _instance = new LiasseVierge();
            return _instance;
        }

        public void ajoute(Document doc)
        {
            documents.Add(doc);
        }

        public void retire(Document doc)
        {
            documents.Remove(doc);
        }
    }
}
