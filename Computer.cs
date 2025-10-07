class Computer : Player   // Simple AI. Inherits from the Player class.
{
    private static readonly Random random = new Random();
    public Computer() : base("Computer") { } // Set's the name for the AI

    public ActionType ChooseAction(Player opponent)
    {
        // AI reloads if the player has no ammo. 
        if (Ammo == 0 && opponent.Ammo == 0)
        {
            return ActionType.Reload;
        }

        // Tells the AI to use when it's possible.
        if (CanShotgun())
        {
            return ActionType.Shotgun;
        }

        // If the AI can't shoot it will randomly choose between block and reload.
        if (!CanShoot())
        {
            int roll = random.Next(2);

            switch (roll)
            {
                case 0:
                    return ActionType.Reload;
                case 1:
                    return ActionType.Block;
                default:
                    return ActionType.None;
            }
        }

        // Else randomly select reload, block or shoot.
        int roll2 = random.Next(3);
        {
            switch (roll2)
            {
                case 0:
                    return ActionType.Reload;
                case 1:
                    return ActionType.Block;
                case 2:
                    return ActionType.Shoot;
                default:
                    return ActionType.None;
            }
        }
    }
}