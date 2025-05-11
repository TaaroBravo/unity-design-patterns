using UnityEngine;

namespace Patterns.Decorator
{
    public class FireDecorator : ProjectileDecorator
    {
        public FireDecorator(Projectile wrapped) : base(wrapped) { }

        public override void Fire()
        {
            _wrapped.Fire();
            Debug.Log("Applies fire damage.");
        }
    }
}