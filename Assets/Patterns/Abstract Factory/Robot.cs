using UnityEngine;

namespace Patterns.Abstract_Factory
{
    public class Robot : IEnemy
    {
        public void Attack() => Debug.Log("Robot shoots lasers.");
    }
    
    public class MedicDrone : IAlly
    {
        public void Heal() => Debug.Log("Drone sprays healing nanobots.");
    }
}