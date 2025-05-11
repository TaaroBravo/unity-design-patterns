namespace Patterns.Abstract_Factory
{
    public class SciFiFactory : ICharacterFactory
    {
        public IEnemy CreateEnemy() => new Robot();
        public IAlly CreateAlly() => new MedicDrone();
    }
}