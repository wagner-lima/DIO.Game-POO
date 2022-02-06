using DIO.Game_POO.src.Entities;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 28, "Knight", 100, 100);
            Wizard wizard = new Wizard("Jenica", 39, "White Wizard", 80, 250);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 90, 120);

            Console.WriteLine(knight.Attack(1));
            Console.WriteLine(knight.Attack(7));

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));

            Console.WriteLine(ninja.Attack(1));
            Console.WriteLine(ninja.Attack(7));
        }
    }
}