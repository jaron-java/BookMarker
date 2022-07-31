namespace BookMarker;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to BookMarker!");
        Link newLink = Link.MakeLink();
        FileWriter.WriteLink(newLink);
        Console.WriteLine("Link added!");
        FileWriter.ReadLinks();
        Console.ReadKey();
        System.Environment.Exit(0);
    }
}