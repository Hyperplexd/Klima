using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizPointsCollector : MonoBehaviour
{
    public int points;
    public GameObject[] questions;
    bool done = false;
    public GameObject analyzing;
    public GameObject results;

    [Header("Results")]
    public GameObject[] resultsTxt;
    public TMP_Text emissions;

    int QIndex;
    bool canStartQuiz = false;
    public GameObject beginMenu;

    public void BeginQuiz()
    {
        beginMenu.SetActive(false);
        questions[0].SetActive(true);
    }

    public void NextQuestion()
    {
        QIndex++;
        foreach(GameObject obj in questions)
        {
            obj.SetActive(false);
        }
        questions[QIndex].SetActive(true);

        if(QIndex > 4)
        {
            foreach(GameObject obj in questions)
            {
                obj.SetActive(false);
            }

            analyzing.SetActive(true);
            StartCoroutine(Loading());
        }
    }

    IEnumerator Loading()
    {
        float secsToWait = Random.Range(1.5f, 3.2f);
        yield return new WaitForSeconds(secsToWait);
        analyzing.SetActive(false);
        ShowResults();
    }

    void ShowResults()
    {
        if(points >= 1 && points <= 4)
        {
            float emissionsNum = Random.Range(15.5f, 20f);
            emissions.text = emissionsNum.ToString("F2");

            foreach(GameObject obj in resultsTxt)
            {
                obj.SetActive(false);
            }
            resultsTxt[0].SetActive(true);
        }
        else if(points >= 5 && points <= 8)
        {
            float emissionsNum = Random.Range(9f, 12f);
            emissions.text = emissionsNum.ToString("F2");

            foreach(GameObject obj in resultsTxt)
            {
                obj.SetActive(false);
            }
            resultsTxt[1].SetActive(true);
        }
        else if(points >= 9 && points <= 12)
        {
            float emissionsNum = Random.Range(6f, 8f);
            emissions.text = emissionsNum.ToString("F2");

            foreach(GameObject obj in resultsTxt)
            {
                obj.SetActive(false);
            }
            resultsTxt[2].SetActive(true);
        }
        else if(points >= 13 && points <= 15)
        {
            float emissionsNum = Random.Range(3f, 5f);
            emissions.text = emissionsNum.ToString("F2");

            foreach(GameObject obj in resultsTxt)
            {
                obj.SetActive(false);
            }
            resultsTxt[3].SetActive(true);
        }
        results.SetActive(true);
    }
    
    // void Update()
    // {
    //     if(!done)
    //     {
    //         if(QIndex == 5)
    //         {
    //             analyzing.SetActive(true);
    //             StartCoroutine(Loading());
    //         }
    //         else
    //         {
    //             foreach(GameObject obj in questions)
    //             {
    //                 obj.SetActive(false);
    //             }
    //             questions[QIndex].SetActive(true);
    //             done = true;
    //         }
    //     }
    // }

}
