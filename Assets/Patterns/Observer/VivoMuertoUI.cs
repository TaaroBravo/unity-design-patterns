using TMPro;
using UnityEngine;

namespace Patterns.Observer
{
    public class VivoMuertoUI : MonoBehaviour
    {
        public Personaje personaje;
        public TextMeshProUGUI text;

        private void Awake()
        {
            personaje.OnUpdateLife += LifeUpdated;
        }

        private void LifeUpdated(float life, float totalLife)
        {
            if (life == totalLife)
                text.text = "Mi personaje está: Vivo";
            else if (life > 0)
                text.text = "Mi personaje está: Dañado";
            else
                text.text = "Mi personaje está: Muerto";
        }
    }
}