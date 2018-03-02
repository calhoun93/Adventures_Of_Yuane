using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventures_of_Yuane
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Character();

            Console.WriteLine("What's your name?");
            player.name = Console.ReadLine();
            

            Console.WriteLine("Character Name :" + player.name);
            Console.WriteLine("Character Health :" + player.hp);
            Console.WriteLine("Character Strength :" + player.str);

            Console.ReadKey();
        }
    }
    public class Character
    {
        public string name;
        public int hp;
        public int str;
    }
}
