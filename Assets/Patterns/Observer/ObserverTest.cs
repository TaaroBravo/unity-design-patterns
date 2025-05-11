using UnityEngine;

namespace Patterns.Observer
{
    public class ObserverTest : MonoBehaviour, IObserver
    {
        public ObservableTest observable;
        
        private void Start()
        {
            if(observable)
                observable.AddObserver(this);
        }

        public void OnNotify(params object[] parameters)
        {
            Debug.Log(parameters[0]);
        }
    }
}