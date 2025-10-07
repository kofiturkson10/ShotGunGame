class Info
{
    // Status bar (GameStatus)
    public static void GameStatus(Player player, Player computer)
    {
        Console.WriteLine("\n=== Shotgun Game ===");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Player: {player.Name,-10} Computer: {computer.Name}");
        Console.WriteLine($"Ammo:   {player.Ammo,-10} Ammo:   {computer.Ammo}");
        Console.WriteLine("--------------------------------------------------");
    }
}
