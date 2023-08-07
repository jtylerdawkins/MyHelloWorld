// See https://aka.ms/new-console-template for more information
string name = "World";

// Print "Hello, name!"
Console.WriteLine($"Hello, {name}!");

//Console.WriteLine("Hello, World!");

// Rock, paper, scissors mini-game
bool isPlaying = true;
int score = 0;
while (isPlaying)
{
    // Begin playing rock, paper, scissors
    Console.WriteLine("Let's play: [r]ock, [p]aper, [s]cissors.");
    string input = Console.ReadLine().ToLower();
    // Validate the user's input
    while (input != "r" && input != "p" && input != "s")
    {
        Console.WriteLine("Invalid input. Please try again.");
        input = Console.ReadLine().ToLower();
    }

    // Generate a random number between 0 and 2 for the computer's choice
    Random rand = new Random();
    int computerChoice = rand.Next(0, 3);
    string computerChoiceString = "";
    // 0 = rock, 1 = paper, 2 = scissors
    if (computerChoice == 0)
    {
        computerChoiceString = "rock";
    }
    else if (computerChoice == 1)
    {
        computerChoiceString = "paper";
    }
    else
    {
        computerChoiceString = "scissors";
    }
    Console.WriteLine($"Computer chose {computerChoiceString}");

    // Compare the user's input to the computer's choice
    if (input == computerChoiceString)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (input == "r" && computerChoiceString == "scissors")
    {
        Console.WriteLine("You win!");
        score++;
    }
    else if (input == "p" && computerChoiceString == "rock")
    {
        Console.WriteLine("You win!");
        score++;
    }
    else if (input == "s" && computerChoiceString == "paper")
    {
        Console.WriteLine("You win!");
        score++;
    }
    else
    {
        Console.WriteLine("You lose!");
    }

    // Ask the user if they want to play again
    Console.WriteLine("Play again? (y/n)");
    string playAgain = Console.ReadLine();
    while (playAgain != "y" && playAgain != "n")
    {
        Console.WriteLine("Invalid input. Please enter 'y' or 'n' for yes or no, respectively.");
        playAgain = Console.ReadLine();
    }

    if (playAgain == "n")
    {
        Console.WriteLine($"Final score: {score}");
        isPlaying = false;
    }
    else
    {
        Console.WriteLine($"Score: {score}");
    }
}