using System;
using System.Collections.Generic;

class Liczby1 // Nazwa klasy powinna być pisana wielką literą
{
    public static void Main()
    {
        List<int> numbers = new List<int>(); // Inicjalizacja listy do przechowywania liczb

        while (true)
        {
            Console.WriteLine("Zgadnij liczbę od 1 do 9 (lub wpisz 0, aby zakończyć):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number)) // Sprawdzenie, czy dane wejściowe to liczba
            {
                if (number == 0)
                {
                    break; // Zakończenie pętli, jeśli wpisano 0
                }
                else if (number >= 1 && number <= 9) // Sprawdzenie, czy liczba mieści się w zakresie 1-9
                {
                    numbers.Add(number); // Dodanie liczby do listy
                }
                else
                {
                    Console.WriteLine("Podano liczbę spoza zakresu 1-9. Spróbuj ponownie.");
                }
            }
            else
            {
                Console.WriteLine("Podano nieprawidłowe dane. Wprowadź liczbę.");
            }
        }

        Console.WriteLine("Podane liczby:"); // Wyświetlenie komunikatu przed wylistowaniem liczb
        foreach (var num in numbers) // Użycie bardziej opisowej nazwy zmiennej w pętli foreach
        {
            Console.WriteLine(num);
        }
    }
}
