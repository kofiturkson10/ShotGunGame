class Game
{
    private readonly Player player;
    private readonly Computer computer;

    public Game(Player player, Computer computer)
    {
        this.player = player;
        this.computer = computer;
    }

    public bool PlayRound(ActionType playerAction)
    {
        // Hindrar spelaren från att skjuta om det inte går. Shotgun/Shoot.

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

        var computerAction = computer.ChooseAction();

        // Här börjar spelet.

        if (playerAction == ActionType.Shotgun && computerAction == ActionType.Shotgun)
        {
            player.Shotgun();
            computer.Shotgun();
            Console.WriteLine($"Game continues! Both {player.Name} & {computer.Name} used Shotgun! ");
            return false;
        }
        else if (playerAction == ActionType.Shotgun)
        {
            player.Shotgun();
            Console.WriteLine($"BOOM!! Shotgun! {player.Name} Wins the game!! ");
            return true;
        }
        else if (computerAction == ActionType.Shotgun)
        {
            computer.Shotgun();
            Console.WriteLine($"BOOM! Shotgun! {computer.Name} wins the game! Game over! ");
            return true;
        }

        if (playerAction == ActionType.Shoot && computerAction == ActionType.Reload)
        {
            player.Shoot();
            Console.WriteLine($"Bang! {player.Name} wins the game! {computer.Name} reloaded.");
            return true;
        }

        if (playerAction == ActionType.Reload && computerAction == ActionType.Shoot)
        {
            computer.Shoot();
            Console.WriteLine($"Bang! {computer.Name} wins the game! {player.Name} reloaded.");
            return true;
        }
        else if (playerAction == ActionType.Reload && computerAction == ActionType.Reload)
        {
            player.Reload();
            computer.Reload();
            Console.WriteLine($"Both {player.Name} & {computer.Name} reloaded... ");
            return false;
        }
        else if (playerAction == ActionType.Reload && computerAction == ActionType.Block)
        {
            player.Reload();
            Console.WriteLine($"{player.Name} reloaded. {computer.Name} blocks! ");
            return false;
        }
        else if (playerAction == ActionType.Block && computerAction == ActionType.Reload)
        {
            computer.Reload();
            Console.WriteLine($"{computer.Name} reloaded. {player.Name} blocks! ");
            return false;
        }
        else if (playerAction == ActionType.Block && computerAction == ActionType.Block)
        {
            Console.WriteLine($"Both {player.Name} and {computer.Name} blocked! ");
            return false;

        }
        else if (playerAction == ActionType.Shoot && computerAction == ActionType.Shoot)
        {
            player.Shoot();
            computer.Shoot();
            Console.WriteLine($"Both {player.Name} & {computer.Name} shoots! ");
            return false;
        }
        else if (playerAction == ActionType.Shoot && computerAction == ActionType.Block)
        {
            player.Shoot();
            Console.WriteLine($"{player.Name} shoots. {computer.Name} blocks! ");
            return false;
        }
        else if (playerAction == ActionType.Block && computerAction == ActionType.Shoot)
        {
            computer.Shoot();
            Console.WriteLine($"{computer.Name} shoots. {player.Name} blocks! ");
            return false;
        }


        return false;

    }
}