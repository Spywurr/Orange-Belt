using System.ComponentModel;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic;

namespace Kata_1_Lambdas_and_Actions_in_Practice;

class Program
{
    static void Main()
    {
        // Create some characters
        var healer = new Characters("Healer1", 60, Characters.Role.Healer);
        var warrior1 = new Characters("Warrior1", 29, Characters.Role.Warrior);
        var warrior2 = new Characters("Warrior2", 80, Characters.Role.Warrior);
        
        // Perform actions
        healer.PerformAction();
        warrior1.PerformAction();
        warrior2.PerformAction();
    }
}