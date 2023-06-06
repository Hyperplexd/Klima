using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialCounter : MonoBehaviour
{
    [Range(0, 100)] public float fillValue = 0;
    public Image fillImg;
    public RectTransform handleStart;

    public GameObject[] fillGO;

    void Update()
    {
        if(fillValue < 1)
        {
            foreach(GameObject obj in fillGO)
            {
                obj.SetActive(false);
            }
        }
        else
        {
            foreach(GameObject obj in fillGO)
            {
                obj.SetActive(true);
            }
        }

        fillCircle(fillValue);
    }

    void fillCircle(float value)
    {
        float fillAmnt = (value / 100.0f);
        fillImg.fillAmount = fillAmnt;
        float angle = fillAmnt * 360;
        handleStart.localEulerAngles = new Vector3(0, 0, -angle);
    }
}
