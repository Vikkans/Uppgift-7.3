using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> size = new Dictionary<string, int>();
        size["Sverige"] = 450;
        size["Norge"] = 385;
        size["Danmark"] = 43;
        size["Finland"] = 338;
        

        Console.WriteLine("Välj ett av länderna Sverige, Norge, Danmark, Finland");
        string svar = Console.ReadLine();

        Console.WriteLine(size[svar]);
    }
}