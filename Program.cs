namespace Game
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            //todo:Refactor php project into c#
            Console.WriteLine($"Hello {name}");
        }
    }
}

