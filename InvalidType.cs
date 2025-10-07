using System.Reflection.Metadata;

class InvalidType
{
    // Checks invalid input for action. It only allows (Shotgun) if it's available to the player
    public static string GetValidAction(bool shotgunAvailable)
    {
        while (true)
        {
            string? action = Console.ReadLine();

            if (action == "1" || action == "2" || action == "3" || action == "4" && shotgunAvailable)
            {
                return action;
            }

            Console.WriteLine("Invalid action! Try again.");
        }
    }

    // Checks invalid input for players name.
    public static string GetPlayerName()
    {
        while (true)
        {
            Console.WriteLine("\nEnter name: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a name...");
                continue;
            }

            return name.Trim();
        }

    }
}