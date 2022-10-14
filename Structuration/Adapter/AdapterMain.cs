﻿using System;

namespace Adapter
{
    /*
     *
     *Concept de l'Adapter
     * a pour but de convertir l'interface d'une classe existante en l'interface
     * attendue par des clients également existant afin qu'ils puissent
     * travailler ensemble
     */
    public static class AdapterMain
    {
        public static void Main()
        {
            Document document1, document2;
            document1 = new Documenthtml();
            document1.Content = "Hello Html";
            document1.Draw();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.Content = "Hello Pdf";
            document2.Draw();
        }
    }
}
