using System;
using System.Collections.Generic;

class ToDoListApp
{
    // Deklaracja listy do przechowywania zadań
    private List<string> tasks = new List<string>();

    // Funkcja do dodawania nowego zadania
    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Dodano zadanie: " + task);
    }

    // Funkcja do wyświetlania wszystkich zadań
    public void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Lista zadań jest pusta.");
        }
        else
        {
            Console.WriteLine("Twoje zadania:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    // Funkcja do usuwania zadania na podstawie numeru
    public void RemoveTask(int taskNumber)
    {
        if (taskNumber > 0 && taskNumber <= tasks.Count)
        {
            string removedTask = tasks[taskNumber - 1];
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Usunięto zadanie: " + removedTask);
        }
        else
        {
            Console.WriteLine("Nieprawidłowy numer zadania.");
        }
    }

    // Funkcja do edytowania istniejącego zadania
    public void EditTask(int taskNumber)
    {
        if (taskNumber > 0 && taskNumber <= tasks.Count)
        {
            Console.Write("Wprowadź nową treść zadania: ");
            string newTaskContent = Console.ReadLine();
            tasks[taskNumber - 1] = newTaskContent;
            Console.WriteLine("Zadanie zostało zaktualizowane.");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy numer zadania.");
        }
    }

    // Funkcja główna
    static void Main()
    {
        ToDoListApp app = new ToDoListApp();

        while (true)
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Dodaj zadanie");
            Console.WriteLine("2. Wyświetl wszystkie zadania");
            Console.WriteLine("3. Usuń zadanie");
            Console.WriteLine("4. Wyjdź");
            Console.WriteLine("5. Edytuj zadanie");
            Console.Write("Wybór: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Wprowadź treść zadania: ");
                    string task = Console.ReadLine();
                    app.AddTask(task);
                    break;

                case "2":
                    app.DisplayTasks();
                    break;

                case "3":
                    Console.Write("Podaj numer zadania do usunięcia: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber))
                    {
                        app.RemoveTask(taskNumber);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy numer.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Koniec programu.");
                    return;

                case "5":
                    Console.Write("Podaj numer zadania do edycji: ");
                    if (int.TryParse(Console.ReadLine(), out int editTaskNumber))
                    {
                        app.EditTask(editTaskNumber);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy numer.");
                    }
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}
