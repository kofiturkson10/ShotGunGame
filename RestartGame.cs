class RestartGame
{
    // Handles GameOver
    public static bool GameOver(bool gameOver, Player player, Computer computer)
    {
        if (gameOver)
        {
            bool restart = AskPlayAgain(player, computer);
            return restart;
        }

        return true;
    }

    // Restart mode. Asks the player to play again or to exit the game.
    public static bool AskPlayAgain(Player player, Computer computer)
    {
        Console.WriteLine("\nPress (1) to play again. Press (2) to Exit");
        string? playAgain = Console.ReadLine();

        while (playAgain != "1" && playAgain != "2")
        {
            Console.Clear();
            Info.GameStatus(player, computer);
            Console.WriteLine("Invalid input! Press (1) to play again. Press (2) to Exit");
            playAgain = Console.ReadLine();
        }

        switch (playAgain)
        {
            case "1":
                Console.Clear();
                player.Reset();
                computer.Reset();
                return true;

            case "2":
            default:
                Console.Clear();
                return false;
        }
    }

}