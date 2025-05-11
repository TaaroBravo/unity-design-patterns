using UnityEngine;

namespace Patterns.Factory
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject orcPrefab;
        [SerializeField] private GameObject goblinPrefab;

        private void Start()
        {
            var factory = new EnemyFactory(orcPrefab, goblinPrefab);
            Enemy enemy = factory.CreateEnemy("Orc", new Vector3(0, 0, 0));
            enemy?.Attack();
        }
    }
}