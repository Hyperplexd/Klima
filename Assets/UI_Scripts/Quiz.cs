using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [Header("• Answers")]
    public GameObject[] answers;
    public Color32 selectedColor;
    public Color32 normalColor;

    [Header("• Questions")]
    public bool selectedQ;



    public void Answer(int ansID)
    {
        foreach(GameObject obj in answers)
        {
            obj.GetComponent<Image>().color = normalColor;
            obj.transform.GetChild(2).gameObject.SetActive(false);
        }
        answers[ansID].GetComponent<Image>().color = selectedColor;
        answers[ansID].transform.GetChild(2).gameObject.SetActive(true);
        selectedQ = true;
    }
}
