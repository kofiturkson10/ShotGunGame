class Program
{
    static void Main()
    {
        // Start menu
        Console.WriteLine("\n=== Shotgun Game ===");
        string playerName = InvalidType.GetPlayerName();

        Player player = new Player(playerName);
        Computer computer = new Computer();
        Game game = new Game(player, computer);

        Console.Clear();

        // Main game loop
        while (true)
        {
            Info.GameStatus(player, computer); // Information screen for game mode.

            Console.Write("\nChoose action: (1) Reload (2) Shoot (3) Block "); // Player chooses action.
            if (player.CanShotgun())
            {
                Console.WriteLine("(4) Shotgun");
            }

            Console.WriteLine();

            string action = InvalidType.GetValidAction(player.CanShotgun());

            ActionType playerAction = ActionConverter.ConvertInput(action);

            Console.Clear();

            Info.GameStatus(player, computer); // Information screen for game mode.

            // Game over!
            bool gameOver = game.PlayRound(playerAction);
            bool continueGame = RestartGame.GameOver(gameOver, player, computer);

            if (!continueGame)
            {
                break;
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
