namespace Patterns.Abstract_Factory
{
    public interface ICharacterFactory
    {
        IEnemy CreateEnemy();
        IAlly CreateAlly();
    }
}