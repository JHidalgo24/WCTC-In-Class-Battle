using System;

namespace Battle.Models
{
    public class Wendigo:IMonster
    {
        public string Name { get; set; }
        public int HP { get; set; }

        public void Roar()
        {
            Console.WriteLine($"{Name} Roared!");
        }

        public void Stomp()
        {
            Console.WriteLine($"{Name} Stomp");
        }

        public void Spook()
        {
            Console.WriteLine($"{Name} did a Boooooo!");
        }
    }
}