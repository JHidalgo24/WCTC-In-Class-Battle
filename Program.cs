using Battle.Models;

namespace Battle
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create Fighter (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            ICombatant fighter = new Fighter();
            fighter.Armor.Defense = 10;
            fighter.Weapon.Power = 10;

            // Create Enemy (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            ICombatant enemy = new Enemy();
            enemy.Armor.Defense = 8;
            enemy.Weapon.Power = 10;

            // Attack Enemy (execute method)
            fighter.Attack(enemy);
            fighter.Dodge(enemy);
            IMonster Wendigo = new Wendigo();
            Wendigo.Name = "Wendigo";
            Wendigo.HP = 5;
            Wendigo.Roar();
            Wendigo.Spook();
            fighter.Scared(Wendigo);

            //IRepository repos = new JsonRepository();
            
            // all i care about is that I retrieved a movie
            // from where?  who cares!
            //var movie = repos.Get(1);
        }
    }
}