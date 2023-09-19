namespace TriviaGame
{
    internal class Geography
    {
        internal static void GetGeographyQuestions()
        {
            var random = new Random();
            int gameRoll = random.Next(1, 4);

            switch (gameRoll)
            {
                case 1:
                    GeographySet1("GEOGRAPHY QUESTIONS SET 1\n=========================");
                    break;

                case 2:
                    GeographySet2("GEOGRAPHY QUESTIONS SET 2\n=========================");
                    break;

                case 3:
                    GeographySet3("GEOGRAPHY QUESTIONS SET 3\n=========================");
                    break;
            }
        }

        private static void GeographySet1(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"What is the name of the tallest mountain in the world?
A - Mount Everest
B - K2
C - Mount Kilimanjaro
D - Broad Peak");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateAnswer(answer1);
                        if (answer1.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer1.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 2:
                        Console.WriteLine(@"Which country has the largest population in the world?
A - China
B - Russia
C - United States
D - India");
                        var answer2 = Console.ReadLine();
                        answer2 = HelperFunctions.ValidateAnswer(answer2);
                        if (answer2.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer2.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 3:
                        Console.WriteLine(@"What is the longest river in Africa?
A - Congo River
B - Nile River
C - Kagera River
D - Orange River");
                        var answer3 = Console.ReadLine();
                        answer3 = HelperFunctions.ValidateAnswer(answer3);
                        if (answer3.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer3.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 4:
                        Console.WriteLine(@"What is the capital of Mexico?
A - Durango
B - Acapulco
C - Matamoros
D - Mexico City");
                        var answer4 = Console.ReadLine();
                        answer4 = HelperFunctions.ValidateAnswer(answer4);
                        if (answer4.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer4.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 5:
                        Console.WriteLine(@"What is the largest ocean in the world?
A - Pacific Ocean
B - Atlantic Ocean
C - Indian Ocean
D - Arctic Ocean");
                        var answer5 = Console.ReadLine();
                        answer5 = HelperFunctions.ValidateAnswer(answer5);
                        if (answer5.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer5.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 6:
                        Console.WriteLine(@"What is the smallest country in the world?
A - North Korea
B - Monaco
C - Vatican City
D - New Zealand");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateAnswer(answer6);
                        if (answer6.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer6.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 7:
                        Console.WriteLine(@"What U.S. state is home to no documented poisonous snakes?
A - Alaska
B - Rhode Island
C - New York
D - Wyoming");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateAnswer(answer7);
                        if (answer7.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer7.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 8:
                        Console.WriteLine(@"What is the name of the river that flows through the Brazilian rainforest?
A - Nile River
B - The Amazon
C - Yangtze River
D - Congo River");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateAnswer(answer8);
                        if (answer8.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer8.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 9:
                        Console.WriteLine(@"What is the official currency of the United Kingdom?
A - Quid
B - Euro
C - Pound sterling
D - U.K. Dollar");
                        var answer9 = Console.ReadLine();
                        answer9 = HelperFunctions.ValidateAnswer(answer9);
                        if (answer9.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer9.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 10:
                        Console.WriteLine(@"In which city in Egypt are the Great Pyramids located?
A - Alexandria
B - Luxor
C - Cairo
D - Giza");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateAnswer(answer10);
                        if (answer10.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer10.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;
                }
                if (questionCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Game over. Your final score is ");
                    HelperFunctions.PressEnter();
                }
            }
        }

        private static void GeographySet2(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"Which of the following is NOT one of the seven continents of the world?
A - Australia
B - Russia
C - Africa
D - Asia");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateAnswer(answer1);
                        if (answer1.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer1.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 2:
                        Console.WriteLine(@"In which U.S. city is the Golden Gate Bridge located?
A - San Francisco
B - Los Angeles
C - New York
D - Seattle");
                        var answer2 = Console.ReadLine();
                        answer2 = HelperFunctions.ValidateAnswer(answer2);
                        if (answer2.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer2.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 3:
                        Console.WriteLine(@"What is the largest country in the world?
A - United States
B - Russia
C - China
D - Australia");
                        var answer3 = Console.ReadLine();
                        answer3 = HelperFunctions.ValidateAnswer(answer3);
                        if (answer3.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer3.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 4:
                        Console.WriteLine(@"What is the capital of Canada?
A - Winnipeg
B - Vancouver
C - Toronto
D - Ottawa");
                        var answer4 = Console.ReadLine();
                        answer4 = HelperFunctions.ValidateAnswer(answer4);
                        if (answer4.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer4.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 5:
                        Console.WriteLine(@"What present-day Italian city does Mt. Vesuvius overlook?
A - Rome
B - Pompeii
C - Naples
D - Venice");
                        var answer5 = Console.ReadLine();
                        answer5 = HelperFunctions.ValidateAnswer(answer5);
                        if (answer5.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer5.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 6:
                        Console.WriteLine(@"How many time zones does Russia have?
A - 1
B - 4
C - 11
D - 6");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateAnswer(answer6);
                        if (answer6.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer6.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 7:
                        Console.WriteLine(@"What type of leaf is on the Canadian flag?
A - Maple
B - Marijuana
C - Birch
D - Oak");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateAnswer(answer7);
                        if (answer7.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer7.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 8:
                        Console.WriteLine(@"What is the driest continent on Earth?
A - Africa
B - Antarctica
C - South America
D - Asia");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateAnswer(answer8);
                        if (answer8.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer8.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 9:
                        Console.WriteLine(@"What country is known to have the best quality tap water?
A - France
B - Sweden
C - Poland
D - Switzerland");
                        var answer9 = Console.ReadLine();
                        answer9 = HelperFunctions.ValidateAnswer(answer9);
                        if (answer9.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer9.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 10:
                        Console.WriteLine(@"What is the flattest state in the U.S.?
A - Wyoming
B - Kansas
C - Florida
D - Nevada");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateAnswer(answer10);
                        if (answer10.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer10.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;
                }
                if (questionCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Game over. Your final score is ");
                    HelperFunctions.PressEnter();
                }
            }
        }

        private static void GeographySet3(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"What river in the U.S. runs through the Grand Canyon?
A - Colorado River
B - Mississippi River
C - Snake River
D - Red River");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateAnswer(answer1);
                        if (answer1.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer1.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 2:
                        Console.WriteLine(@"What is the capital of Denmark?
A - Budapest
B - Amsterdam
C - Berlin
D - Copenhagen");
                        var answer2 = Console.ReadLine();
                        answer2 = HelperFunctions.ValidateAnswer(answer2);
                        if (answer2.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer2.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 3:
                        Console.WriteLine(@"What is the largest state in the U.S.?
A - Texas
B - Alaska
C - North Dakota
D - California");
                        var answer3 = Console.ReadLine();
                        answer3 = HelperFunctions.ValidateAnswer(answer3);
                        if (answer3.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer3.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 4:
                        Console.WriteLine(@"Which country has the abbreviation 'CH'?
A - Chile
B - China
C - Switzerland
D - Ukraine");
                        var answer4 = Console.ReadLine();
                        answer4 = HelperFunctions.ValidateAnswer(answer4);
                        if (answer4.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer4.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 5:
                        Console.WriteLine(@"The village of 'Fucking' is located in which country?
A - New Zealand
B - Poland
C - Austria
D - United Kingdom");
                        var answer5 = Console.ReadLine();
                        answer5 = HelperFunctions.ValidateAnswer(answer5);
                        if (answer5.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer5.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 6:
                        Console.WriteLine(@"What European country is often described as 'shaped like a boot'?
A - Italy
B - France
C - Germany
D - Belgium");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateAnswer(answer6);
                        if (answer6.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer6.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 7:
                        Console.WriteLine(@"Vatican City is enclaved withing what city...?
A - Florence
B - Venice
C - Athens
D - Rome");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateAnswer(answer7);
                        if (answer7.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer7.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 8:
                        Console.WriteLine(@"What is the deepest known point in the ocean?
A - Challenger Deep
B - Japan Trench
C - Philippine Trench
D - Peru-Chile Trench");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateAnswer(answer8);
                        if (answer8.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer8.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 9:
                        Console.WriteLine(@"What country contains the most lakes?
A - Norway
B - United States
C - Canada
D - Russia");
                        var answer9 = Console.ReadLine();
                        answer9 = HelperFunctions.ValidateAnswer(answer9);
                        if (answer9.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer9.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 10:
                        Console.WriteLine(@"Which of the Seven Wonders of the World still exists?
A - The Colosseum in Rome
B - Great Pyramid of Giza
C - Leaning Tower of Pisa
D - Great Wall of China");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateAnswer(answer10);
                        if (answer10.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer10.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;
                }
                if (questionCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Game over. Your final score is ");
                    HelperFunctions.PressEnter();
                }
            }
        }
    }
}