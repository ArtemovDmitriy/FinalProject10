namespace FinalProject10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IAddition addition = new AddingTwoNumbers();
                ILogger Logger = new Logger();
                Logger.Solve(addition);

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
