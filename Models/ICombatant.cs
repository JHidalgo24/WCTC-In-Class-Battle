namespace Battle.Models
{
    public interface ICombatant {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        void Attack(ICombatant enemy);
        void Defend(ICombatant enemy);
        void Dodge(ICombatant enemy);
        void Scared(IMonster monster);
    }
}