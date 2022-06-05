using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_GM : MonoBehaviour
{
    AudioSource audio_Source;
    [SerializeField] AudioClip button_Sound;

    [SerializeField] private Button btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,
                                    btn10, btn11, btn12, btn13, btn14, btn15;
    [SerializeField] private int highest_Level;

    // Start is called before the first frame update
    void Start()
    {
        audio_Source = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("highest_Level"))
        {
            highest_Level = PlayerPrefs.GetInt("highest_Level");
            level_View();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelButtons(Button btn)
    {
        btn.enabled = true;
        btn.image.color = new Color32(199, 147, 93, 255);
    }

    void level_View()
    {

        if(highest_Level > 1)
        {
            LevelButtons(btn2);
        }

        if(highest_Level > 2)
        {
            LevelButtons(btn3);
        }

        if(highest_Level > 3)
        {
            LevelButtons(btn4);
        }

        if(highest_Level > 4)
        {
            LevelButtons(btn5);
        }

        if(highest_Level > 5)
        {
            LevelButtons(btn6);
        }

        if(highest_Level > 6)
        {
            LevelButtons(btn7);
        }

        if(highest_Level > 7)
        {
            LevelButtons(btn8);
        }

        if(highest_Level > 8)
        {
            LevelButtons(btn9);
        }

        if(highest_Level > 9)
        {
            LevelButtons(btn10);
        }

        if(highest_Level > 10)
        {
            LevelButtons(btn11);
        }

        if(highest_Level > 11)
        {
            LevelButtons(btn12);
        }

        if(highest_Level > 12)
        {
            LevelButtons(btn13);
        }

        if(highest_Level > 13)
        {
            LevelButtons(btn14);
        }

        if(highest_Level > 14)
        {
            LevelButtons(btn15);
        }
    }


    public void ChoosenSelect(int i)
    {
        audio_Source.PlayOneShot(button_Sound);
        PlayerPrefs.SetInt("choosen_Level", i);
        SceneManager.LoadScene(1);
    }

    public void btn_1()
    {
        ChoosenSelect(1);
    }

    public void btn_2()
    {
        ChoosenSelect(2);
        
    }

    public void btn_3()
    {
        ChoosenSelect(3);
    }

    public void btn_4()
    {
        ChoosenSelect(4);
    }

    public void btn_5()
    {
        ChoosenSelect(5);
    }

    public void btn_6()
    {
        ChoosenSelect(6);
    }

    public void btn_7()
    {
        ChoosenSelect(7);
    }

    public void btn_8()
    {
        ChoosenSelect(8);
    }

    public void btn_9()
    {
        ChoosenSelect(9);
    }

    public void btn_10()
    {
        ChoosenSelect(10);
    }

    public void btn_11()
    {
        ChoosenSelect(11);
    }

    public void btn_12()
    {
        ChoosenSelect(12);
    }

    public void btn_13()
    {
        ChoosenSelect(13);
    }

    public void btn_14()
    {
        ChoosenSelect(14);
    }

    public void btn_15()
    {
        ChoosenSelect(15);
    }

    public void btn_Back()
    {
        audio_Source.PlayOneShot(button_Sound);
        SceneManager.LoadScene(0);
    }
}
