using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoringScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText1, scoreText2;
    public static int score1 = 0, score2 = 0;
    void Start()
    {
        scoreText1.text = score1.ToString();
        scoreText2.text = score2.ToString();
    }

    public void UpdateScore(string namaWall)
    {
        if(namaWall == "WallLeft")
        {
            score1 += 1;
            scoreText1.text = score1.ToString();
        }
        else if(namaWall == "WallRight")
        {
            score2 += 1;
            scoreText2.text = score2.ToString();
        }
    }
}
