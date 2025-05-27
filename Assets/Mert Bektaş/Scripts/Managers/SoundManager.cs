using System.Runtime.InteropServices;
using UnityEngine;

public enum SoundType
{
    ONCLICK,
    ONHOVER,
    BACKGORUND
}
[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] SoundList;
    private static SoundManager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayBackgroundMusic();
    }

    public static void PlaySound(SoundType sound, float volume = 1f)
    {
        instance.audioSource.PlayOneShot(instance.SoundList[(int)sound]);
    }
   

       public static void PlayBackgroundMusic()
    {
        instance.audioSource.clip = instance.SoundList[(int)SoundType.BACKGORUND];
        instance.audioSource.loop = true;
        instance.audioSource.volume = 1f; // veya istediğin seviye
        instance.audioSource.Play();
    }
}