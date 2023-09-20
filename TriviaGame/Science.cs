namespace TriviaGame
{
    internal class Science
    {
        internal static void GetScienceQuestions()
        {
            var random = new Random();
            int gameRoll = random.Next(1, 4);

            switch (gameRoll)
            {
                case 1:
                    ScienceSet1("SCIENCE QUESTIONS SET 1\n=======================");
                    break;

                case 2:
                    ScienceSet2("SCIENCE QUESTIONS SET 2\n=======================");
                    break;

                case 3:
                    ScienceSet3("SCIENCE QUESTIONS SET 3\n=======================");
                    break;
            }
        }

        private static void ScienceSet1(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"Waxing Gibbous refers to which celestial body?
A - Venus
B - Moon
C - Sun
D - Mercury");
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
                        Console.WriteLine(@"What type of rock is formed under huge amounts of heat?
A - metamorphic
B - igneous
C - sedimentary
D - diamond");
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
                        Console.WriteLine(@"What type of energy is possessed by a body in motion?
A - mechanical
B - kinetic
C - chemical
D - thermal");
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
                        Console.WriteLine(@"What is measured with a Geiger counter?
A - temperature
B - pressure
C - radioactivity
D - electrical current");
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
                        Console.WriteLine(@"Who wrote the science law 'for every action there is an equal and opposite reaction'?
A - Isaac Newton
B - Albert Einstein
C - Stephen Hawking
D - Carl Sagan");
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
                        Console.WriteLine(@"Which science term means an observation which differs from expectations?
A - hypothesis
B - anomaly
C - reaction
D - fusion");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateAnswer(answer6);
                        if (answer6.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer6.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 7:
                        Console.WriteLine(@"What does the Beaufort Scale measure?
A - radioactivity
B - wind speed
C - ocean depth
D - hardness");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateAnswer(answer7);
                        if (answer7.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer7.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 8:
                        Console.WriteLine(@"What is the fundamental unit of temperature?
A - centigrade
B - farenheit
C - celsius
D - kelvin");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateAnswer(answer8);
                        if (answer8.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer8.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 9:
                        Console.WriteLine(@"What is the lightest of all the metallic elements?
A - helium
B - aluminium
C - lithium
D - silver");
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
                        Console.WriteLine(@"The chemical symbol 'Na', from the Latin Natrium, is used for which element?
A - sodium
B - gold
C - iron
D - copper");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateAnswer(answer10);
                        if (answer10.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer10.Trim().ToLower() != "a")
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

        private static void ScienceSet2(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"What word means the wearing away of land by water or wind?
A - weathering
B - carving
C - melting
D - erosion");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateAnswer(answer1);
                        if (answer1.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer1.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 2:
                        Console.WriteLine(@"What science term means the rate of change of velocity?
A - acceleration
B - speed
C - kinetic energy
D - gravitational force");
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
                        Console.WriteLine(@"Which word means how heavy something is, given its volume?
A - weight
B - density
C - buoyancy
D - liquidity");
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
                        Console.WriteLine(@"Which term means heat transfer through the movement of a fluid?
A - conversion
B - nuclear fusion
C - thermal energy
D - convection");
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
                        Console.WriteLine(@"Which planet is named after the Roman God of the Sea?
A - Venus
B - Saturn
C - Neptune
D - Jupiter");
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
                        Console.WriteLine(@"What was the first artificial satellite to be launched into space by the USSR?
A - Apollo 7
B - Sputnik 1
C - Leonov
D - Galileo");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateAnswer(answer6);
                        if (answer6.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer6.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 7:
                        Console.WriteLine(@"Who made the first spacewalk ever?
A - Buzz Aldrin
B - Neil Armstrong
C - Alexei Leonov
D - Boris Yegorov");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateAnswer(answer7);
                        if (answer7.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer7.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 8:
                        Console.WriteLine(@"Sedimentary rocks such as limestone and chalk are largely composed of which element?
A - calcium
B - iron
C - zinc
D - nickel");
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
                        Console.WriteLine(@"What is the name given to the outer layer of the earth?
A - inner core
B - mantle
C - crust
D - outer core");
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
                        Console.WriteLine(@"Which theory says that the most simplest explanation is properly the right one?
A - Meridia's Beacon
B - Occam's Razor
C - Heisenberg's Uncertainty Principle
D - Theory of General Relativity");
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

        private static void ScienceSet3(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"What is mass multiplied by acceleration?
A - kinetic energy
B - velocity
C - force
D - mechanical energy");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateAnswer(answer1);
                        if (answer1.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer1.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 2:
                        Console.WriteLine(@"Which major galaxy is closest in light years to the Milky Way?
A - LGS 3
B - Andromeda
C - Aquarius dwarf
D - Wolf-Lundmark-Melotte");
                        var answer2 = Console.ReadLine();
                        answer2 = HelperFunctions.ValidateAnswer(answer2);
                        if (answer2.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer2.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 3:
                        Console.WriteLine(@"Who is considered the founder of modern physics?
A - Albert Einstein
B - Galileo Galilei
C - Stephen Hawking
D - Isaac Newton");
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
                        Console.WriteLine(@"Approximately how long does it take light from the sun to reach Earth?
A - 8 minutes
B - 1.5 hours
C - 1 year
D - 29 days");
                        var answer4 = Console.ReadLine();
                        answer4 = HelperFunctions.ValidateAnswer(answer4);
                        if (answer4.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer4.Trim().ToLower() != "a")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 5:
                        Console.WriteLine(@"Which metal is the most conductive metal on Earth?
A - aluminium
B - steel
C - copper
D - silver");
                        var answer5 = Console.ReadLine();
                        answer5 = HelperFunctions.ValidateAnswer(answer5);
                        if (answer5.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer5.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 6:
                        Console.WriteLine(@"What chemical element is the sun primarily made of?
A - hydrogen
B - helium
C - carbon
D - oxygen");
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
                        Console.WriteLine(@"What is the term for the study of fungi?
A - mushroommancy
B - entmology
C - mycology
D - hematology");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateAnswer(answer7);
                        if (answer7.Trim().ToLower() == "c")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer7.Trim().ToLower() != "c")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 8:
                        Console.WriteLine(@"What is the most abundant gas in Earth's atmosphere?
A - helium
B - argon
C - hydrogen
D - nitrogen");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateAnswer(answer8);
                        if (answer8.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer8.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 9:
                        Console.WriteLine(@"Which subatomic particle carries a negative electrical charge?
A - photon
B - electron
C - proton
D - neutron");
                        var answer9 = Console.ReadLine();
                        answer9 = HelperFunctions.ValidateAnswer(answer9);
                        if (answer9.Trim().ToLower() == "b")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer9.Trim().ToLower() != "b")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 10:
                        Console.WriteLine(@"What is the term for the process by which water changes from a liquid state to a gas?
A - evaporation
B - erosion
C - fission
D - condensation");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateAnswer(answer10);
                        if (answer10.Trim().ToLower() == "a")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer10.Trim().ToLower() != "a")
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