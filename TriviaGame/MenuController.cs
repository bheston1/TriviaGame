namespace TriviaGame
{
    internal class MenuController
    {
        internal static void MainMenu()
        {
            Console.Clear();
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("=========");
                Console.WriteLine(@"Select an option:
1 - Play game
2 - View previous games
3 - Close application");

                var menuInput = Console.ReadLine();
                switch (menuInput.Trim())
                {
                    case "1":
                        GameSelect();
                        break;

                    case "2":
                        Reporting.ShowReports();
                        break;

                    case "3":
                        closeApp = true;
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid command. Press ENTER");
                        HelperFunctions.PressEnter();
                        break;
                }
            }
        }

        internal static void GameSelect()
        {
            Console.Clear();
            Console.WriteLine("CATEGORIES");
            Console.WriteLine("==========");
            Console.WriteLine(@"Select a category:
1. Animals
2. Geography
3. Science
4. Random category");

            var gameSelection = Console.ReadLine();
            switch (gameSelection.Trim())
            {
                case "1":
                    Animals.GetAnimalQuestions();
                    break;

                case "2":
                    Geography.GetGeographyQuestions();
                    break;

                case "3":
                    Science.GetScienceQuestions();
                    break;

                case "4":
                    RandomGame.GetCategory();
                    break;

                default:
                    Console.WriteLine("Invalid command. Press ENTER");
                    HelperFunctions.PressEnter();
                    GameSelect();
                    break;
            }
        }
    }
}
