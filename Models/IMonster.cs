namespace Battle.Models
{
    public interface IMonster 
    {
        public string Name {get;set;}
        public int HP { get; set; }

        void Roar();
        void Stomp();
        void Spook();
        void Hide();
    }
}