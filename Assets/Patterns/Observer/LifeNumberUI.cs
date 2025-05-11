using TMPro;
using UnityEngine;

namespace Patterns.Observer
{
    public class LifeNumberUI : MonoBehaviour
    {
        public Personaje personaje;
        public TextMeshProUGUI lifeText;

        private void Awake()
        {
            personaje.OnUpdateLife += LifeUpdated;
        }

        private void LifeUpdated(float life, float totalLife)
        {
            lifeText.text = "Vida: " + life + "/" + totalLife;
        }
    }
}