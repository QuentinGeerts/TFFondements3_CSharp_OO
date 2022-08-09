using System;

namespace EnumDemo
{
    public enum Race { Humain, Nain, Orc }

    public enum Class { Guerrier = 1, Sorcier = 3, Archer }

    public enum Right { Execute, Write, Read, Delete, Update }

    [Flags]
    public enum RightFlag { Execute = 1, Write = 2, Read = 4 }

    // 3   2   1   0 
    // 8   4   2   1

    // 0   0   0   1   // Execute => 1
    // 0   0   1   0   // Write => 2
    // 0   1   0   0   // Read => 4

    // 0   1   1   1   // Execute, Write, Read => 7
    // 0   1   1   0   // Write, Read => 6

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("→ Affichage du type de l'enum");
            Console.WriteLine(typeof(Race));

            Race race1 = Race.Humain;
            Race race2 = Race.Nain;
            Race race3 = Race.Orc;

            Console.WriteLine("\n→ Affichage des valeurs de l'enum");

            Console.WriteLine(race1); // Output : Humain
            Console.WriteLine(race2); // Output : Nain
            Console.WriteLine(race3); // Output : Orc

            Console.WriteLine("\n→ Affichage des valeurs de l'enum (string)");

            Console.WriteLine(race1.ToString()); // Output : Humain
            Console.WriteLine(race2.ToString()); // Output : Nain
            Console.WriteLine(race3.ToString()); // Output : Orc

            Console.WriteLine("\n→ Affichage des valeurs de l'enum (int)");

            Console.WriteLine((int) race1); // Output : 0
            Console.WriteLine((int) race2); // Output : 1
            Console.WriteLine((int) race3); // Output : 2

            // ▬▬▬▬ //

            Console.WriteLine("\n→ Affichage des classes");

            Class class1 = Class.Guerrier;
            Class class2 = Class.Sorcier;
            Class class3 = Class.Archer;

            Console.WriteLine((int) class1 + " " + class1);
            Console.WriteLine((int) class2 + " " + class2);
            Console.WriteLine((int) class3 + " " + class3);

            // ▬▬▬▬ //

            Right right1 = Right.Write;
            Right right2 = Right.Write | Right.Read;
            Right right3 = Right.Read | Right.Write | Right.Execute;

            Console.WriteLine("\n→ Affichage des droits");

            Console.WriteLine((int)right1); // Output : 1
            Console.WriteLine((int)right2); // Output : 3
            Console.WriteLine((int)right3); // Output : 3

            // Limité à 3 valeurs

            // ▬▬▬▬ //

            RightFlag rf1 = RightFlag.Execute;
            RightFlag rf2 = RightFlag.Read | RightFlag.Write;
            RightFlag rf3 = RightFlag.Read | RightFlag.Write | RightFlag.Execute;

            Console.WriteLine("\n→ Affichage des droits (flags)");

            Console.WriteLine((int)rf1 + " " + rf1); // Output : 1 Execute
            Console.WriteLine((int)rf2 + " " + rf2); // Output : 6 Write, Read
            Console.WriteLine((int)rf3 + " " + rf3); // Output : 7 Execute, Write, Read

            // ▬▬▬▬ //

            Console.WriteLine("\n→ Vérification du droit :");

            if (rf3.HasFlag(RightFlag.Execute))
            {
                Console.WriteLine("→ Accès au droit d'exécution");
            }

            if (rf3.HasFlag(RightFlag.Write))
            {
                Console.WriteLine("→ Accès au droit d'écriture");
            }

            if (rf3.HasFlag(RightFlag.Read))
            {
                Console.WriteLine("→ Accès au droit de lecture");
            }

            // ▬▬▬▬ //

            Console.WriteLine("\n→ Parcourt d'une enum : ");

            foreach (string droit in Enum.GetNames(typeof(Right)))
            {
                Console.WriteLine(droit);
            }

            // ▬▬▬▬ //

            Console.WriteLine("\n→ Conversion d'une chaine de caractères en type Enum :");

            string write = "Writee";

            //RightFlag rf4 = write;
            //RightFlag rf4 = (RightFlag)Enum.Parse(typeof(RightFlag), write);

            //Console.WriteLine((int)rf4 + " " + rf4);

            if (Enum.TryParse<RightFlag>(write, out RightFlag rf5))
            {
                Console.WriteLine("Conversion réussie");
                Console.WriteLine((int) rf5 + " " + rf5);
            }
            else
            {
                Console.WriteLine("Conversion échouée");
                rf5 = RightFlag.Read;
            }

            Console.WriteLine("\n→ Récupération externe du droit : " + rf5);
        }
    }
}
