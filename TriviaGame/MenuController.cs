namespace TriviaGame
{
    internal class MenuController
    {
        internal static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine(@"1 - Play game
2 - View previous games
3 - Close application");
        }
    }
}
