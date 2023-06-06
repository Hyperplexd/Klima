using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Percent : MonoBehaviour
{
    public float percentage;
    private float m_smoothScore;
    private float m_smoothScoreVelocity;
    private int m_displayedScore = -1;

    public TMP_Text percentTxt;

    public RadialCounter counter;
    
    void Update()
    {
        m_smoothScore = Mathf.SmoothDamp(m_smoothScore, (float)percentage, ref m_smoothScoreVelocity, 0.5f, Mathf.Infinity, Time.deltaTime);
        
        float toDisplay = (int)Mathf.Round(m_smoothScore);

        counter.fillValue = toDisplay;
        percentTxt.text = toDisplay.ToString() + "%";
    }
}
