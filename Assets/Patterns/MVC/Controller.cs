using System;
using UnityEngine;

namespace Patterns.MVC
{
    public class Controller : MonoBehaviour
    {
        public Model model;
        
        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                model.ReduceLife();
            }
        }
    }
}