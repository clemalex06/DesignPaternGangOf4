﻿using System;
namespace ChainOfResponsability
{
    public class Vehicule : ObjetBase
    {
        protected string laDescription;

        public Vehicule(string description)
        {
            laDescription = description;
        }

        protected override string description
        {
            get
            {
                return laDescription;
            }
        }
    }
}
