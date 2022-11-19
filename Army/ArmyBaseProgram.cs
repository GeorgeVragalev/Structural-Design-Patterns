namespace Army;

public static class ArmyBaseProgram
{
    public static void Main(string[] args)
    {
        int soldiers = 5;
        int commanders = 2;
        int generals = 1;
        int weapons = 10;
        
        var armyFactory = new ArmyFactory.ArmyFactory();
        var army = armyFactory.CreateArmy(soldiers, commanders, generals, weapons);

        Console.WriteLine(army.Attack());

        Console.WriteLine(army.Defend());

        var weaponsStack = army.GetWeapons();

        Console.WriteLine(weaponsStack.CheckWeapons());
        Console.WriteLine(weaponsStack.CleanWeapons());
    }
}