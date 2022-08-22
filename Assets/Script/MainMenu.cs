using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject PanelAbout;
    public GameObject ConfirmExit;

    public void Play(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void AboutClicked()
    {
        PanelAbout.SetActive(true);
        ConfirmExit.SetActive(false);
    }

    public void ExitClicked()
    {
        PanelAbout.SetActive(false);
        ConfirmExit.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void BacktoMenu()
    {
        ConfirmExit.SetActive(false);
        PanelAbout.SetActive(false);
    }
}
