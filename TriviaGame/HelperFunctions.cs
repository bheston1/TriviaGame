namespace TriviaGame
{
    internal class HelperFunctions
    {
        internal static void PressEnter()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
        }

        internal static string ValidateAnswer(string answer)
        {
            while (string.IsNullOrEmpty(answer))
            {
                Console.Write("\nPlease enter a valid answer and try again.\nAnswer: ");
                answer = Console.ReadLine();
            }

            return answer;
        }

    }
}
