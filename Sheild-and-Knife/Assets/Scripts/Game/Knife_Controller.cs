using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife_Controller : MonoBehaviour
{
    Rigidbody2D rigid;
    [SerializeField] private int speed;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        this.gameObject.transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigid.velocity = Vector2.up * speed * Time.deltaTime;
            
            
        }
    }

    private void FreezeKnife()
    {
        rigid.velocity = Vector2.zero;
        transform.GetComponent<Knife_Controller>().enabled = false;
        rigid.freezeRotation = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LevelManager_GM.knife_Count < 2)
        {
            if (collision.gameObject.tag == "Sheild")
            {
                if (LevelManager_GM.level != 16)
                {
                    Sound_Controller.instance.PlayWinSound();
                    FreezeKnife();
                    LevelManager_GM.instance.Win();
                }
                else
                {
                    Sound_Controller.instance.PlayWinSound();
                    FreezeKnife();
                    LevelManager_GM.instance.GameOver();
                    GameObject.FindWithTag("Sheild").transform.GetComponent<Sheild_Movement>().enabled = false;
                    Destroy(GameObject.FindWithTag("Respawn"));
                    Destroy(GameObject.FindWithTag("Knife"));
                }
            }
            else if (collision.gameObject.tag == "Needle" || collision.gameObject.tag == "Knife")
            {
                Sound_Controller.instance.PlayLoseSound();
                FreezeKnife();
                LevelManager_GM.instance.Lose();
            }

            Knife_Spawner.instance.Fired();
        }
        else
        {
            if (collision.gameObject.tag == "Sheild")
            {
                Sound_Controller.instance.PlayKnifeSound();
                transform.SetParent(collision.gameObject.transform);
                Knife_Spawner.instance.Fired();
                Knife_Spawner.instance.SpawnKnife();
            }
            else if (collision.gameObject.tag == "Needle" || collision.gameObject.tag == "Knife")
            {
                Sound_Controller.instance.PlayLoseSound();
                LevelManager_GM.instance.Lose();
            }
            
            FreezeKnife();
        }
        
    }
}
