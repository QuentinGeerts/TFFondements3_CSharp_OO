using System;

namespace TFFondements3
{

    public enum Race { Humain, Nain, Orc }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("→ Affichage du type de l'enum");
            Console.WriteLine(typeof(Race));
        }
    }
}
