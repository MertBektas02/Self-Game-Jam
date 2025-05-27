using UnityEngine;

public class PlayButtonClickSound : MonoBehaviour
{
    public void PlayClickSound()
    {
        SoundManager.PlaySound(SoundType.ONCLICK);
    }
}
