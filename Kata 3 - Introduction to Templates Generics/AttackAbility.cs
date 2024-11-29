namespace Kata_3___Introduction_to_Templates_Generics;

public class AttackAbility : IAbility
{
    public string Name { get; }
    public string Effect { get; }

    public AttackAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}