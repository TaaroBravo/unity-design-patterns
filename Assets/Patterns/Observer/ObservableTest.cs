using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class ObservableTest : MonoBehaviour, IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                foreach (var observer in _observers)
                    observer.OnNotify("Presionó izquierda");
            }
            
            if (Input.GetKeyDown(KeyCode.W))
            {
                foreach (var observer in _observers)
                    observer.OnNotify("Presionó arriba");
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                foreach (var observer in _observers)
                    observer.OnNotify("Presionó abajo");
            }
            
            if (Input.GetKeyDown(KeyCode.D))
            {
                foreach (var observer in _observers)
                    observer.OnNotify("Presionó derecha");
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var observer in _observers)
                    observer.OnNotify("Presionó Espacio");
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}