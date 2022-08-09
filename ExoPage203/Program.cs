using enums;
using structs;

// Paquet de cartes
Carte[] cartes = new Carte[52];

// Initialisation du compteur de cartes
int i = 0;

// Parcourir les couleurs et les valeurs

// Parcourir les couleurs

foreach (string couleur in Enum.GetNames(typeof(Couleur)))
{
    Console.WriteLine($"\n- Création des {couleur}");

    // Parcourir les valeurs
    foreach (string valeur in Enum.GetNames(typeof(Valeur)))
    {
        cartes[i] = new Carte()
        {
            Couleur = (Couleur)Enum.Parse(typeof(Couleur), couleur),
            Valeur = (Valeur)Enum.Parse(typeof(Valeur), valeur)
        };

        Console.WriteLine($"{i} {cartes[i].Couleur} {cartes[i].Valeur}");
        i++;
    }
}

namespace enums
{

    public enum Couleur { Coeur, Carreau, Pique, Trefle }
    public enum Valeur
    {
        Deux = 2,
        Trois,
        Quatre,
        Cinq,
        Six,
        Sept,
        Huit,
        Neuf,
        Dix,
        Valet,
        Dame,
        Roi,
        As
    }
}

namespace structs
{
    public struct Carte
    {
        // Propriétés
        public Couleur Couleur;
        public Valeur Valeur;
    }
}