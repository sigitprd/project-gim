using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    public int counter = 15;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Time: " + counter.ToString();
        StartCoroutine(hitungMundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator hitungMundur()
    {
        while(counter > 0)
        {
            yield return new WaitForSeconds(2);
            counter -= 1;
            timerText.text = "Time: " + counter.ToString();
        }

        SceneManager.LoadScene("GameOverScene");
        
    }
}
