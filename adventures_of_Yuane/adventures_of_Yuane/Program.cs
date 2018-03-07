using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventures_of_Yuane
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player().Create();

            var enemy = new Character {name = "Goblin Bully"};
            
            Console.WriteLine($"A {enemy.name} appeared!");
            Console.ReadKey();
        }
    }
    public class Character
    {
        public string name;
        public int Hp = 100;
        public int Str = 10;
        public int Def = 10;
    }

    public class Player : Character
    {
        int points = 100;

        public void DisplayStats()
        {
            Console.WriteLine($"{name} Hp  : {Hp}");
            Console.WriteLine($"{name} Str : {Str}");
            Console.WriteLine($"{name} Def : {Def}");
            Console.WriteLine();
        }

        public void SpendPoints()
        {
            string choice = "default";
            while (this.points > 0 || choice == "cancel")
            {
                DisplayStats();
                Console.WriteLine($"You have {points} to spend on your stats!");
                Console.WriteLine("How many points would you like to spend?");
                var spend = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Where would you like to spend your {spend} points?");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "hp":
                        Hp += spend;
                        points -= spend;
                        break;
                    case "str":
                        Str += spend;
                        points -= spend;
                        break;
                    case "def":
                        Str += spend;
                        points -= spend;
                        break;
                    case "cancel":
                        break;
                }
                Console.WriteLine();
            }
        }
        public Player Create()
        {
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine();
            SpendPoints();
            DisplayStats();
            return this;
        }

    }
}
