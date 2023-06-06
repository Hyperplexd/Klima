using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SmoothClimb : MonoBehaviour
{
    public float target;
    public float smoothStep;
    float value;

    public Image img;
    public TMP_Text percentage;

    void Update()
    {
        value = Mathf.Lerp(value, target, smoothStep);
        img.fillAmount = value / 100;
        percentage.text = value.ToString("F1") + "%";
    }
}
