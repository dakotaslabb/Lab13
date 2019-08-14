using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            Validation v = new Validation();

            bool con = true;
            string yourName = "";

            Console.WriteLine("Welcome to Rock Paper Scissors\n");
            Console.WriteLine("What is your name?\n");
            while (con == true)
            {
                string name = Console.ReadLine();
                con = v.Validator(name);
                yourName = name;
            }
            Human h = new Human(yourName);
            Console.WriteLine("\nWho would you like to play agaisnt \"Rocky\" or \"Dwayne Johnson\"? r/d\n");
            string opponent = Console.ReadLine().Trim().ToLower();

            while (keepgoing == true)
            {
                if (opponent == "d")
                {
                    RoShamBoApp sham = new RoShamBoApp();
                    string npc1 = "Dwayne Johnson";
                    string answer = h.generateRoShamBo();
                    string npcAnswer = sham.PlayerSelection(opponent);
                    Console.WriteLine($"\n{yourName}: {answer}");
                    Console.WriteLine($"{npc1}: {npcAnswer}");

                    if (answer == npcAnswer)
                    {
                        Console.WriteLine("Draw");
                    }
                    else if (answer == "scissors" && npcAnswer == "paper")
                    {
                        Console.WriteLine($"{yourName} Wins!!!!!");
                    }
                    else if (answer == "rock" && npcAnswer == "scissors")
                    {
                        Console.WriteLine($"{yourName} Wins!!!!!");
                    }
                    else if (answer == "paper" && npcAnswer == "rock")
                    {
                        Console.WriteLine($"{yourName} Wins!!!!!");
                    }
                    else if (npcAnswer == "scissors" && answer == "paper")
                    {
                        Console.WriteLine($"{npc1} Wins!!!!!");
                    }
                    else if (npcAnswer == "rock" && answer == "scissors")
                    {
                        Console.WriteLine($"{npc1} Wins!!!!!");
                    }
                    else if (npcAnswer == "paper" && answer == "rock")
                    {
                        Console.WriteLine($"{npc1} Wins!!!!!");
                    }
                }
                else if (opponent == "r")
                {
                    RoShamBoApp sham = new RoShamBoApp();
                    string npc2 = "Rocky";
                    string answer = h.generateRoShamBo();
                    string npcAnswer = sham.PlayerSelection(opponent);
                    Console.WriteLine($"\n{yourName}: {answer}");
                    Console.WriteLine($"{npc2}: {npcAnswer}");

                    if (answer == npcAnswer)
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (answer == "scissors")
                    {
                        Console.WriteLine($"{npc2} Wins!!!!!");
                    }
                    else if (answer == "paper")
                    {
                        Console.WriteLine($"{yourName} Wins!!!!!");
                    }


                }
                Console.WriteLine("\nWould you like to continue? y/n\n");
                string input1 = Console.ReadLine().ToLower().Trim();
                if (input1 == "y")
                {
                    continue;
                }
                else if (input1 == "n")
                {
                    Console.WriteLine("Thanks for Playing");
                    keepgoing = false;
                }
            }
        }
    }
}
