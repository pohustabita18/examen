using System.Security.Cryptography.X509Certificates;

namespace Examen
{
    class Person
    {
        public string? FirstName { get; private set; }
        public int Age { get; internal set; }
        public string LastName { get; private set; }
        public int YearOfBirth { get; private set; }

        class Program
        {
            public static object PersonProcessor { get; private set; }

            static void Main()
            {
                Console.Write("Numarul de persoane: ");
                int n = int.Parse(Console.ReadLine());

                Person[] persoane = new Person[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Introduceti informatiile pentru persoana :");

                    Console.Write("Prenume: ");
                    string prenume = Console.ReadLine();

                    Console.Write("Nume de familie: ");
                    string numeFamilie = Console.ReadLine();

                    Console.Write("Anul nasterii: ");
                    int anNastere = int.Parse(Console.ReadLine());

                    persoane[i] = new Person
                    {
                        FirstName = prenume,
                        LastName = numeFamilie,
                        YearOfBirth = anNastere
                    };
                }
                Person ceaMaiInVarsta = PersonProcessor.GetOldestPerson(persoane);

                // Afișarea informațiilor despre cea mai în vârstă persoană
                if (ceaMaiInVarsta != null)
                {
                    Console.WriteLine($"\nCea mai în vârstă persoană este: {ceaMaiInVarsta.FirstName} {ceaMaiInVarsta.LastName}, cu vârsta de {ceaMaiInVarsta.Age} ani.");
                }
                else
                {
                    Console.WriteLine("\nNu exista persoane pentru a determina cea mai in varsta persoana.");
                }

                Console.ReadLine();
            }
        }
    }
}



    
  