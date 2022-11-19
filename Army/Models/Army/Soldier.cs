namespace Army.Models.Army;

public class Soldier : ISoldier
{
    private readonly string _name;
    private readonly Role _role;

    public Soldier(string name, Role role)
    {
        _name = name;
        _role = role;
    }

    public string Salute()
    {
        return $"Greetings! I am {_name} and I have the role of a {_role}\n";
    }

    public string Attack()
    {
        return $"{_name} is attacking!\n";
    }

    public string Defend()
    {
        return $"{_name} is defending!\n";
    }
}