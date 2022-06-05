using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheild_Movement : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0,- 40 * speed * Time.deltaTime);
    }
}
