class Computer : Player   // Ärver från klassen Player.
{
    private static readonly Random random = new Random();
    public Computer() : base("Computer")
    {
        // Endast namn för datorn.
    }
    // Datorns actions. 
    public ActionType ChooseAction()
    {
        if (CanShotgun())
        {
            return ActionType.Shotgun;
        }

        if (!CanShoot())
        {
            int roll = random.Next(2);
            if (roll == 0)
                return ActionType.Reload;
            else
                return ActionType.Block;
        }

        int roll2 = random.Next(3);
        {
            if (roll2 == 0)
                return ActionType.Reload;
            else if (roll2 == 1)
                return ActionType.Block;
            else if (roll2 == 2)
                return ActionType.Shoot;
            else
                return ActionType.None;
        }
    }
}