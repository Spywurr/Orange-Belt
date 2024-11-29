namespace Kata_3___Introduction_to_Templates_Generics;

class Program
{
    static void Main(string[] args)
    {
        
        HealAbility heal = new HealAbility("Heal", "Heals for X amount of health");
        AttackAbility attack = new AttackAbility("Attack", "Attacks for X amount of health");
        
        AbilityContainer<IAbility>.AddAbility(heal); 
        AbilityContainer<IAbility>.AddAbility(attack);
        var heal2 = AbilityContainer<IAbility>.RetrieveAbility("Heal");
        
        
        AbilityContainer<IAbility>.PrintAbilities();
    }
}