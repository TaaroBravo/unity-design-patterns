using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Observer
{
    public class LifeBarUI : MonoBehaviour
    {
        public Personaje personaje;
        public Image lifebar;

        private void Awake()
        {
            personaje.OnUpdateLife += LifeUpdated;
        }

        private void LifeUpdated(float life, float totalLife)
        {
            lifebar.fillAmount = life / totalLife;
        }
    }
}