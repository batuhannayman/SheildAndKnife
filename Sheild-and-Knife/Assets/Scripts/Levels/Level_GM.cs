using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_GM : MonoBehaviour
{
    [SerializeField] private Button btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,
                                    btn10, btn11, btn12, btn13, btn14, btn15;
    [SerializeField] private int highest_Level;

    // Start is called before the first frame update
    void Start()
    {
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

    void level_View()
    {
        if(highest_Level > 1)
        {
            btn2.enabled = true;
            btn2.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 2)
        {
            btn3.enabled = true;
            btn3.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 3)
        {
            btn4.enabled = true;
            btn4.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 4)
        {
            btn5.enabled = true;
            btn5.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 5)
        {
            btn6.enabled = true;
            btn6.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 6)
        {
            btn7.enabled = true;
            btn7.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 7)
        {
            btn8.enabled = true;
            btn8.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 8)
        {
            btn9.enabled = true;
            btn9.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 9)
        {
            btn10.enabled = true;
            btn10.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 10)
        {
            btn11.enabled = true;
            btn11.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 11)
        {
            btn12.enabled = true;
            btn12.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 12)
        {
            btn13.enabled = true;
            btn13.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 13)
        {
            btn14.enabled = true;
            btn14.image.color = new Color32(199, 147, 93, 255);
        }

        if(highest_Level > 14)
        {
            btn15.enabled = true;
            btn15.image.color = new Color32(199, 147, 93, 255);
        }
    }




    public void btn_1()
    {
        PlayerPrefs.SetInt("choosen_Level",1);
        SceneManager.LoadScene(1);
    }

    public void btn_2()
    {
        PlayerPrefs.SetInt("choosen_Level",2);
        SceneManager.LoadScene(1);
        
    }

    public void btn_3()
    {
        PlayerPrefs.SetInt("choosen_Level",3);
        SceneManager.LoadScene(1);
        
    }

    public void btn_4()
    {
        PlayerPrefs.SetInt("choosen_Level",4);
        SceneManager.LoadScene(1);
    }

    public void btn_5()
    {
        PlayerPrefs.SetInt("choosen_Level",5);
        SceneManager.LoadScene(1);
    }

    public void btn_6()
    {
        PlayerPrefs.SetInt("choosen_Level",6);
        SceneManager.LoadScene(1);
    }

    public void btn_7()
    {
        PlayerPrefs.SetInt("choosen_Level",7);
        SceneManager.LoadScene(1);
    }

    public void btn_8()
    {
        PlayerPrefs.SetInt("choosen_Level",8);
        SceneManager.LoadScene(1);
    }

    public void btn_9()
    {
        PlayerPrefs.SetInt("choosen_Level",9);
        SceneManager.LoadScene(1);
    }

    public void btn_10()
    {
        PlayerPrefs.SetInt("choosen_Level",10);
        SceneManager.LoadScene(1);
    }

    public void btn_11()
    {
        PlayerPrefs.SetInt("choosen_Level",11);
        SceneManager.LoadScene(1);
    }

    public void btn_12()
    {
        PlayerPrefs.SetInt("choosen_Level",12);
        SceneManager.LoadScene(1);
    }

    public void btn_13()
    {
        PlayerPrefs.SetInt("choosen_Level",13);
        SceneManager.LoadScene(1);
    }

    public void btn_14()
    {
        PlayerPrefs.SetInt("choosen_Level",14);
        SceneManager.LoadScene(1);
    }

    public void btn_15()
    {
        PlayerPrefs.SetInt("choosen_Level",15);
        SceneManager.LoadScene(1);
    }

    public void btn_Back()
    {
        SceneManager.LoadScene(0);
    }
}
