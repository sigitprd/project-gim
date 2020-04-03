using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 20;
    public Rigidbody2D ball;
    public Animator animtr;

    void Start()
    {
        //ball.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        StartCoroutine(hitungMundurStart());
        animtr.SetBool("IsMove", true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball.velocity.x > 0) //kekanan
        {
            ball.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
        else //kekiri
        {
            ball.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.name == "WallLeft" || collision.collider.name == "WallRight")
        {
            //GetComponent<Transform>().position = new Vector2(0, 0);
            StartCoroutine(hitungMundurCollision());
        }

    }

    IEnumerator hitungMundurStart()
    {
        
        yield return new WaitForSeconds(1);
        //ball.constraints &= ~RigidbodyConstraints2D.None;
        ball.velocity = new Vector2(1, -1) * speed;
    }

    IEnumerator hitungMundurCollision()
    {
        ball.velocity = Vector2.zero;
        animtr.SetBool("IsMove", false);
        ball.GetComponent<Transform>().position = new Vector2(0, 0);
        yield return new WaitForSeconds(1);
        //Start();
        
        ball.velocity = new Vector2(1, -1) * speed;
        animtr.SetBool("IsMove", true);
    }
}
