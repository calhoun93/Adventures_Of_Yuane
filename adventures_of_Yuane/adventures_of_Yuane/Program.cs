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
            Combat.Battle(player, enemy);
            Console.Write("End of program, press a key to exit");
        }
    }
    public class Character
    {
        public string name;
        public int Hp = 100;
        public int Str = 10;
        public int Def = 10;
    }
}
