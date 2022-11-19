using Army.Models.Army;
using Army.Models.Weaponry;

namespace Army.ArmyFactory;

public class ArmyFactory
{
    private static int _weaponCount = 0;

    public Soldier CreateSoldier(string name)
    {
        return new Soldier(name, Role.Soldier);
    }

    public Commander CreateCommander(string name)
    {
        return new Commander(name, Role.Commander);
    }

    public General CreateGeneral(string name)
    {
        return new General(name, Role.General);
    }

    public IWeapon CreateWeapon()
    {
        _weaponCount++;
        var weaponType = Random.Shared.Next(1, 5);
        return weaponType != 1
            ? new Firearm((WeaponEnum) Random.Shared.Next(1, 4), _weaponCount)
            : new ColdWeapon((ColdWeaponEnum) Random.Shared.Next(1, 3), _weaponCount);
    }


    public Models.Army.Army CreateArmy(int soldiers, int commanders, int generals, int weapons)
    {
        var generalsList = new List<General>();
        var weaponsList = new List<IWeapon>();

        for (int g = 1; g <= generals; g++)
        {
            var general = CreateGeneral($"General {g}");

            for (int c = 1; c <= commanders; c++)
            {
                var commander = CreateCommander($"Commander {c}");
                general.Add(commander);

                for (int s = 1; s <= soldiers; s++)
                {
                    var soldier = CreateSoldier($"Soldier {s}");
                    commander.Add(soldier);
                }
            }
        }

        for (int w = 1; w <= weapons; w++)
        {
            var weapon = CreateWeapon();
            weaponsList.Add(weapon);
        }

        var weaponsStack = new WeaponsStack(weaponsList);

        var army = new Models.Army.Army(generalsList, "Army 1", weaponsStack);

        return army;
    }
}