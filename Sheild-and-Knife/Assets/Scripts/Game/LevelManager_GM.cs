using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager_GM : MonoBehaviour
{
    public static LevelManager_GM instance;
    [SerializeField] private Text txt_Level;
    [SerializeField] private GameObject LosePanel, WinPanel, GameOverPanel;
    public static int level;
    public static int knife_Count;

    private GameObject sheild;

    [SerializeField] GameObject s1, s2, s3, s4, s5;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        LoadLevel();
        
    }

    public void btn_TryAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void btn_GoBackMain()
    {
        SceneManager.LoadScene(0);
    }
    public void btn_NextLevel()
    {
        NextLevel();
    }


    public void Win()
    {
        WinPanel.SetActive(true);
        GameObject.FindWithTag("Sheild").transform.GetComponent<Sheild_Movement>().enabled = false;
        Destroy(GameObject.FindWithTag("Respawn"));
        Destroy(GameObject.FindWithTag("Knife"));
    }

    public void Lose()
    {
        LosePanel.SetActive(true);
        GameObject.FindWithTag("Sheild").transform.GetComponent<Sheild_Movement>().enabled = false;
        Destroy(GameObject.FindWithTag("Respawn"));
        Destroy(GameObject.FindWithTag("Knife"));
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        PlayerPrefs.SetInt("highest_Level", 15);
    }

    public void NextLevel()
    {
        if (PlayerPrefs.GetInt("choosen_Level") > 0)
        {
            level = PlayerPrefs.GetInt("choosen_Level") + 1;
            PlayerPrefs.SetInt("choosen_Level", level);
        }
        else
        {
            level = PlayerPrefs.GetInt("highest_Level") + 1;
            PlayerPrefs.SetInt("highest_Level", level);
        }

        if (PlayerPrefs.GetInt("choosen_Level") > PlayerPrefs.GetInt("highest_Level"))
        {
            PlayerPrefs.SetInt("highest_Level", PlayerPrefs.GetInt("choosen_Level"));
        }

        SceneManager.LoadScene(1);
    }

    public void LoadLevel()
    {
        if(PlayerPrefs.GetInt("choosen_Level") > 0)
        {
            level = PlayerPrefs.GetInt("choosen_Level");
            txt_Level.text = PlayerPrefs.GetInt("choosen_Level").ToString();
        }
        else
        {
            if(PlayerPrefs.GetInt("highest_Level") > 0)
            {
                level = PlayerPrefs.GetInt("highest_Level");
            }
            else
            {
                PlayerPrefs.SetInt("highest_Level", 1);
                level = PlayerPrefs.GetInt("highest_Level");
            }

            txt_Level.text = level.ToString();
        }

        switch(level)
        {
            case 1:
                sheild = s1;
                knife_Count = 10;
                break;

            case 2:
                sheild = s1;
                knife_Count = 12;
                break;

            case 3:
                sheild = s1;
                knife_Count = 14;
                break;

            case 4:
                sheild = s1;
                knife_Count = 16;
                break;

            case 5:
                sheild = s2;
                knife_Count = 10;
                break;

            case 6:
                sheild = s2;
                knife_Count = 12;
                break;

            case 7:
                sheild = s3;
                knife_Count = 10;
                break;

            case 8:
                sheild = s3;
                knife_Count = 12;
                break;

            case 9:
                sheild = s3;
                knife_Count = 14;
                break;

            case 10:
                sheild = s4;
                knife_Count = 10;
                break;

            case 11:
                sheild = s4;
                knife_Count = 12;
                break;

            case 12:
                sheild = s5;
                knife_Count = 14;
                break;

            case 13:
                sheild = s5;
                knife_Count = 10;
                break;

            case 14:
                sheild = s5;
                knife_Count = 12;
                break;

            case 15:
                sheild = s5;
                knife_Count = 14;
                break;
            case 16:
                sheild = s3;
                knife_Count = 18;
                break;
        }

        Instantiate(sheild, transform.position = new Vector3(0f, 3f, 0), transform.rotation);
    }
}
