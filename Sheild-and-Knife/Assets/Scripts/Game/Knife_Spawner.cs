using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knife_Spawner : MonoBehaviour
{
    public static Knife_Spawner instance;
    [SerializeField] private Text txt_Knife;
    [SerializeField] private GameObject knife;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        txt_Knife.text = LevelManager_GM.knife_Count.ToString();
        SpawnKnife();
    }

    public void Fired()
    {
        LevelManager_GM.knife_Count--;

        txt_Knife.text = LevelManager_GM.knife_Count.ToString();
    }

    public void SpawnKnife()
    {
        Instantiate(knife, transform.position = new Vector3(0.007f, -2.15f, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
