namespace Patterns.Decorator
{
    public abstract class ProjectileDecorator : Projectile
    {
        protected Projectile _wrapped;

        public ProjectileDecorator(Projectile wrapped)
        {
            _wrapped = wrapped;
        }
    }
}