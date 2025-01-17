used boolean data type to check if the user has the correct answer

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
