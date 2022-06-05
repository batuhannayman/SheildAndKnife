using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options_GM : MonoBehaviour
{
    [SerializeField] Slider slider;

    AudioSource audio_Source;
    [SerializeField] AudioClip button_Sound;

    // Start is called before the first frame update
    void Start()
    {
        audio_Source = GetComponent<AudioSource>();
        LoadAudio();
    }

    public void SetAudio(float value)
    {
        AudioListener.volume = value;
        SaveAudio();
    }

    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("audioVolume", AudioListener.volume);
    }

    private void LoadAudio()
    {
        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
    }

    public void btn_Back_Click()
    {
        audio_Source.PlayOneShot(button_Sound);
        SceneManager.LoadScene(0);
    }
}
