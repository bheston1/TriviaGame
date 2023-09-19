namespace TriviaGame
{
    internal class Game
    {
        internal static void Start()
        {
            Console.WriteLine(" _____       _       _               ___                   \r\n|_   _| _ _ (_)__ __(_) __ _        / __| __ _  _ __   ___ \r\n  | |  | '_|| |\\ V /| |/ _` |      | (_ |/ _` || '  \\ / -_)\r\n  |_|  |_|  |_| \\_/ |_|\\__/_|       \\___|\\__/_||_|_|_|\\___|\r\n");


            Console.WriteLine("Press ENTER");
            HelperFunctions.PressEnter();
            MenuController.MainMenu();
        }
    }
}
