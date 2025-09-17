class InvalidType
{
    // inmatningsfel action
    public static string WrongType()
    {
        while (true)
        {
            string? action = Console.ReadLine();

            if (action == "1" || action == "2" || action == "3" || action == "4")
                return action;

            Console.WriteLine("Invalid action! Try again.");
        }
    }
}