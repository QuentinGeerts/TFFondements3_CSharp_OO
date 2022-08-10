namespace _04_Proprietes
{
    public class Personne
    {
        // Champs
        private int _Id { get; set; }
        //private string _Name { get; set; }
        private int _Age { get; set; }

        public Personne()
        {
            Id = new Random().Next();
        }

        // Getters / Setters

        //// Getters
        //public int getId() { return _Id; }
        //public string getName() { return _Name; }
        //public int getAge() { return _Age; }

        //// Setters
        //public void setId(int id) { _Id = id; }
        //public void setName(string name) { _Name = name; }
        //public void setAge(int age) { _Age = age; }

        // Propriétés

        // Accesseurs = Accéder à la donnée = Getter
        // Mutateurs = Modifier la donnée = Setter

        // Full-prop
        public int Id
        {
            get { return _Id; }

            // Soit en omettant le set / get
            private set { _Id = value; }
        }

        public int Age
        {
            get { return _Age; }
            set
            {
                if (_Age > 0)
                {
                    _Age = value;
                }
                else
                {
                    _Age = 0;
                }
            }
        }

        // Auto-prop
        // prop → →
        public string Name { get; set; }

        // propfull → → 
        private bool _HasPet;

        public bool HasPet
        {
            get { return _HasPet; }
            set { _HasPet = value; }
        }


        // Méthodes
        public void Discuter(Personne p)
        {
            if (p == null) { return; }

            Console.WriteLine($"{Name} discute avec {p.Name}");
        }

        public void Marcher()
        {
            Console.WriteLine($"{Name} marche quelques pas.");
        }
    }
}
