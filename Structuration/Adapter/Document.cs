﻿using System;
namespace Adapter
{
    public interface Document
    {
        string contenu { set;}
        void dessine();
        void imprime();
    }
}