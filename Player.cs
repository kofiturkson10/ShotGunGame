class Player
{
    // Basic player setup. Players name and ammo.
    public string Name { get; }
    public int Ammo { get; private set; } // Player ammo is only modifiable by the player methods.
    public Player(string name)
    {
        Name = name;
        Ammo = 0;
    }
    // Reloads the gun
    public void Reload()
    {
        Ammo++;
    }
    // Shooting the gun. Only possible when loaded.
    public void Shoot()
    {
        if (Ammo > 0)
        {
            Ammo--;
        }
    }
    // Using the Shotgun action. 
    public void Shotgun()
    {
        if (Ammo >= 3)
        {
            Ammo = 0;
        }
    }
    // When it's possible to shoot.
    public bool CanShoot()
    {
        if (Ammo > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // Only possible to use Shotgun with 3 bullets in the clip.
    public bool CanShotgun()
    {
        if (Ammo >= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // Resets the ammo to 0. 
    public void Reset()
    {
        Ammo = 0;
    }
}