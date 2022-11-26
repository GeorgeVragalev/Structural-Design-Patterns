using Army.Decorator;
using Army.Models.Weaponry;
using Army.Proxy;

namespace Army;

public static class ArmyBaseProgram
{
    public static void Main(string[] args)
    {
        int soldiers = 5;
        int commanders = 2;
        int generals = 1;
        int weapons = 10;
        
        //composite
        var armyFactory = new ArmyFactory.ArmyFactory();
        var army = armyFactory.CreateArmy(soldiers, commanders, generals, weapons);

        //proxy
        var armyService = new ArmyService(army);
        var armyProxy = new ArmyProxy(armyService);
        var armyManager = new ArmyManager(armyProxy);
        Console.WriteLine(armyManager.AttackWithArmy());

        Console.WriteLine(armyManager.DefendWithArmy());

        //bridge
        var weaponsStack = army.GetWeapons();

        Console.WriteLine(weaponsStack.CheckWeapons());
        Console.WriteLine(weaponsStack.CleanWeapons());

        //Decoprator
        var soldier = armyFactory.CreateSoldier("Decorated Soldier");

        var armourDecorator = new OutfitDecorator(soldier);
        Console.WriteLine(armourDecorator.Salute());

        var weaponDecorator = new WeaponDecorator(soldier, new Firearm(WeaponEnum.Gun, 100));

        //Fascade IArmy simple interface
        Console.WriteLine(weaponDecorator.Attack());
        Console.WriteLine(weaponDecorator.Defend());
    }
}