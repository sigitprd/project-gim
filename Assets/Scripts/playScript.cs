﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playScript : MonoBehaviour
{
    public void Mulai()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
