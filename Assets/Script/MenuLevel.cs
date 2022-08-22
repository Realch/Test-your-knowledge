using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevel : MonoBehaviour
{
    public void BiologiClicked(string scenename)
    {
        SceneManager.LoadScene(scenename);
        ScoreController.Score = 0;
    }

    public void KimiaClicked(string scenename)
    {
        SceneManager.LoadScene(scenename);
        ScoreController.Score = 0;
    }

    public void FisikaClicked(string scenename)
    {
        SceneManager.LoadScene(scenename);
        ScoreController.Score = 0;
    }
}
