public enum ActionType
{
    None, // default.
    Reload, // +1 ammo.
    Shoot, // -1 ammo (demands ammo > 0)
    Block, // Blocks opponents shot.
    Shotgun // Winning move (>= 3 ammo)
}

// Converts users menu choise from (string) to ActionType
public static class ActionConverter
{
    public static ActionType ConvertInput(string action)
    {
        switch (action)
        {
            case "1":
                return ActionType.Reload;
            case "2":
                return ActionType.Shoot;
            case "3":
                return ActionType.Block;
            case "4":
                return ActionType.Shotgun;
            default:
                return ActionType.None;
        }
    }
}