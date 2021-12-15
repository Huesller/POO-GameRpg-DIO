// See https://aka.ms/new-console-template for more information

using ProjetoGameDIO.src.Entities;
{
    Knight knight = new Knight("Arus", 52, "Knight", 2250);
    Wizard wizard = new Wizard("Jennica", 58, "White Wizard", 1200);
    Ninja ninja = new Ninja("Madara", 70, "Ninja,", 2500);
    BlackWizard blackwizard = new BlackWizard("Momonga", 99, "Black Wizard", 5250);
    Boss boss = new Boss("Lord Faranis", 300, "Devil", 85000);

    Console.WriteLine(knight);
    Console.WriteLine(knight.Attack());
    Console.WriteLine(knight.Attack(8));
    Console.WriteLine(knight.Attack(20));
    Console.WriteLine("\n");

    Console.WriteLine(wizard);
    Console.WriteLine(wizard.Attack());
    Console.WriteLine(wizard.Attack(3));
    Console.WriteLine(wizard.Attack(9));
    Console.WriteLine("\n");

    Console.WriteLine(ninja);
    Console.WriteLine(ninja.Attack());
    Console.WriteLine(ninja.Attack(52));
    Console.WriteLine(ninja.Attack(11));
    Console.WriteLine("\n");

    Console.WriteLine(blackwizard);
    Console.WriteLine(blackwizard.Attack());
    Console.WriteLine(blackwizard.Attack(230));
    Console.WriteLine(blackwizard.Attack(25));
    Console.WriteLine("\n");

    Console.WriteLine(boss);
    Console.WriteLine(boss.Attack());
    Console.WriteLine(boss.Attack(120));
    Console.WriteLine(boss.Attack(550));
    
        
}