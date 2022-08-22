using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    Text Scoretext;
    public static int Score;

    void Start()
    {
        Scoretext = GetComponent<Text>();
    }

    void Update()
    {
        Scoretext.text = ""+ Score;
    }
}
