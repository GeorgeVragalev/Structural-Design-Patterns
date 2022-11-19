namespace Army.Models.Army;

public class Commander : ISoldier, ICommander, IStatistics
{
    private readonly string _name;
    private readonly Role _role;
    private readonly IList<ISoldier> _soldiers = new List<ISoldier>();

    public Commander(string name, Role role)
    {
        _role = role;
        _name = name;
    }

    public string Salute()
    {
        return $"Greetings! I am {_name} and I am a {_role}. {Count()}";
    }

    public string Attack()
    {
        var attack = $"{_name} is planning an attack with my soldiers\n";
        foreach (var soldier in _soldiers)
        {
            attack += $"{soldier.Attack()}\n";
        }

        return attack;
    }

    public string Defend()
    {
        var defend = $"Me and my soldiers are standing our ground!\n";
        foreach (var soldier in _soldiers)
        {
            defend += $"{soldier.Defend()}\n";
        }

        return defend;
    }

    public void Add(ISoldier soldier)
    {
        _soldiers.Add(soldier);   
    }

    public void Remove(ISoldier soldier)
    {
        _soldiers.Remove(soldier);
    }

    public ISoldier? GetSoldier(ISoldier soldier)
    {
        return _soldiers.FirstOrDefault(s => s == soldier);
    }

    public string Count()
    {
        return $"I {_name} have {_soldiers.Count} soldiers at my command.";
    }
}