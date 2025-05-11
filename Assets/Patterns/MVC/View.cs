using System;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.MVC
{
    public class View : MonoBehaviour{

        public Image lifeBar;

        public void ShowLives(int lives)
        {
            
        }

        public void ShowCurrentWorld(string world)
        {
            
        }

        public void ShowCurrentPoints(int points)
        {
            
        }
        
        public void ShowLifeReduced()
        {
            lifeBar.color = Color.red;
        }
    }
}