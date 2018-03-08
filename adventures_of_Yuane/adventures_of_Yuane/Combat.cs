using System;
using System.Reflection;

namespace adventures_of_Yuane
{
    public class Combat
    {
        private static readonly Random _random = new Random();
        public static void PlayerAction(Player player, Character enemy)
        {
            Console.WriteLine("Make a choice!");
            Console.WriteLine("Attack, Run");
            var choice = Console.ReadLine().ToLower();
            Console.WriteLine();
            switch (choice)
            {
                case "attack":
                    Attack(player, enemy);
                    break;
                case "run":
                    Console.WriteLine("You can't run yet. ;)");
                    break;
            }

        }

        public static void EnemyAction(Character enemy, Player player)
        {
            var enemychoice = _random.Next(0, 1);
            switch (enemychoice)
            {
                case 0:
                    Attack(enemy, player);
                    break;
                case 1:
                    Console.WriteLine($"{enemy.name} stands there... menacingly.");
                    break;
            }
        }

        public static void DisplayHp(Player player, Character enemy)
        {
            Console.WriteLine($"{player.name} Hp: {player.Hp} VS {enemy.name} Hp: {enemy.Hp}");
        }

        public static void Attack(Character attacker, Character target)
        {;
            var damage = _random.Next(attacker.Str / 2, attacker.Str);
            var defended = _random.Next(target.Def / 10, target.Def / 5);
            var damageDealt = damage - defended;

            target.Hp -= damageDealt;
            Console.WriteLine($"{attacker.name} attacked {target.name} for {damageDealt} damage!");
        }
        public static void Battle(Player player, Character enemy)
        {
            while (player.Hp > 0 && enemy.Hp > 0)
            {
                PlayerAction(player, enemy);
                if (enemy.Hp < 0)
                {
                    Console.WriteLine($"{enemy.name} has been defeated.");
                    break;
                }
            EnemyAction(enemy, player);
                if (player.Hp < 0)
                {
                    Console.WriteLine($"{player.name} has been defeated.");
                    break;
                }

                DisplayHp(player, enemy);
                Console.WriteLine();
            }
        }
    }
}