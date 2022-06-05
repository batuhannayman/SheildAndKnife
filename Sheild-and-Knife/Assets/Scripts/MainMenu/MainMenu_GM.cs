using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_GM : MonoBehaviour
{
    AudioSource audio_Source;
    [SerializeField] AudioClip button_Sound;

    private void Start()
    {
        audio_Source = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
        }
    }

    public void btn_Play_Click()
    {
        audio_Source.PlayOneShot(button_Sound);
        PlayerPrefs.SetInt("choosen_Level",0);
        SceneManager.LoadScene(1);
    }

    public void btn_Levels_Click()
    {
        audio_Source.PlayOneShot(button_Sound);
        SceneManager.LoadScene(2);
    }

    public void btn_Options_Click()
    {
        audio_Source.PlayOneShot(button_Sound);
        SceneManager.LoadScene(3);
    }

    public void btn_Exit_Click()
    {
        Application.Quit();
    }
}
