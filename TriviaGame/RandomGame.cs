namespace TriviaGame
{
    internal class RandomGame
    {
        internal static void GetCategory()
        {
            var random = new Random();
            int gameRoll = random.Next(1, 4);

            switch (gameRoll)
            {
                case 1:
                    Animals.GetAnimalQuestions();
                    break;

                case 2:
                    Geography.GetGeographyQuestions();
                    break;

                case 3:
                    Science.GetScienceQuestions();
                    break;
            }
        }
    }
}