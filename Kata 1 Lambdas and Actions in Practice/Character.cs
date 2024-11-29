namespace Kata_1_Lambdas_and_Actions_in_Practice;
using System;
using System.Collections.Generic;
using System.Linq;

public class Characters
{
    public enum Role
    {
        Healer = 0,
        Warrior = 1
    }

    public string Name { get; }
    public Role CharacterRole { get; }
    public int Health { get; set; }
    public static List<Characters> AllCharacters { get; } = new List<Characters>();

    public Action PrimaryAction { get; set; }
    public Characters(string name, int health, Role role)
    {
        Name = name;
        Health = health;
        CharacterRole = role;
        AllCharacters.Add(this);

        switch (role)
        {
            case Role.Healer:
                PrimaryAction = () =>
                {
                    var lowHealthCharacters = AllCharacters.Where(c => c.Health < 50).ToList();
                    if (lowHealthCharacters.Any())
                    {
                        foreach (var character in lowHealthCharacters)
                        {
                            Console.WriteLine($"{Name} is healing {character.Name}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nobody needs healing at the moment.");
                    }
                };
                break;
                
            case Role.Warrior:
                PrimaryAction = () =>
                {
                    if (Health < 30)
                    {
                        Console.WriteLine($"{Name} is attacking first due to low health!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} is attacking second due to high health!");
                    }
                };
                break;
        }
    }
    public void PerformAction()
    {
        PrimaryAction.Invoke();
    }
}