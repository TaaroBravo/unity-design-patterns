using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class AudioFacade : MonoBehaviour
    {
        [SerializeField] private AudioSource sfxSource;
        [SerializeField] private AudioSource musicSource;
        [SerializeField] private AudioClip[] clips;

        private Dictionary<string, AudioClip> _clipLookup;

        void Awake()
        {
            _clipLookup = new Dictionary<string, AudioClip>();
            foreach (var clip in clips)
                _clipLookup[clip.name] = clip;
        }

        public void PlaySFX(string clipName, float volume)
        {
            if (_clipLookup.TryGetValue(clipName, out var clip))
            {
                sfxSource.volume = volume;
                sfxSource.PlayOneShot(clip);
            }
            else
            {
                Debug.LogWarning($"SFX clip not found: {clipName}");
            }
        }

        public void PlayMusic(string clipName, bool loop = true, float volume = 40f)
        {
            if (_clipLookup.TryGetValue(clipName, out var clip))
            {
                musicSource.clip = clip;
                musicSource.loop = loop;
                musicSource.volume = volume;
                musicSource.Play();
            }
            else
            {
                Debug.LogWarning($"Music clip not found: {clipName}");
            }
        }
    }
}