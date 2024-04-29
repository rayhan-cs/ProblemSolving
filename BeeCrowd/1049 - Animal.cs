using System;

class URI
{

    static void Main(string[] args)
    {

        var names = new string[3];
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = Console.ReadLine();
        }

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "vertebrado" && names[i + 1] == "ave" && names[i + 2] == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (names[i] == "vertebrado" && names[i + 1] == "ave" && names[i + 2] == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (names[i] == "vertebrado" && names[i + 1] == "mamifero" && names[i + 2] == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (names[i] == "vertebrado" && names[i + 1] == "mamifero" && names[i + 2] == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
            else if (names[i] == "invertebrado" && names[i + 1] == "inseto" && names[i + 2] == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (names[i] == "invertebrado" && names[i + 1] == "inseto" && names[i + 2] == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (names[i] == "invertebrado" && names[i + 1] == "anelideo" && names[i + 2] == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (names[i] == "invertebrado" && names[i + 1] == "anelideo" && names[i + 2] == "onivoro")
            {
                Console.WriteLine("minhoca");
            }

        }
    }

}