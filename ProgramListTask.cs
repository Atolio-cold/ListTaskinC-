
List<string> Names = new List<string>();

Names.Add("Monika");
Names.Add("Zuzia");
Names.Add("Bartek");
Console.WriteLine($"\nIlosc osob na liscie: {Names.Count}");
Console.WriteLine(Names[0]);
Console.WriteLine(Names[1]);
Console.WriteLine(Names[2]);

Names.Remove("Zuzia");

Console.WriteLine(Names[0]);
Console.WriteLine(Names[1]);



List<int> ints = new List<int>();

ints.Add(1);
ints.Add(2);
ints.Add(3);
ints.Add(4);
ints.Remove(ints[0]);
Console.WriteLine(ints[0]);
Console.WriteLine(ints[1]);
Console.WriteLine(ints[2]);


List<string> Citys = new List<string>();

Citys.Add("Warsaw");
Citys.Add("London");
Citys.Add("York");
Citys.Add("New York");
Citys.Add("Liszki");
Citys.Add("Cracov");
Citys.Add("Poznan");
Citys.Add("Mielno");

string szukaneMiasto = "Warsaw";


//Używamy metody Contains, która zwraca true, jeśli lista zawiera dany element, lub false w przeciwnym przypadku.
if (Citys.Contains(szukaneMiasto))
{
    Console.WriteLine($"Lista zawiera miasto: {szukaneMiasto}");
}
else
{
    Console.WriteLine($"Lista nie zawiera miasta: {szukaneMiasto}");
}

List<int> marks = new List<int>();

marks.Add(1);
marks.Add(2);
marks.Add(3);
marks.Add(4);
marks.Add(5);

marks[2] = 5;
marks[3] = 6;

Console.WriteLine(marks[2]);

List<string> Movies = new List<string>();

Movies.Add("Harry Potter");
Movies.Add("Batman");
Movies.Add("Top Gun");

foreach (string movie in Movies)
{
    if (movie.Contains("s"))
    {
        Console.WriteLine($"{movie} has a letter 's'");
    }
    else
    {
        Console.WriteLine($"{movie} does not have a letter 's'");
    }
}
