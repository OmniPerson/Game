namespace Game
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}

