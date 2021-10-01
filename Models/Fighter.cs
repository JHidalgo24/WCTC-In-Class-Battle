using System;

namespace Battle.Models
{
    public class Fighter : ICombatant
    {
        public Fighter()
        {
            Name = "Fighter";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

        public void Attack(ICombatant enemy)
        {
            if (Weapon.Power > enemy.Armor.Defense)
                Console.WriteLine($"{Name} attacks {enemy.Name} with his {Weapon.Name}");
            else
                Console.WriteLine($"{enemy.Name} blocks {Name} with his {enemy.Armor.Name}");
        }

        public void Defend(ICombatant enemy)
        {
            if (enemy.Weapon.Power < 5)
            {
                Console.WriteLine("You defended against the enemy");
            }
            else
            {
                Console.WriteLine("You got whacked!");
            }
        }

        public void Dodge(ICombatant enemy)
        {
            if (enemy.Weapon.Power < 5)
            {
                Console.WriteLine("You dodged against the enemy hit");
            }
            else
            {
                Console.WriteLine($"You got hit in the knee! by {enemy.Name}");
            }
        }

        public void Scared(IMonster monster)
        {
            if (monster.HP > this.Armor.Defense)
            {
                Console.WriteLine("The monster scared you with his spook, you pass out");
            }
            else
            {
                Console.WriteLine($"{monster.Name} tried to scare you but it was tiny and weak and only had {monster.HP} health. You punted it!");
            }
        }
    }
}