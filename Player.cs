class Player
{
    public string Name { get; }
    public int Ammo { get; private set; }
    public Player(string name)
    {
        Name = name;
        Ammo = 0;
    }
    // Metoder för Player
    public void Reload()
    {
        Ammo++;
    }
    public void Shoot()
    {
        if (Ammo > 0)
        {
            Ammo--;
        }
    }

    public void Shotgun()
    {
        if (Ammo >= 3)
        {
            Ammo = 0;
        }
    }
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
    public void Reset()
    {
        Ammo = 0;
    }
}