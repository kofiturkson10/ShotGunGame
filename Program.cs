using System;
class Program
{
    // Fast resultat meny
    public static void GameStatus(Player player, Player computer)
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Player: {player.Name,-10} Player: {computer.Name}");
        Console.WriteLine($"Ammo:   {player.Ammo,-10} Ammo:   {computer.Ammo}");
        Console.WriteLine("--------------------------------------------------");
    }
    public static void Main()
    {
        Console.WriteLine("\n=== Shotgun Game ===");
        Console.WriteLine("\nEnter a name: ");
        string? name = Console.ReadLine();

        Player player = new Player(name);
        Computer computer = new Computer();
        Game game = new Game(player, computer);

        Console.Clear();

        while (true)
        {

            Console.Clear();

            Console.WriteLine("\n=== Shotgun Game ===");
            GameStatus(player, computer);

            Console.Write("\nChoose action: (1) Reload (2) Shoot (3) Block ");
            if (player.CanShotgun())
            {
                Console.WriteLine("(4) Shotgun");
            }

            Console.WriteLine();

            string action = InvalidType.WrongType();

            // Förenkla den här delen

            ActionType playerChoice = ActionType.None;

            if (action == "1") playerChoice = ActionType.Reload;

            else if (action == "2") playerChoice = ActionType.Shoot;

            else if (action == "3") playerChoice = ActionType.Block;

            else if (action == "4") playerChoice = ActionType.Shotgun;

            Console.Clear();

            Console.WriteLine("\n=== Shotgun Game ===");
            GameStatus(player, computer);

            bool gameOver = game.PlayRound(playerChoice);

            if (gameOver) break;

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

        }
    }
}
