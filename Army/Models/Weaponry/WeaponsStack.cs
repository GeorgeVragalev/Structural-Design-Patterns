namespace Army.Models.Weaponry;

//Bridge pattern
public class WeaponsStack : IStatistics
{
    private readonly IList<IWeapon> _weapons;
    
    public WeaponsStack(IList<IWeapon> weapons)
    {
        _weapons = weapons;
    }
    
    public string Count()
    {
        return $"There are {_weapons.Count} weapons in storage\n";
    }

    public string CheckWeapons()
    {
        var results = $"Testing weapons in storage \n";
        foreach (var weapon in _weapons)
        {
            results += weapon.Test();
        }

        return results;
    }
    
    public string FireWeapons()
    {
        var results = $"Firing weapons\n";
        foreach (var weapon in _weapons)
        {
            results += weapon.Fire();
        }

        return results;
    }
    
    public string CleanWeapons()
    {
        var results = $"Cleaning weapons in storage \n";
        foreach (var weapon in _weapons)
        {
            results += weapon.Clean();
        }

        return results;
    }
}