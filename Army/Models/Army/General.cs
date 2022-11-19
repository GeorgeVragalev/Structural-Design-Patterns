namespace Army.Models.Army;

public class General : ISoldier, ICommander
{
    private readonly string _name;
    private readonly Role _role;
    private readonly IList<ISoldier> _commanders = new List<ISoldier>();

    public General(string name, Role role)
    {
        _name = name;
        _role = role;
    }

    public string Salute()
    {
        return $"Greetings! I am {_name} and I am a {_role}. I have {_commanders.Count} commanders at my command.";
    }

    public string Attack()
    {
        var attack = $"I {_name} {_role} am planning an attack with my army\n";
        foreach (var comander in _commanders)
        {
            attack += comander.Attack();
        }

        return attack;
    }
    public string Defend()
    {
        var defend = $"I {_name} {_role} am resisting an attack with my army\n";
        foreach (var comander in _commanders)
        {
            defend += comander.Defend();
        }

        return defend;    
    }
    
    public void Add(ISoldier soldier)
    {
        _commanders.Add(soldier);   
    }

    public void Remove(ISoldier soldier)
    {
        _commanders.Remove(soldier);
    }

    public ISoldier? GetSoldier(ISoldier soldier)
    {
        return _commanders.FirstOrDefault(s => s == soldier);
    }
}