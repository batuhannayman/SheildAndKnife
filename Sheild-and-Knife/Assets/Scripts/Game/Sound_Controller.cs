using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Controller : MonoBehaviour
{
    AudioSource audio_Source;
    [SerializeField] AudioClip win_Sound, lose_Sound, button_Sound, knife_Sound;

    public static Sound_Controller instance;

    // Start is called before the first frame update
    void Start()
    {
        audio_Source = GetComponent<AudioSource>();
        instance = this;
    }

    public void PlayLoseSound()
    {
        audio_Source.PlayOneShot(lose_Sound);
    }
    public void PlayWinSound()
    {
        audio_Source.PlayOneShot(win_Sound);
    }
    public void PlayKnifeSound()
    {
        audio_Source.PlayOneShot(knife_Sound);
    }
    public void PlayButtonSound()
    {
        audio_Source.PlayOneShot(button_Sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
