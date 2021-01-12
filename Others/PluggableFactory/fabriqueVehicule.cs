using System;
namespace PluggableFactory
{
    public class fabriqueVehicule
    {
        public Automobile prototypeAutomobile { get; set; }
        public Scooter prototypeScooter { get; set; }

        public fabriqueVehicule()
        {
            prototypeAutomobile = null;
            prototypeScooter = null;
        }

        public fabriqueVehicule (Automobile automobile,Scooter scooter)
        {
            this.prototypeAutomobile = automobile;
            this.prototypeScooter = scooter;
        }

        public Automobile creerAutomobile()
        {
            if (prototypeAutomobile == null)
                return null;
            return prototypeAutomobile.duplique();
        }

        public Scooter creerScooter()
        {
            if (prototypeScooter == null)
                return null;
            return prototypeScooter.duplique();
        }
    }
}
