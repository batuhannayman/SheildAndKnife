using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_GM : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("choosen_Level",0);
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
        SceneManager.LoadScene(1);
    }

    public void btn_Levels_Click()
    {
        SceneManager.LoadScene(2);
    }

    public void btn_Options_Click()
    {
        SceneManager.LoadScene(3);
    }

    public void btn_Exit_Click()
    {
        Application.Quit();
    }
}
