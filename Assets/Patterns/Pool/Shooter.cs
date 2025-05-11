using System;
using UnityEngine;

namespace Patterns.Pool
{
    public class Shooter : MonoBehaviour
    {
        public Bullet bulletPrefab;

        private ObjectPool<Bullet> _pool;

        private void Awake()
        {
            _pool = new ObjectPool<Bullet>(GetNewBullet, Prender, Apagar, 10);
        }

        private void Prender(Bullet obj)
        {
            obj.gameObject.SetActive(true);
        }

        private void Apagar(Bullet obj)
        {
            obj.gameObject.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                CreateBullet();
        }

        private void CreateBullet()
        {
            var bullet = _pool.GetObject();
            bullet.Initialize(DestroyBullet);
        }

        private Bullet GetNewBullet()
        {
            return Instantiate(bulletPrefab);
        }

        private void DestroyBullet(Bullet bullet)
        {
            _pool.ReturnObject(bullet);
        }
    }
}