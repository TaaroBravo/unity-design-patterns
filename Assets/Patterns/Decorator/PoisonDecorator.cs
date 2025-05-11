using UnityEngine;

namespace Patterns.Decorator
{
    public class PoisonDecorator : ProjectileDecorator
    {
        public PoisonDecorator(Projectile wrapped) : base(wrapped) { }

        public override void Fire()
        {
            _wrapped.Fire();
            Debug.Log("Applies poison effect.");
        }
    }
}