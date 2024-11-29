using Orange_Belt;


Character character1 = new Character("Arin", 100, 10);
Character character2 = new Character("Dalia", 100, 10);
character1.HealthChanged += value => Console.WriteLine($"{character1.Name}'s health changed to {character1.Health}"); 
character2.HealthChanged += value => Console.WriteLine($"{character2.Name}'s health changed to {character2.Health}");

character1.PrimaryAction += target => character1.Attack(target);
character1.PrimaryAction(character2);
Console.WriteLine();
character2.PrimaryAction += target => character2.Heal();
character2.PrimaryAction(character2);
 
