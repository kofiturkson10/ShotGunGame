public enum ActionType
{
    None,
    Reload,
    Shoot,
    Block,
    Shotgun
}
public static class ActionConverter
{
    public static ActionType ConvertInput(string action)
    {
        if (action == "1")
        {
            return ActionType.Reload;
        }
        else if (action == "2")
        {
            return ActionType.Shoot;
        }
        else if (action == "3")
        {
            return ActionType.Block;
        }

        else if (action == "4")
        {
            return ActionType.Shotgun;
        }
        else
        {
            return ActionType.None;
        }
    }
}
