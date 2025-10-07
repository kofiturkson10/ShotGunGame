using System.Security;

class Game
{
    private readonly Player player;    // Human player
    private readonly Computer computer; // AI
    public Game(Player player, Computer computer)
    {
        this.player = player;
        this.computer = computer;
    }

    // Plays a round based on the players choice. Returns true if the game is decided.
    public bool PlayRound(ActionType playerAction)
    {
        // Rule check. Blocks impossible actions.
        if (playerAction == ActionType.Shoot && !player.CanShoot())
        {
            Console.WriteLine("Unable to Shoot. You have no bullets!");
            return false;
        }
        else if (playerAction == ActionType.Shotgun && !player.CanShotgun())
        {
            Console.WriteLine("Unable to use Shotgun. You need 3 bullets.");
            return false;
        }

        // AI chooses action after player action is confirmed.
        var computerAction = computer.ChooseAction(player);

        // ------ Round according to the rules ------
        switch ((playerAction, computerAction))
        {
            case (ActionType.Shotgun, ActionType.Shotgun):
                player.Shotgun();
                computer.Shotgun();
                Console.WriteLine($"Game continues! Both {player.Name} & {computer.Name} used Shotgun! ");
                return false;

            case (ActionType.Shotgun, _):
                player.Shotgun();
                Console.WriteLine($"BOOM!! Shotgun! {player.Name} Wins the game!! ");
                return true;

            case (_, ActionType.Shotgun):
                computer.Shotgun();
                Console.WriteLine($"BOOM! Shotgun! {computer.Name} wins the game! Game over! ");
                return true;

            case (ActionType.Shoot, ActionType.Reload):
                player.Shoot();
                Console.WriteLine($"Bang! {player.Name} wins the game! {computer.Name} reloaded.");
                return true;

            case (ActionType.Reload, ActionType.Shoot):
                computer.Shoot();
                Console.WriteLine($"Bang! {computer.Name} wins the game! {player.Name} reloaded.");
                return true;

            case (ActionType.Reload, ActionType.Reload):
                player.Reload();
                computer.Reload();
                Console.WriteLine($"Both {player.Name} & {computer.Name} reloaded... ");
                return false;

            case (ActionType.Reload, ActionType.Block):
                player.Reload();
                Console.WriteLine($"{player.Name} reloaded. {computer.Name} blocks! ");
                return false;

            case (ActionType.Block, ActionType.Reload):
                computer.Reload();
                Console.WriteLine($"{computer.Name} reloaded. {player.Name} blocks! ");
                return false;

            case (ActionType.Block, ActionType.Block):
                Console.WriteLine($"Both {player.Name} and {computer.Name} blocked! ");
                return false;

            case (ActionType.Shoot, ActionType.Shoot):
                player.Shoot();
                computer.Shoot();
                Console.WriteLine($"Both {player.Name} & {computer.Name} shoots! ");
                return false;

            case (ActionType.Shoot, ActionType.Block):
                player.Shoot();
                Console.WriteLine($"{player.Name} shoots. {computer.Name} blocks! ");
                return false;

            case (ActionType.Block, ActionType.Shoot):
                computer.Shoot();
                Console.WriteLine($"{computer.Name} shoots. {player.Name} blocks! ");
                return false;

            default:
                return false;
        }
    }
}