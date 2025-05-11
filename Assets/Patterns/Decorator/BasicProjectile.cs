using UnityEngine;

namespace Patterns.Decorator
{
    public class BasicProjectile : Projectile
    {
        public override void Fire() => Debug.Log("Fires basic projectile.");
    }
}