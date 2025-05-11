using UnityEngine;

namespace Patterns.Abstract_Factory
{
    public class GameSetup : MonoBehaviour
    {
        private void Start()
        {
            ICharacterFactory factory = new FantasyFactory(); 

            IEnemy enemy = factory.CreateEnemy();
            IAlly ally = factory.CreateAlly();

            enemy.Attack();
            ally.Heal();
        }
    }
}