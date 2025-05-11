using UnityEngine;

namespace Patterns.Decorator
{
    public class Weapon : MonoBehaviour
    {
        void Start()
        {
            Projectile p = new BasicProjectile();
            p = new FireDecorator(p);
            p = new PoisonDecorator(p);

            p.Fire();
            // Output:
            // Fires basic projectile.
            // Applies fire damage.
            // Applies poison effect.
        }
    }
}