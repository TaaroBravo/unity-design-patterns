using System;
using UnityEngine;

namespace Patterns.Pool
{
    public class Bullet : MonoBehaviour
    {
        private float _timeAlive;
        private Action<Bullet> _onDestroy;

        public void Initialize(Action<Bullet> onDestroy)
        {
            _timeAlive = 0;
            _onDestroy = onDestroy;
            transform.position = Vector3.zero;
        }
        
        private void Update()
        {
            _timeAlive += Time.deltaTime;
            if (_timeAlive > 5)
            {
                _timeAlive = 0;
                _onDestroy(this);
            }
            transform.position += transform.forward * 5 * Time.deltaTime;
        }
    }
}