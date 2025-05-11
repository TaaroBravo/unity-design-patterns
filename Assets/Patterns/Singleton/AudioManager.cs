using System;
using UnityEngine;

namespace Patterns.Singleton
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
            LocalSaveGameManager.Instance.Show();
        }
    }

    public class LocalSaveGameManager : MonoBehaviour
    {
        public static LocalSaveGameManager Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
