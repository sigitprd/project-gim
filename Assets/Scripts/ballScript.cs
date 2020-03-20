using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 20;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, -1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "WallLeft" || collision.collider.name == "WallRight")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
        }
    }
}
