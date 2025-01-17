using System;

class Riddler
{
    static void Riddles()
    {
        //riddles
        string[] riddle = {
            "I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?",
            "The more of this you take, the more you leave behind. What is it?",
            "I am not alive, but I can grow; I don’t have lungs, but I need air; I don’t have a mouth, but water kills me. What am I?" };
        //answers to the riddles
        string[] answers = { "echo", "footsteps", "fire" };

        // Total attempts allowed for the game
        int Attempts = 3; 

        // Loop through each riddle
        for (int i = 0; i < riddle.Length; i++)
        {
            // Check if the user has any attempts left
            if (Attempts <= 0)
            {
                Console.WriteLine("You have no attempts left. Game over!");
                return; 
            }

            // Display the current riddle
            Console.WriteLine($"Riddle {i + 1}: {riddle[i]}");

            // Check if the user has guessed the current riddle correctly
            bool isCorrect = false;

            // Give the user one chance to answer the current riddle
            Console.Write("Enter your answer: ");
            string userAnswer = Console.ReadLine().ToLower(); 

            // Check if the user's answer is correct
            if (userAnswer == answers[i])
            {
                isCorrect = true;
                Console.WriteLine("Correct! Well done you've managed to solve one of my riddles!\nYou win!!!!");
                break;
            }

            // If the answer is wrong, reduce total attempts
            if (!isCorrect)
            {
                Attempts--; 
                Console.WriteLine($"Wrong answer! You have {Attempts} attempt(s) left.\n");

                // If no attempts are left after this guess, end the game
                if (Attempts <= 0)
                {
                    Console.WriteLine("What...What...Wrong!!!!\nHow can you be so bad,you tried three times and you lost. \nGame over! you die");
                    return;
                }
            }



        }

    }
        
        
        static void Main(string[] args)
        {
            // welcome message to the user
            Console.WriteLine("\t\t\t_________Welcome to my Game of Riddles!_________");
            Console.WriteLine("You have a total of 3 attempts to solve all of my riddles,you win even if you manage to solve one riddle.");
            Console.WriteLine("If you run out of attempts, the game is over and You die. Good luck!\n");

            // Call the riddles function to start the game
            Riddles();
        }
    
}
