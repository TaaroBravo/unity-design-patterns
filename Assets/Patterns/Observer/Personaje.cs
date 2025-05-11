using System;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Observer
{
    public class Personaje : MonoBehaviour
    {
        public event Action<float, float> OnUpdateLife = delegate{};

        public Button reduceLife;
        public Button increaseLife;

        public float totalLife;
        public float initialLife;
        private float _life;

        private void Start()
        {
            reduceLife.onClick.AddListener(ReduceLife);
            increaseLife.onClick.AddListener(IncreaseLife);
            _life = initialLife;
            OnUpdateLife(_life, totalLife);
        }

        private void IncreaseLife()
        {
            _life = Mathf.Clamp(_life + 10, 0, totalLife);
            OnUpdateLife(_life, totalLife);
        }

        private void ReduceLife()
        {
            _life = Mathf.Clamp(_life - 10, 0, totalLife);
            OnUpdateLife(_life, totalLife);
        }
    }
}
