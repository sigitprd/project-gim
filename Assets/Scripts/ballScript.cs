using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update
    //public int speed = 20;
    public Rigidbody2D ball;
    public Animator animtr;
    public GameObject masterScript;
    //public int score1 = 0;
    //public int score2 = 0;
    //public TextMeshProUGUI scoreText1;
    //public TextMeshProUGUI scoreText2;

    void Start()
    {
        //ball.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        //scoreText1.text = "0";
        //scoreText2.text = "0";
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
            ////GetComponent<Transform>().position = new Vector2(0, 0);
            //score1 += 1;
            //scoreText1.text = score1.ToString();
            masterScript.GetComponent<scoringScript>().UpdateScore(collision.collider.name);
            StartCoroutine(hitungMundurCollision());
        } 
        //else if(collision.collider.name == "WallRight")
        //{
        //    score2 += 1;
        //    scoreText2.text = score2.ToString();
        //    StartCoroutine(hitungMundurCollision());
        //}

    }

    IEnumerator hitungMundurStart()
    {
        int x = Random.Range(0, 2) * 2 - 1; //nilai x bisa bernilai -1 atau 1
        int y = Random.Range(0, 2) * 2 - 1; //nilai y bisa bernilai -1 atau 1
        int speed = Random.Range(20, 26); //random kecepatan
        yield return new WaitForSeconds(1);
        //ball.constraints &= ~RigidbodyConstraints2D.None;
        ball.velocity = new Vector2(x, y) * speed;
        ball.GetComponent<Transform>().position = Vector2.zero;
    }

    IEnumerator hitungMundurCollision()
    {
        ball.velocity = Vector2.zero;
        animtr.SetBool("IsMove", false);
        ball.GetComponent<Transform>().position = new Vector2(0, 0);
        yield return new WaitForSeconds(1);
        //Start();
        int x = Random.Range(0, 2) * 2 - 1; //nilai x bisa bernilai -1 atau 1
        int y = Random.Range(0, 2) * 2 - 1; //nilai y bisa bernilai -1 atau 1
        int speed = Random.Range(20, 26); //random kecepatan
        ball.velocity = new Vector2(x, y) * speed;
        animtr.SetBool("IsMove", true);
    }
}
