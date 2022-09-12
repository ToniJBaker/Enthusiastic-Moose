using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            
            //Let the moose speak!
            MooseSays("HI, I'M  E N T H U S I A S T I C!");
            MooseSays("I really am enthusiastic");

            // As a question
        //    CanadaQuestion();
        //    EnthusiasticQuestion();
        //    SecretQuestion();
        //    LoveCSharpQuestion();
            MooseRefactor("Canada");
            MooseRefactor("Enthusiastic");
            MooseRefactor("Love");
            MooseRefactor("Secret");
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }
        
        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //question 1
        static void CanadaQuestion()
        {
            bool isTrue = MooseAsks("Is Canada real?");
            if (isTrue)
            {
                MooseSays("Really? It seems very unlikely.");
            }
            else
            {
                MooseSays("I  K N E W  I T !!!");
            }
        }
        //question 2
        static void EnthusiasticQuestion()
        {
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            if (isEnthusiastic)
            {
                MooseSays("Yay!");
            }
            else
            {
                MooseSays("You should try it!");
            }
        }
        //question 3
        static void LoveCSharpQuestion()
        {
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            if (doesLoveCSharp)
            {
                MooseSays("Good job sucking up to your instructor!");
            }
            else
            {
                MooseSays("You will...oh, yes, you will...");
            }
        }
        //question 4
        static void SecretQuestion()
        {
            bool isEverythingFine = MooseAsks("Do you want to know a secret?");
            if (isEverythingFine)
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSays("Oh, no...secrets are the best, I love to share them!");
            }
        }
        static void MooseRefactor (string whichQuestion)
        {
            if (whichQuestion == "Canada")
            {
                CanadaQuestion();
            }
            else if (whichQuestion == "Enthusiastic")
            {
                EnthusiasticQuestion();
            }
            else if (whichQuestion == "Love")
            {
                LoveCSharpQuestion();
            }
            else if (whichQuestion == "Secret")
            {
                SecretQuestion();
            }
        }
    }
}

