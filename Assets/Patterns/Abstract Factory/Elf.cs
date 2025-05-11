using UnityEngine;

namespace Patterns.Abstract_Factory
{
    public class Elf : IAlly
    {
        public void Heal() => Debug.Log("Elf heals with magic.");
    }
    
    public class OrcEnemy : IEnemy
    {
        public void Attack() => Debug.Log("Orc smashes!");
    }
}