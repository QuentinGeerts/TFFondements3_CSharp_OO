namespace _03_Classes
{
    public partial class Personne
    {
        // Champ = caractéristiques d'un objet
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        // Méthodes = actions que peuvent réaliser les objets
        public void Discuter (Personne p)
        {
            if (p == null) { return; }

            Console.WriteLine($"{Name} discute avec {p.Name}");
        }

        public void Marcher()
        {
            Console.WriteLine($"{Name} marche quelques pas.");
        }

    }

    public partial class Personne
    {
        public bool HasPets;
    }
}
