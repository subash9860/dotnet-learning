namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing a line
            Console.WriteLine("What is your name?");
            // reading a line form the user
            var name = Console.ReadLine();

            var currentDate = DateTime.Now;

            // string interpolation
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");

            // holding a key for termination
            Console.ReadKey(true);

        }
    }
}