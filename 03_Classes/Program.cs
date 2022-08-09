using _03_Classes;


// Instanciation = Création d'une instance de l'objet = Création d'une référence en mémoire
// Personne = type complexe
// Type référence (cfr. object) = Stockage de l'adresse en mémoire de l'objet dans la variable de type
// Personne

Personne personne = new Personne() { Id = 1, Name = "Frédéric", Age = 49, HasPets = false };
Personne p2 = null;
Personne p3 = new Personne() { Id = 2, Name = "Pol", Age = 50 };


personne.Discuter(p2);
personne.Discuter(p3);

p3?.Marcher();

Console.WriteLine($"{personne.Name} { (personne.HasPets ? "a" : "n'a pas")} des animaux");