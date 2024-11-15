using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ListTask
{

    public static void Main()
    {

        List<string> list = new List<string>();

        Console.WriteLine("Podaj nazwę miasta #: ");

        for (int i = 0; i < 3; i++)
        {
            string element = Console.ReadLine();
            list.Add(element);

        }

        Console.WriteLine("Podaj miasta");

        foreach (var element in list)
        {
            Console.WriteLine($"Cities: {element}");
        }


    }

}