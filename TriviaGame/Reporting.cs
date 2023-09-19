namespace TriviaGame
{
    internal class Reporting
    {
        internal static void ShowReports()
        {
            Console.Clear();
            Console.WriteLine("Reporting feature not yet implemented\n\nPress ENTER to return to menu");
            HelperFunctions.PressEnter();
            MenuController.MainMenu();
        }
    }
}
