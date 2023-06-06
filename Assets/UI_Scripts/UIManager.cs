using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject introScreen, loginScreen, mainScreen, quizScreen;

    public void TapToStart()
    {
        loginScreen.SetActive(true);
    }

    public void Login()
    {
        introScreen.SetActive(false);
        mainScreen.SetActive(true);
    }

    public void ARScan()
    {
        introScreen.SetActive(false);
        loginScreen.SetActive(false);
        mainScreen.SetActive(false);
        quizScreen.SetActive(false);
        SceneManager.LoadScene("Klima");
    }

    public void TakeQuiz()
    {
        introScreen.SetActive(false);
        loginScreen.SetActive(false);
        quizScreen.SetActive(true);
    }
}
