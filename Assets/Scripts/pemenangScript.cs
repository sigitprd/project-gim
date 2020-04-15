using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pemenangScript : MonoBehaviour
{
    public TextMeshProUGUI win;
    

    // Start is called before the first frame update
    void Start()
    {
        if(scoringScript.score1 > scoringScript.score2)
        {
            win.text = "Player Kanan Menang!";
        }
        else if(scoringScript.score1 < scoringScript.score2)
        {
            win.text = "Player Kiri Menang!";
        }
        else
        {
            win.text = "Dua Duanya Noob!";
        }
    }

}
