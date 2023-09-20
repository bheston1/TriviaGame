namespace TriviaGame
{
    internal class Reporting
    {
        private static readonly List<Reporting> _reports = new();

        internal int Score { get; set; }
        internal int MaxScore { get; set; }
        internal DateTime Date { get; set; }
        internal GameType Category { get; set; }

        internal enum GameType
        {
            Animals,
            Geography,
            Science
        }

        internal static void ShowReports()
        {
            Console.Clear();
            Console.WriteLine("Previous games\n==============");

            foreach (var report in _reports)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"{report.Date} - Category: {report.Category}, Score: {report.Score}/{report.MaxScore}");
                Console.WriteLine("-----------------------------------------------------");
            }

            Console.WriteLine("Press ENTER to return to menu");
            HelperFunctions.PressEnter();
            MenuController.MainMenu();
        }

        internal static void AddToReports(int score, int maxScore, GameType category)
        {
            _reports.Add(new Reporting 
            {
                Date = DateTime.Now,
                Score = score,
                MaxScore = maxScore,
                Category = category
            });
        }
    }
}
