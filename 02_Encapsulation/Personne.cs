using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    // Encapsulation :
    // de la classe (par défaut) : internal
    // dans la classe (par défaut) : private

    public class Personne
    {
        public string Lastname;
        public string Firstname;
        public DateTime Birthdate;

        protected string Info;

        public void DireBonjour()
        {
            Console.WriteLine($"{Lastname} {Firstname} dit bonjour.");
        }
    }

    public class Homme : Personne
    {
        public void SePresenter()
        {
            Console.WriteLine($"{this.Info}");
        }
    }

    public class Batiment
    {
        List<Personne> personnes;

        public Batiment()
        {
            personnes = new List<Personne>();
        }

        public void Ajouter(Personne p)
        {
            personnes.Add(p);
        }

        public void AfficherInfoPersonne()
        {
            foreach (Personne p in personnes)
            {
                // Ne fonctionne pas car Info accessible uniquement dans la classe conteneur
                // ou les classes filles / sous-classes / types dérivés
                //Console.WriteLine($"Information : {p.Info}"); 
            }
        }
    }
}
