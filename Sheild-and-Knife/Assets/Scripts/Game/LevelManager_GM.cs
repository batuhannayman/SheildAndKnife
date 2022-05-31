using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager_GM : MonoBehaviour
{
    public static LevelManager_GM instance;
    [SerializeField] private Text txt_Level;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        LoadLevel();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        int level = PlayerPrefs.GetInt("choosen_Level");
        txt_Level.text = level.ToString();
    }
}
