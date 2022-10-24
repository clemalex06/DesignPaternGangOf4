using System;
namespace Visitor
{
    public interface Visiteur
    {
        void visite(SocieteSansFiliale societe);
        void visite(SocieteMere societe);
    }
}
