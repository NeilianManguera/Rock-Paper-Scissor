string inputPlayer, inputCPU;
int randomInt;

bool playAgain = true;

while (playAgain)
{
    int scorePlayer = 0;
    int scoreCPU = 0;

    while (scorePlayer < 3 && scoreCPU < 3)
    {
        Console.Write("Choose Rock, Paper or Scissor:     ");
        inputPlayer = Console.ReadLine();
        inputPlayer =  inputPlayer.ToUpper();

        Random rnd = new Random();

        randomInt = rnd.Next(1, 4);

        switch (randomInt)
        {
            case 1:
                inputCPU = "ROCK";
                Console.WriteLine("Computer is Rock!");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("Draw!\n\n");
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("You win!\n\n");
                    scorePlayer++;
                }
                else if (inputPlayer == "SCISSOR")
                {
                    Console.WriteLine("Computer win!\n\n");
                    scoreCPU++;
                }
                break;
            case 2:
                inputCPU = "PAPER";
                Console.WriteLine("Computer is Paper!");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("Computer win!\n\n");
                    scoreCPU++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("Draw!\n\n");
                }
                else if (inputPlayer == "SCISSOR")
                {
                    Console.WriteLine("You win!\n\n");
                    scorePlayer++;
                }
                break;
            case 3:
                inputCPU = "SCISSOR";
                Console.WriteLine("Computer is Scissor!");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("You win!\n\n");
                    scorePlayer++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("Computer win!\n\n");
                    scoreCPU++;
                }
                else if (inputPlayer == "SCISSOR")
                {
                    Console.WriteLine("Draw!\n\n");
                }
                break;
            default:
                Console.WriteLine("Invalid Entry");
                break;
        }

        Console.WriteLine("\n\nYour Score: {0}   Computer  Score: {1}", scorePlayer, scoreCPU);
    }

    if (scorePlayer == 3)
    {
        Console.WriteLine("Congratulation!!! YOU WON!");
    }
    else if (scoreCPU == 3)
    {
        Console.WriteLine("Sorry! YOU LOOSE");
    }
    else
    {

    }
    Console.WriteLine("Do you want to play again?(y/n)");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        playAgain = true;
        Console.Clear();
    }
    else if(loop == "n")
    {
        playAgain=false;
    }
    else
    {

    }
}