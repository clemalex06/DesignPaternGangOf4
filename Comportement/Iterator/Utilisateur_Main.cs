﻿using System;

namespace Iterator
{
    /*
     * 
     * Concept de l'iterator
     * fournit u accès séquentiel à une collection d'objets
     * sans que les clients se préoccupent de l'implémentation de cette collection
     * 
     */
    public class Utilisateur
    {
        public static void Main(string[] args)
        {
            var catalogue = new CatalogueVehicule();
            var iterateur =catalogue.recherche("bon marche");
            Vehicule vehicule;
            iterateur.debut();
            vehicule = iterateur.item();
            while (vehicule != null)
            {
                vehicule.affiche();
                iterateur.suivant();
                vehicule = iterateur.item();
            }
        }
    }
}