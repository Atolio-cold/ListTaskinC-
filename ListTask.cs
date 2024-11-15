using System;
using System.Collections.Generic;

class ListTask
{
    public static void Main()
    {
        // Tworzymy listę, która będzie przechowywać unikalne miasta
        List<string> list = new List<string>();

        Console.WriteLine("Podaj nazwę 3 unikalnych miast:");

        for (int i = 0; i < 3; i++) // Pętla działa dokładnie 3 razy
        {
            Console.Write($"Podaj nazwę miasta #{i + 1}: ");
            string city = Console.ReadLine();

            // Sprawdzamy, czy miasto już jest w liście
            if (list.Contains(city))
            {
                Console.WriteLine("To miasto już istnieje. Wprowadź inne.");
                i--; // Cofamy licznik, by użytkownik mógł ponownie wprowadzić wartość
            }
            else
            {
                // Dodajemy unikalne miasto do listy
                list.Add(city);
            }
        }

        // Wyświetlamy wszystkie dodane miasta
        Console.WriteLine("\nWszystkie miasta:");
        foreach (var city in list)
        {
            Console.WriteLine($"Miasto: {city}");
        }
    }
}
