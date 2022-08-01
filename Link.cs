namespace BookMarker;

// I feel this is a really heavy handed way of doing this...

public class Link
{
    public static string Title { get; set; }
    public static string Address { get; set; }
    public static string Description { get; set; }
    public static string Folder { get; set; }

    public Link(string title, string address, string description, string folder)
    {
        Title = title;
        Address = address;
        Description = description;
        Folder = folder;
    }

    public static Link MakeLink()
    {
        string folder = GetFolder();
        string title = GetTitle();
        string address = GetAddress();
        string description = GetDescription();
        Link newLink = new Link(title, address, description, folder);
        return newLink;
    }

    public static string GetFolder()
    {
        Console.WriteLine("Please enter a folder to save this bookmark in");
        string folder = Console.ReadLine();
        return folder;
    }

    public static string GetTitle()
    {
        Console.WriteLine("Please enter a Title for this Link/Bookmark");
        string title = Console.ReadLine();
        return title;
    }
    public static string GetAddress()
    {
        Console.WriteLine("Please paste or type the address link:");
        string address = Console.ReadLine();
        return address;
    }

    public static string GetDescription()
    {
        Console.WriteLine("Please enter a brief description of this link");
        string description = Console.ReadLine();
        return description;
    }
    
    
}