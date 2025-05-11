using UnityEngine;

namespace Patterns.Factory
{
    public abstract class Enemy : MonoBehaviour
    {
        public abstract void Attack();
    }

    public class Orc : Enemy
    {
        public override void Attack() => Debug.Log("Orc attacks with axe!");
    }

    public class Goblin : Enemy
    {
        public override void Attack() => Debug.Log("Goblin attacks with dagger!");
    }
}