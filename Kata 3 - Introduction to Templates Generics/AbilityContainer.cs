namespace Kata_3___Introduction_to_Templates_Generics;

public static class AbilityContainer<T> where T : IAbility
{
    private static List<T> _abilities = new();
    
    public static void AddAbility(T ability)
    {
        _abilities.Add(ability);
    }

    public static void RemoveAbility(T ability)
    {
        _abilities.Remove(ability);
    }

    public static T RetrieveAbility(string key)
    {
        
        return _abilities.FirstOrDefault(X => X.Name.Equals(key));
    }

    public static void PrintAbilities()
    {
        foreach (var ability in _abilities)
            Console.WriteLine(ability.Name);
    }
    
}
