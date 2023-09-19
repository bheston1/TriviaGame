namespace TriviaGame
{
    internal class Animals
    {
        internal static void GetAnimalQuestions()
        {
            var random = new Random();
            int gameRoll = random.Next(1, 4);

            switch (gameRoll)
            {
                case 1:
                    AnimalSet1("ANIMAL QUESTIONS SET 1\n======================");
                    break;

                case 2:
                    AnimalSet2("ANIMAL QUESTIONS SET 2\n======================");
                    break;

                case 3:
                    AnimalSet3("ANIMAL QUESTIONS SET 3\n======================");
                    break;
            }
        }

        private static void AnimalSet1(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"What is the word for a group of cats?
A - tribe
B - litter
C - clowder
D - flock");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateResult(answer1);
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
                        Console.WriteLine(@"Which has the thickest fur of any mammal?
A - sea otter
B - polar bear
C - lion
D - red panda");
                        var answer2 = Console.ReadLine();
                        answer2 = HelperFunctions.ValidateResult(answer2);
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
                        Console.WriteLine(@"The age of a lion can be determined by its...?
A - tail
B - nose
C - paws
D - teeth");
                        var answer3 = Console.ReadLine();
                        answer3 = HelperFunctions.ValidateResult(answer3);
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
                        Console.WriteLine(@"What is the only mammal capable to true flight?
A - bat
B - flying squirrel
C - hummingbird
D - sugar glider");
                        var answer4 = Console.ReadLine();
                        answer4 = HelperFunctions.ValidateResult(answer4);
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
                        Console.WriteLine(@"A newborn kangaroo is about the size of a...?
A - baseball
B - basketball
C - walnut
D - lima bean");
                        var answer5 = Console.ReadLine();
                        answer5 = HelperFunctions.ValidateResult(answer5);
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
                        Console.WriteLine(@"What is the smallest mammal in the world?
A - hamster
B - guinea pig
C - bumblebee bat
D - squirrel");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateResult(answer6);
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
                        Console.WriteLine(@"What animal has the highest blood pressure?
A - giraffe
B - grizzly bear
C - koala
D - sloth");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateResult(answer7);
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
                        Console.WriteLine(@"How far away can a wolf smell its prey?
A - 2 miles
B - 25 miles
C - 10 miles
D - 6 miles");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateResult(answer8);
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
                        Console.WriteLine(@"What mammal has the most powerful bite?
A - elephant
B - alligator
C - hippopotamus
D - tiger");
                        var answer9 = Console.ReadLine();
                        answer9 = HelperFunctions.ValidateResult(answer9);
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
                        Console.WriteLine(@"Dogs only have sweat glands on what part of their body...?
A - pads of their paws
B - inside their ears
C - on their nose
D - on their tail");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateResult(answer10);
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

        private static void AnimalSet2(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"What is a female fox called?
A - vixen
B - kit
C - drake
D - doe");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateResult(answer1);
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
                        Console.WriteLine(@"How many teeth can a crocodile have over its lifetime?
A - up to 4,000
B - up to 10,000
C - up to 2,500
D - up to 20,000");
                        var answer2 = Console.ReadLine();
                        answer2 = HelperFunctions.ValidateResult(answer2);
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
                        Console.WriteLine(@"What creature has a tongue that can measure the length of its body?
A - anteater
B - chameleon
C - frog
D - bearded dragon");
                        var answer3 = Console.ReadLine();
                        answer3 = HelperFunctions.ValidateResult(answer3);
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
                        Console.WriteLine(@"What is a group of parrots called?
A - assortment
B - swarm
C - flock
D - pandemonium");
                        var answer4 = Console.ReadLine();
                        answer4 = HelperFunctions.ValidateResult(answer4);
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
                        Console.WriteLine(@"What farm animal can sunburn?
A - cow
B - goat
C - pig
D - chicken");
                        var answer5 = Console.ReadLine();
                        answer5 = HelperFunctions.ValidateResult(answer5);
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
                        Console.WriteLine(@"What is a male duck called?
A - duke
B - top quack
C - stallion
D - drake");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateResult(answer6);
                        if (answer6.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer6.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 7:
                        Console.WriteLine(@"What is the closest living relative to the T-rex?
A - chicken
B - gecko
C - alligator
D - crocodile");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateResult(answer7);
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
                        Console.WriteLine(@"What male sea creature gives birth to its young?
A - seahorse
B - pufferfish
C - starfish
D - barracuda");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateResult(answer8);
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
                        Console.WriteLine(@"Which sea creature can change its gender?
A - blue whale
B - ghost crab
C - oyster
D - starfish");
                        var answer9 = Console.ReadLine();
                        answer9 = HelperFunctions.ValidateResult(answer9);
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
                        Console.WriteLine(@"What is the deadliest creature in the world?
A - mosquito
B - wasp
C - black widow
D - camel spider");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateResult(answer10);
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

        private static void AnimalSet3(string message)
        {
            int question = 1;


            for (int questionCount = 0; questionCount < 10; questionCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (question)
                {
                    case 1:
                        Console.WriteLine(@"Where do sea otters store extra food on their bodies?
A - a pouch on their belly
B - pocket of skin in their armpits
C - on their backs
D - they carry it in one arm");
                        var answer1 = Console.ReadLine();
                        answer1 = HelperFunctions.ValidateResult(answer1);
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
                        Console.WriteLine(@"Which one of these common species of animals die soon after giving birth?
A - octopus
B - seahorse
C - honey bee
D - rabbit");
                        var answer2 = Console.ReadLine();
                        answer2 = HelperFunctions.ValidateResult(answer2);
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
                        Console.WriteLine(@"What type of fish mate for life?
A - clownfish
B - angelfish
C - largemouth bass
D - pufferfish");
                        var answer3 = Console.ReadLine();
                        answer3 = HelperFunctions.ValidateResult(answer3);
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
                        Console.WriteLine(@"Where on its body are a crab's taste buds?
A - mandibles
B - claws
C - eyes
D - feet");
                        var answer4 = Console.ReadLine();
                        answer4 = HelperFunctions.ValidateResult(answer4);
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
                        Console.WriteLine(@"Which animal baby can gain up to 250 pounds per day?
A - blue whale
B - elephant
C - hippopotamus
D - bull shark");
                        var answer5 = Console.ReadLine();
                        answer5 = HelperFunctions.ValidateResult(answer5);
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
                        Console.WriteLine(@"What is a baby hedgehog called?
A - cub
B - spikelet
C - kid
D - hoglet");
                        var answer6 = Console.ReadLine();
                        answer6 = HelperFunctions.ValidateResult(answer6);
                        if (answer6.Trim().ToLower() == "d")
                        {
                            Console.WriteLine("Correct!");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        else if (answer6.Trim().ToLower() != "d")
                        {
                            Console.WriteLine("Incorrect.");
                            Console.WriteLine("Press ENTER");
                            HelperFunctions.PressEnter();
                        }
                        question++;
                        break;

                    case 7:
                        Console.WriteLine(@"What percentage of baby animals are raised by both parents?
A - 25%
B - 10%
C - 3%
D - 8%");
                        var answer7 = Console.ReadLine();
                        answer7 = HelperFunctions.ValidateResult(answer7);
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
                        Console.WriteLine(@"People from which country brought domestic cats to the United States?
A - Australia
B - England
C - Germany
D - France");
                        var answer8 = Console.ReadLine();
                        answer8 = HelperFunctions.ValidateResult(answer8);
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
                        Console.WriteLine(@"Which of these mammals is one of two that lay eggs?
A - pangolin
B - porcupine
C - duck-billed platypus
D - naked mole-rat");
                        var answer9 = Console.ReadLine();
                        answer9 = HelperFunctions.ValidateResult(answer9);
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
                        Console.WriteLine(@"How many legs does a lobster have?
A - 8
B - 16
C - 12
D - 10");
                        var answer10 = Console.ReadLine();
                        answer10 = HelperFunctions.ValidateResult(answer10);
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
    }
}
