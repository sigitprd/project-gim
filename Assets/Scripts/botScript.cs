using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int w = 20;
    public int s = -20;
    public int speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, w) * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, s) * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * speed;
        }
    }
}
