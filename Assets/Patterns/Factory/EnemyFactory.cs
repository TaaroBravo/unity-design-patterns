using UnityEngine;

namespace Patterns.Factory
{
    public class EnemyFactory
    {
        private GameObject _orcPrefab;
        private GameObject _goblinPrefab;

        public EnemyFactory(GameObject orcPrefab, GameObject goblinPrefab)
        {
            _orcPrefab = orcPrefab;
            _goblinPrefab = goblinPrefab;
        }

        public Enemy CreateEnemy(string type, Vector3 position)
        {
            GameObject go = null;
            switch (type)
            {
                case "Orc":
                    go = GameObject.Instantiate(_orcPrefab, position, Quaternion.identity);
                    break;
                case "Goblin":
                    go = GameObject.Instantiate(_goblinPrefab, position, Quaternion.identity);
                    break;
                default:
                    Debug.LogError("Unknown enemy type");
                    break;
            }

            return go?.GetComponent<Enemy>();
        }
    }
}