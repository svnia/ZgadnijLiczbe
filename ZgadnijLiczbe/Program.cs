// See https://aka.ms/new-console-template for more information
Random r = new Random();
int rInt = r.Next(1, 11);
int liczba;
Console.WriteLine("Zgadnij liczbe:");
while (true)
{
    try
    {
        liczba = int.Parse(Console.ReadLine());

    }
    catch (System.FormatException)
    {
        Console.WriteLine("Musisz podac liczbe");
        continue;
    }
    if (liczba == rInt)
    {
        Console.WriteLine("Gratulacje Zdadłes liczbe");
        break;
    }
    else if (liczba > rInt)
    {
        Console.WriteLine("Twoja podana liczba liczba jest mniejsza");
    }
    else if (liczba < rInt)
    {
        Console.WriteLine("Twoja podana liczba liczba jest wieksza");
    }
}
