class generator
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hvorfor vil du ha en ny hobby");
        string navn = Console.ReadLine();
        Console.WriteLine($"Hei {navn}, hva er hobbyen din?");
        string hobby = Console.ReadLine();
        Console.WriteLine($"Så du liker å {hobby}?");
    }
}



