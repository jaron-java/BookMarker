namespace BookMarker;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to BookMarker!");
        bool flag = false;
        while (!flag)
        {
            Console.WriteLine("(A) for adding a new link");
            Console.WriteLine("(V) for viewing bookmarks");
            Console.WriteLine("Anything else to exit");
            string input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                Link newLink = Link.MakeLink();
                FileWriter.WriteLink(newLink);
                Console.WriteLine("Link added!");
                Console.Clear();
            }
            else if (input.ToLower() == "v")
            {
                FileWriter.ReadLinks();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                flag = true;
            }
        }
        System.Environment.Exit(0);
    }
}