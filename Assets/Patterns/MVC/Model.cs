using UnityEngine;

namespace Patterns.MVC
{
    public class Model : MonoBehaviour
    {
        public View view;
        private int _life = 1000;

        public void ReduceLife()
        {
            _life -= 100;
            view.ShowLifeReduced();
        }
    }
}
