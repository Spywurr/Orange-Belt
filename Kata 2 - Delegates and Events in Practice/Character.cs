namespace Orange_Belt;

public class Character
{
    public string Name;
    private int _health;
    public int Damage;

    public int Health
    {
        get => _health;
        set
        {
            _health = value;
            HealthChanged?.Invoke(value);
        }
    }

    public Character(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    
    public Action<Character> PrimaryAction;
    public event Action<int> HealthChanged;
    public void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage.");
        target.Health -= Damage;
    }
    public void Heal()
    {
        int healAmount = 15;
        Console.WriteLine($"{Name} heals for {healAmount} Health.");
        Health += healAmount;
    }
}