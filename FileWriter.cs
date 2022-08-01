using System;
using System.IO;

namespace BookMarker;

public class FileWriter
{
    public static void ReadLinks()
    {
        Console.WriteLine("Enter the folder you wish to view");
        string path = Console.ReadLine() + ".txt";

        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
    
    
    public static void WriteLink(Link link)
    {
        string path = $"{Link.Folder}.txt";

        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine("===================");
            sw.WriteLine(Link.Folder);
            sw.WriteLine(Link.Title);
            sw.WriteLine(Link.Address);
            sw.WriteLine(Link.Description);
            sw.WriteLine("##################");
        }
    }
}