using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Title = "Roblox VIP Joiner";

        Console.WriteLine("=================================");
        Console.WriteLine("      Roblox VIP Joiner");
        Console.WriteLine("=================================");
        Console.Write("Paste Server Link: ");

        string link = Console.ReadLine();

        Match m = Regex.Match(link, @"code=([a-zA-Z0-9]+)");

        if (!m.Success)
        {
            Console.WriteLine("Invalid Link!");
            Console.ReadKey();
            return;
        }

        string code = m.Groups[1].Value;

        string roblox =
            $"roblox://navigation/share_links?code={code}&type=Server";

        Process.Start(new ProcessStartInfo
        {
            FileName = roblox,
            UseShellExecute = true
        });

        Console.WriteLine("Joining...");
        Console.ReadKey();
    }
}
