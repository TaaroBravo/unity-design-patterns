namespace Patterns.Abstract_Factory
{
    public class FantasyFactory : ICharacterFactory
    {
        public IEnemy CreateEnemy() => new OrcEnemy();
        public IAlly CreateAlly() => new Elf();
    }
}