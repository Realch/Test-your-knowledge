using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void KonfirmasiJawaban(bool isCorrect)
    {
        if (isCorrect)
        {
            ScoreController.Score += 10;
        }
        else
        {
            ScoreController.Score += 0;
        }

        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);

    }

    public void BacktoMenu(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
