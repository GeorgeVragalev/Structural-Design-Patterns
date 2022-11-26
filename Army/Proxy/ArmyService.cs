using Army.Models.Army;

namespace Army.Proxy;

public class ArmyService : IArmy
{
    private readonly IArmy Army;

    public ArmyService(IArmy army)
    {
        this.Army = army;
    }

    public string Attack()
    {
        //attacking with the class army
        return Army.Attack();
    }

    public string Defend()
    {
        return Army.Defend();
    }
}