using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;

    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}