namespace Battle.Models
{
    public class Enemy : ICombatant
    {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public Enemy()
        {
            Name = "Enemy";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public void Attack(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Dodge(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Scared(IMonster monster)
        {
            throw new System.NotImplementedException();
        }
    }
}